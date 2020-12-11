using mukavemet.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Configurations;
using System.Windows.Media;

namespace mukavemet
{
    public partial class FormData : Form
    {
        private SQLiteConnection connection;
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private Panel pnHamburger = new Panel();
        private Timer tmrDelayHiding = new Timer { Interval = 10 };
        private string[] selectedProducts;
        private string[] selectedUsers;
        private string mesType;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private string dbfile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ABS Alçı ve Blok Sanayi\Mukavemet\mukavemet.db";
        private ChartValues<MeasureModel> crtVls { get; set; }


        public FormData()
        {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered", 
                BindingFlags.NonPublic | BindingFlags.Instance | 
                BindingFlags.SetProperty, null, dgwKayit,
                new object[] { true });

            //MessageBox.Show(Path.GetFullPath(dbfile + "\\.."));
            pnHamburger.Top = btHamburgerMenu.Bottom + 10;
            pnHamburger.Left = btHamburgerMenu.Left;
            pnHamburger.BackColor = System.Drawing.Color.Black;
            pnHamburger.Size = new Size(240, 104);
            pnHamburger.BorderStyle = BorderStyle.FixedSingle;
            pnHamburger.Controls.Add(btImportDatabase);
            btImportDatabase.Dock = DockStyle.Top;
            pnHamburger.Controls.Add(btBackupDatabase);
            btBackupDatabase.Dock = DockStyle.Bottom;
            btBackupDatabase.Height = pnHamburger.Height / 2 - 1;
            btImportDatabase.Height = pnHamburger.Height / 2 - 1;
            tmrDelayHiding.Tick += TmrDelayHiding_Tick;

            pnProduct.Controls.Remove(clbxProductFilter);
            this.Controls.Add(clbxProductFilter);
            clbxProductFilter.Location = tableLayoutPanel2.Location;
            clbxProductFilter.BringToFront();

            pnUser.Controls.Remove(clbxUserFilter);
            this.Controls.Add(clbxUserFilter);
            clbxUserFilter.Location = tableLayoutPanel3.Location;
            clbxUserFilter.BringToFront();

            pnChart.Dock = DockStyle.Fill;

            var mapper = Mappers.Xy<MeasureModel>()
                .X(model => model.Time.Ticks)
                .Y(model => model.Value);

            Charting.For<MeasureModel>(mapper);
        }

        private void btDataBase_Click(object sender, EventArgs e)
        {
            //connection = new SQLiteConnection(@"data source=./mukavemet.db");
            connection = new SQLiteConnection("data source=" + dbfile);
            if (clbxProductFilter.Enabled)
                btProductFilter.PerformClick();

            if (clbxUserFilter.Enabled)
                btUserFilter.PerformClick();

            try
            {
                string query;
                connection.Open();

                query = "SELECT * FROM mukayit";

                if (chbPickDate.Checked)
                {
                    DateTime dtFromDate = dtpFrom.Value.Date;
                    DateTime dtToDate = dtpTo.Value.Date.AddDays(1) -
                        TimeSpan.FromSeconds(1);
                    string fromDate = dtFromDate.ToString("yyyy-MM-dd HH:mm:ss");
                    string toDate = dtToDate.ToString("yyyy-MM-dd HH:mm:ss");

                        query = query + "WHERE Tarih BETWEEN \'" +
                            fromDate + "\' AND \'" + toDate + "\'";
                }

                if (!rbBoth.Checked)
                {

                    if (rbBendOnly.Checked)
                        mesType = "Eğilme";
                    else
                        mesType = "Basınç";

                    if (chbPickDate.Checked)
                        query = query + " AND \"Ölçüm Türü\" IS \"" + mesType + "\"";
                    else
                        query = query + " WHERE \"Ölçüm Türü\" IS \"" + mesType + "\"";
                }

                if (chbProductFilter.Checked)
                {
                    if (selectedProducts.Length != 0)
                    {
                        StringBuilder sbProducts = new StringBuilder();

                        for (int i = 0; i < selectedProducts.Length; i++)
                        {
                            sbProducts.Append('\"');
                            sbProducts.Append(selectedProducts[i]);
                            sbProducts.Append('\"');
                            if (i != selectedProducts.Length - 1)
                                sbProducts.Append(',');
                        }

                        if (chbPickDate.Checked || !rbBoth.Checked)
                            query = query + " AND \"Ürün Cinsi\" IN (" + sbProducts.ToString() + ")";
                        else
                            query = query + " WHERE \"Ürün Cinsi\" IN (" + sbProducts.ToString() + ")";
                    }
                    else
                        MessageBox.Show("Kullanıcı filtreleme açık fakat hiç kullanıcı seçilmedi.\nTüm kullanıcılar gösterilecek.");
                }

                if (chbUserFilter.Checked)
                {
                    if (selectedUsers.Length != 0)
                    {
                        StringBuilder sbUsers = new StringBuilder();

                        for (int i = 0; i < selectedUsers.Length; i++)
                        {
                            sbUsers.Append('\"');
                            sbUsers.Append(selectedUsers[i]);
                            sbUsers.Append('\"');
                            if (i != selectedUsers.Length - 1)
                                sbUsers.Append(',');
                        }

                        if (chbProductFilter.Checked ||
                            chbPickDate.Checked || !rbBoth.Checked)
                            query = query + " AND \"Ölçümü Yapan\" IN (" +
                                sbUsers.ToString() + ")";
                        else
                            query = query + " WHERE \"Ölçümü Yapan\" IN (" +
                                sbUsers.ToString() + ")";
                    }
                    else
                        MessageBox.Show("Ürün filtreleme açık fakat hiç ürün " +
                            "seçilmedi.\nTüm ürünler gösterilecek.");
                }

                SQLiteCommand command = new SQLiteCommand(query, connection);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(dt);
                adapter.Dispose();
                dgwKayit.Enabled = true;
                dgwKayit.Visible = true;
                dgwKayit.DataSource = dt;
                connection.Close();
                dgwKayit.ColumnHeadersDefaultCellStyle.Font = new Font(
                    dgwKayit.ColumnHeadersDefaultCellStyle.Font.FontFamily,
                    12f,
                    FontStyle.Bold);
                dgwKayit.DefaultCellStyle.Font = new Font(
                    dgwKayit.DefaultCellStyle.Font.FontFamily,
                    10.8f,
                    FontStyle.Regular);
                dgwKayit.AutoResizeRows();
                dgwKayit.AutoResizeColumns();
                dgwKayit.BackgroundColor = System.Drawing.Color.White;
                dgwKayit.FirstDisplayedScrollingRowIndex = dgwKayit.RowCount - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void btExportToExcel_Click(object sender, EventArgs e)
        {
            btDataBase.PerformClick();
            Excel.Application xlexcel;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true; // false;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (int i = 1; i < dgwKayit.Columns.Count + 1; i++)
            {
                xlWorkSheet.Cells[1, i] = dgwKayit.Columns[i - 1].HeaderText;
                xlWorkSheet.Cells[1, i].Font.Bold = true;
            }
            for (int i = 0; i < dgwKayit.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgwKayit.Columns.Count; j++)
                {
                    xlWorkSheet.Cells[i + 2, j + 1] = dgwKayit.Rows[i].Cells[j].Value;
                }
            }

            Excel.Range range;
            range = xlWorkSheet.UsedRange;
            range.Columns.AutoFit();
            string time = DateTime.Now.ToString("yy-MM-dd HH-mm-ss");
            string directory = Environment.GetEnvironmentVariable("USERPROFILE") + 
                @"\Documents\MukavemetRaporları";

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            object filename = directory + @"\Mukavemet_Ölçüm_Raporu " + time;

            xlWorkBook.SaveAs(filename);
            //            xlWorkBook.Close();
        }

        private void chbPickDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPickDate.Checked)
            {
                dtpFrom.Enabled = true;
                dtpTo.Enabled = true;
            }
            else
            {
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;
            }
        }

        private void btHide_Click(object sender, EventArgs e)
        {
            dgwKayit.Enabled = false;
            dgwKayit.Visible = false;
        }

        private void btRemoveSelected_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog("Parola:", "Yetkilendirme");
            if (promptValue == Settings.Default.Auth)
            {
                string[] noValues = GetNoValues(dgwKayit.SelectedCells);

                if (noValues.Length != 0)
                {
                    StringBuilder message = new StringBuilder(
                        "Şu numaralı kayıtlar silinecek: ");

                    foreach (string noValue in noValues)
                    {
                        message.Append(noValue);
                        if (noValue != noValues[noValues.Length - 1])
                            message.Append(", ");
                        else
                            message.Append(". Devam etmek istediğinizden emin misiniz?\n" +
                                "(Bu işlem geri alınamaz!)");
                    }

                    var result = MessageBox.Show(
                        message.ToString(),
                        "Dikkat",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            DeleteFromDB(noValues, "mukayit");
                            DeleteFromDB(noValues, "graf");

                            btDataBase.PerformClick();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            connection.Close();
                        }
                    }
                }
                dgwKayit.AutoResizeColumns();
            }
        }

        private void DeleteFromDB(string[] noValues, string table)
        {
            connection.Open();
            StringBuilder query = new StringBuilder(
                "DELETE FROM " + table + " WHERE No in (");

            foreach (string noValue in noValues)
            {
                query.Append(noValue);
                if (noValue != noValues[noValues.Length - 1])
                    query.Append(',');
                else
                    query.Append(')');
            }
            SQLiteCommand command = new SQLiteCommand(
                query.ToString(), connection);

            command.ExecuteNonQuery();
            connection.Close();
        }

        private string[] GetNoValues(DataGridViewSelectedCellCollection cells)
        {
            string[] noValues = new string[0];
            int[] inx = new int[0];
            foreach (DataGridViewCell cell in cells)
            {
                if (!inx.Contains(cell.RowIndex) &&
                    cell.RowIndex < dgwKayit.Rows.Count - 1)
                {
                    Array.Resize(ref inx, inx.Length + 1);
                    inx[inx.Length - 1] = cell.RowIndex;
                    Array.Resize(ref noValues, noValues.Length + 1);
                    noValues[noValues.Length - 1] = 
                        dgwKayit.Rows[inx[inx.Length - 1]].Cells[0].Value.ToString();
                }
            }
            return noValues;
        }

        private void ShowGraph(string noOfClicked, string mesValue, string type, string date, string product, string user)
        {
            lbTitle.Text = "Ölçüm No: " + noOfClicked + " - " + date;
            lbN.Text = mesValue + " N";
            if(type == "Eğilme")
                lbNmm2.Text = (Double.Parse(mesValue) * Settings.Default.BendCoef).ToString() + " N/mm²";
            else if (type == "Basınç")
                lbNmm2.Text = (Double.Parse(mesValue) * Settings.Default.PresCoef).ToString() + " N/mm²";
            else
                lbNmm2.Text = "Ölçüm tipi belli değil";
            lbType.Text = product + " " + type + " Testi (" + user + ")";

            int LocX = pnChart.Width / 50;
            int LocY = pnChart.Height / 8;

            crtVls = new ChartValues<MeasureModel>();

            #region InitChart
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                | AnchorStyles.Left
                | AnchorStyles.Right,
                Location = new Point(LocX, LocY),
                Margin = new Padding(30),
                Name = "cartesianChart1",
                Size = new Size(pnChart.Width - (LocX * 2), pnChart.Height - LocY * 3),
                TabIndex = 57,
                Text = "cartesianChart1",
                BackColor = System.Drawing.Color.FromArgb(0, 86, 168),
                AnimationsSpeed = TimeSpan.FromMilliseconds(250),
                Hoverable = false,
                Series = new SeriesCollection
                {
                    new LineSeries
                    {
                    Values = crtVls,
                    PointGeometrySize = 4,
                    StrokeThickness = 2,

                    Fill = new LinearGradientBrush(
                        System.Windows.Media.Color.FromArgb(0xcc, 0xff, 0xff, 0xff),
                        System.Windows.Media.Color.FromArgb(0x64, 0xff, 0xff, 0xff),
                        90),
                    Stroke = new SolidColorBrush(
                        System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0xff))
                    }
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                LabelFormatter = value => new TimeSpan((long)value)
                .TotalMilliseconds.ToString() + "ms",
                Separator = new Separator
                {
                    Step = TimeSpan.FromMilliseconds(500).Ticks
                },
                MinValue = 0
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                MinValue = 0

            });
            #endregion

            pnChart.Controls.Add(cartesianChart1);
            cartesianChart1.BringToFront();
            pnChart.Enabled = true;
            pnChart.Visible = true;

            try
            {
                var models = new MeasureModel[0];

                #region SQLite Reading
                connection.Open();
                string query = "SELECT * FROM graf WHERE \"No\" IS " + noOfClicked;
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Array.Resize(ref models, models.Length + 1);
                            models[models.Length - 1] = new MeasureModel
                            {
                                Time = TimeSpan.FromTicks(reader.GetInt64(2)),
                                Value = reader.GetFloat(1)
                            };
                        }
                        reader.Close();
                    }
                }
                connection.Close(); 
                #endregion

                
                crtVls.AddRange(models);
                cartesianChart1.AxisX[0].MaxValue = models.Last().Time.Ticks
                    + TimeSpan.FromMilliseconds(100).Ticks;
                models = null;
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            dgwKayit.DefaultCellStyle.Font = new Font(
                dgwKayit.DefaultCellStyle.Font.FontFamily,
                dgwKayit.DefaultCellStyle.Font.Size * 1.133f,
                FontStyle.Regular);

            dgwKayit.ColumnHeadersDefaultCellStyle.Font = new Font(
                dgwKayit.ColumnHeadersDefaultCellStyle.Font.FontFamily, 
                dgwKayit.ColumnHeadersDefaultCellStyle.Font.Size * 1.133f,
                FontStyle.Bold);

            dgwKayit.AutoResizeRows();
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            if (dgwKayit.DefaultCellStyle.Font.Size - 1f > 8f)
            {
                dgwKayit.DefaultCellStyle.Font = new Font(
                    dgwKayit.DefaultCellStyle.Font.FontFamily,
                    dgwKayit.DefaultCellStyle.Font.Size / 1.133f,
                    FontStyle.Regular);

                dgwKayit.ColumnHeadersDefaultCellStyle.Font = new Font(
                    dgwKayit.ColumnHeadersDefaultCellStyle.Font.FontFamily,
                    dgwKayit.ColumnHeadersDefaultCellStyle.Font.Size / 1.133f,
                    FontStyle.Bold);

                dgwKayit.AutoResizeRows();

            }
        }

        private void btHamburgerMenu_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(pnHamburger))
            {
                this.Controls.Add(pnHamburger);
                pnHamburger.BringToFront();

            }
            else if (pnHamburger.Visible)
            {
                pnHamburger.Enabled = false;
                pnHamburger.Visible = false;
            }
            else
            {
                pnHamburger.Enabled = true;
                pnHamburger.Visible = true;
            }
        }

        private void btBackupDatabase_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string outpath = folderBrowserDialog1.SelectedPath;
                string temppath = outpath + @"\tempDir";
                if (!Directory.Exists(temppath))
                    Directory.CreateDirectory(temppath);
                File.Copy(dbfile, temppath + @"\mukavemet.db");
                string outfile = outpath + @"\Mukavemet Veritabanı " + 
                    DateTime.Now.ToString("yy-MM-dd HH-mm-ss") + ".zip";
                ZipFile.CreateFromDirectory(temppath, outfile);
                Directory.Delete(temppath, true);
            }
        }

        private void btImportDatabase_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show("Mevcut Verilerin Üzerine Yazılacak. " +
                    "Emin Misiniz?",
                    "Dikkat!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string infile = openFileDialog1.FileName;
                    try
                    {
                        if (File.Exists(dbfile))
                        {
                        connection.Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        File.Delete(dbfile);
                        }
                        ZipFile.ExtractToDirectory(infile, dbfile + @"\..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    openFileDialog1.Dispose();

                }
            }
        }

        private void btHamburgerMenu_Leave(object sender, EventArgs e)
        {
            if (!btImportDatabase.Focused && !btBackupDatabase.Focused)
            {
                tmrDelayHiding.Interval = 1;
                tmrDelayHiding.Enabled = true;
            }
            else
            {
                tmrDelayHiding.Interval = 1000;
                tmrDelayHiding.Enabled = true;
            }
        }

        private void TmrDelayHiding_Tick(object sender, EventArgs e)
        {
            tmrDelayHiding.Enabled = false;
            if (pnHamburger.Visible)
            {
                pnHamburger.Enabled = false;
                pnHamburger.Visible = false;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (pnHamburger.Visible)
            {
                pnHamburger.Enabled = false;
                pnHamburger.Visible = false;
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (pnHamburger.Visible)
            {
                pnHamburger.Enabled = false;
                pnHamburger.Visible = false;
            }
        }

        private void dgwKayit_Click(object sender, EventArgs e)
        {
            if (pnHamburger.Visible)
            {
                pnHamburger.Enabled = false;
                pnHamburger.Visible = false;
            }
        }

        private void chbProductFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chbProductFilter.Checked)
            {
                try
                {
                    string[] listBoxItemArray = new string[clbxProductFilter.Items.Count];
                    for (int i = 0; i < clbxProductFilter.Items.Count; i++)
                    {
                        listBoxItemArray[i] = (string)clbxProductFilter.Items[i];
                    }
                    if (Settings.Default.ProductList == null || Settings.Default.ProductList.Length == 0)
                    {
                        MessageBox.Show("Hiçbir ürün tanımlanmadı. Ürün tanımlamak veya ayarları yedekten içeri aktarmak için Ayarlar sekmesine gidin.");
                    }
                    else if (listBoxItemArray != Settings.Default.ProductList)
                    {
                        clbxProductFilter.Items.Clear();
                        clbxProductFilter.Items.AddRange(Settings.Default.ProductList);
                    }

                    clbxProductFilter.Enabled = true;
                    clbxProductFilter.Visible = true;
                    clbxProductFilter.Height = clbxProductFilter.GetItemHeight(0) * (clbxProductFilter.Items.Count + 1);
                    btProductFilter.Top = chbProductFilter.Top;
                    //btProductFilter.Height = chbProductFilter.Height;
                    btProductFilter.Enabled = true;
                    btProductFilter.Visible = true;
                    btProductFilter.Text = "✔";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                clbxProductFilter.Enabled = false;
                clbxProductFilter.Visible = false;
                btProductFilter.Enabled = false;
                btProductFilter.Visible = false;

            }
        }

        private void btProductFilter_Click(object sender, EventArgs e)
        {
            if (clbxProductFilter.Enabled)
            {
                if (clbxProductFilter.CheckedItems.Count == 0)
                    chbProductFilter.Checked = false;
                else
                {
                    try
                    {
                        clbxProductFilter.Enabled = false;
                        clbxProductFilter.Visible = false;
                        btProductFilter.Text = "🞃";

                        selectedProducts = new string[clbxProductFilter.CheckedItems.Count];
                        for (int i = 0; i < clbxProductFilter.CheckedItems.Count; i++)
                        {
                            selectedProducts[i] = (string)clbxProductFilter.CheckedItems[i];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                clbxProductFilter.Enabled = true;
                clbxProductFilter.Visible = true;
                btProductFilter.Text = "✔";
            }
        }

        private void chbUserFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chbUserFilter.Checked)
            {
                try
                {
                    string[] listBoxItemArray = new string[clbxUserFilter.Items.Count];
                    for (int i = 0; i < clbxUserFilter.Items.Count; i++)
                    {
                        listBoxItemArray[i] = (string)clbxUserFilter.Items[i];
                    }
                    if (Settings.Default.UserList == null || Settings.Default.UserList.Length == 0)
                    {
                        MessageBox.Show("Hiçbir kullanıcı tanımlanmadı. Kullanıcı tanımlamak veya ayarları yedekten içeri aktarmak için Ayarlar sekmesine gidin.");
                    }
                    if (listBoxItemArray != Settings.Default.UserList)
                    {
                        clbxUserFilter.Items.Clear();
                        clbxUserFilter.Items.AddRange(Settings.Default.UserList);
                    }
                    clbxUserFilter.Enabled = true;
                    clbxUserFilter.Visible = true;
                    clbxUserFilter.Height = clbxUserFilter.GetItemHeight(0) * (clbxUserFilter.Items.Count + 1);
                    btUserFilter.Top = chbUserFilter.Top;
                    //btUserFilter.Height = chbUserFilter.Height;
                    btUserFilter.Enabled = true;
                    btUserFilter.Visible = true;
                    btUserFilter.Text = "✔";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                clbxUserFilter.Enabled = false;
                clbxUserFilter.Visible = false;
                btUserFilter.Enabled = false;
                btUserFilter.Visible = false;

            }
        }

        private void btUserFilter_Click(object sender, EventArgs e)
        {
            if (clbxUserFilter.Enabled)
            {
                if (clbxUserFilter.CheckedItems.Count == 0)
                    chbUserFilter.Checked = false;
                else
                {
                    try
                    {
                        clbxUserFilter.Enabled = false;
                        clbxUserFilter.Visible = false;
                        btUserFilter.Text = "🞃";

                        selectedUsers = new string[clbxUserFilter.CheckedItems.Count];
                        for (int i = 0; i < clbxUserFilter.CheckedItems.Count; i++)
                        {
                            selectedUsers[i] = (string)clbxUserFilter.CheckedItems[i];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                 
            }
            else
            {
                clbxUserFilter.Enabled = true;
                clbxUserFilter.Visible = true;
                btUserFilter.Text = "✔";
            }
        }

        private void dgwKayit_Sorted(object sender, EventArgs e)
        {
            dgwKayit.AutoResizeRows();
            dgwKayit.AutoResizeColumns();
        }

        private void dgwKayit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != dgwKayit.Rows.GetLastRow(DataGridViewElementStates.Visible) 
                && e.RowIndex != -1)
                ShowGraph(dgwKayit.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    dgwKayit.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    dgwKayit.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    dgwKayit.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    dgwKayit.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    dgwKayit.Rows[e.RowIndex].Cells[5].Value.ToString());
        }

        private void btCloseChart_Click(object sender, EventArgs e)
        {
            cartesianChart1.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            crtVls.Clear();
            crtVls = null;
            cartesianChart1.Series.Clear();
            cartesianChart1.Series = null;
            pnChart.Controls.Remove(cartesianChart1);
            pnChart.Enabled = false;
            pnChart.Visible = false;

        }

    }
}
