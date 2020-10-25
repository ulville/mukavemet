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


namespace mukavemet
{
    public partial class FormData : Form
    {
        private SQLiteConnection connection;
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private Panel pnHamburger = new Panel();
        private Timer tmrDelayHiding = new Timer { Interval = 10 };


        public FormData()
        {
            InitializeComponent();
            connection = new SQLiteConnection(@"data source=./mukavemet.db");
            typeof(DataGridView).InvokeMember("DoubleBuffered", 
                BindingFlags.NonPublic | BindingFlags.Instance | 
                BindingFlags.SetProperty, null, dgwKayit,
                new object[] { true });

            pnHamburger.Top = btHamburgerMenu.Bottom + 10;
            pnHamburger.Left = btHamburgerMenu.Left;
            pnHamburger.BackColor = Color.Black;
            pnHamburger.Size = new Size(240, 104);
            pnHamburger.BorderStyle = BorderStyle.FixedSingle;
            pnHamburger.Controls.Add(btImportDatabase);
            btImportDatabase.Dock = DockStyle.Top;
            pnHamburger.Controls.Add(btBackupDatabase);
            btBackupDatabase.Dock = DockStyle.Bottom;
            btBackupDatabase.Height = pnHamburger.Height / 2 - 1;
            btImportDatabase.Height = pnHamburger.Height / 2 - 1;
            tmrDelayHiding.Tick += TmrDelayHiding_Tick;
        }

        private void btDataBase_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                connection.Open();
                if (!chbPickDate.Checked)
                {
                    query = "SELECT * FROM mukayit";

                }
                else
                {
                    DateTime dtFromDate = dtpFrom.Value.Date;
                    DateTime dtToDate = dtpTo.Value.Date.AddDays(1) - 
                        TimeSpan.FromSeconds(1);
                    string fromDate = dtFromDate.ToString("yyyy-MM-dd HH:mm:ss");
                    string toDate = dtToDate.ToString("yyyy-MM-dd HH:mm:ss");

                    query = "SELECT * FROM mukayit WHERE Tarih BETWEEN \'" + 
                        fromDate + "\' AND \'" + toDate + "\'";
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
                dgwKayit.BackgroundColor = Color.White;
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
            string time = DateTime.Now.ToString().Replace('.', '_').Replace(':', '-');
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

            string[] noValues = GetNoValues(dgwKayit.SelectedCells);
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
                    connection.Open();
                    StringBuilder query = new StringBuilder(
                        "DELETE FROM mukayit WHERE No in (");

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
                    btDataBase.PerformClick();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
            
        }

        private string[] GetNoValues(DataGridViewSelectedCellCollection cells)
        {
            string[] noValues = new string[0];
            int[] inx = new int[0];
            foreach (DataGridViewCell cell in cells)
            {
                if (!inx.Contains(cell.RowIndex))
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
                File.Copy(@".\mukavemet.db", temppath + @"\mukavemet.db");
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
                    if (File.Exists(@"./mukavemet.db"))
                    {
                        File.Delete(@"./mukavemet.db");
                    }
                    ZipFile.ExtractToDirectory(infile, ".");

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
    }
}
