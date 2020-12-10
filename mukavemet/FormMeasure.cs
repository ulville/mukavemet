using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using mukavemet.Properties;
using S7.Net;
using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Windows.Media;

namespace mukavemet
{
    public partial class FormMeasure : Form
    {
        private Plc plc = null;
        private string addressAct;
        private string addressMax;
        private string selection;
        private string maxMeasure;
        private bool measuring = false;
        private SQLiteConnection connection;
        private string timeOfMeasurement;
        private string dbfile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ABS Alçı ve Blok Sanayi\Mukavemet\mukavemet.db";

        //Hata Mesajları ve Bildirimler:
        private string msgConnected = "Bağlandı";
        private string msgDisconnected = "Bağlantı Kesildi";
        private string msgConTimeout = "Bağlantı Zaman Aşımı";
        private string msgNotConnected = "PLC Bağlı Değil!";
        private string msgNotSelected = "Ölçüm Türü Seçili Değil!";
        private string msgAddressLineEmpty = "Adresler Tanımlı Değil!";

        private ChartValues<MeasureModel> crtVls { get; set; }


        public FormMeasure()
        {
            InitializeComponent();
            CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType),
                Settings.Default.CpuType);
            string ip = Settings.Default.IP;
            short rack = Convert.ToInt16(Settings.Default.Rack);
            short slot = Convert.ToInt16(Settings.Default.Slot);
            plc = new Plc(cpu, ip, rack, slot);
            ConnectToPlc();
            connection = new SQLiteConnection("data source=" + dbfile);
            //connection = new SQLiteConnection(@"data source=./mukavemet.db");
            cbProduct.DataSource = Settings.Default.ProductList;
            cbUser.DataSource = Settings.Default.UserList;
            FlipButtonIcon(button1);
            /////////////////////////////////////////////////////////////////////////

            var mapper = Mappers.Xy<MeasureModel>()
                .X(model => model.Time.Ticks)
                .Y(model => model.Value);

            Charting.For<MeasureModel>(mapper);
            crtVls = new ChartValues<MeasureModel>();
            cartesianChart1.Series = new SeriesCollection
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
                },

            };
            cartesianChart1.AxisX.Add(new Axis
            {
//                DisableAnimations = true,
                LabelFormatter = value => new TimeSpan((long)value)
                .TotalMilliseconds.ToString() + "ms",
                Separator = new Separator
                {
                    Step = TimeSpan.FromMilliseconds(500).Ticks
                }
            });
            cartesianChart1.AxisX[0].MaxValue = TimeSpan.FromMilliseconds(100).Ticks;
            cartesianChart1.AxisX[0].MinValue = TimeSpan.FromMilliseconds(0).Ticks;
            cartesianChart1.AnimationsSpeed = TimeSpan.FromMilliseconds(20);
            ////////////////////////////////////////////////////////////////////
        }

        private void DrawChart(TimeSpan t, float value)
        {

            crtVls.Add(new MeasureModel
            {
                Time = t,
                Value = value
            });

            cartesianChart1.AxisX[0].MaxValue = t.Ticks 
                + TimeSpan.FromMilliseconds(100).Ticks;
            cartesianChart1.AxisX[0].MinValue = 0;  /// KALDIR
            cartesianChart1.AxisY[0].MinValue = 0;  /// KALDIR
        }

        private void FormMeasure_Load(object sender, EventArgs e)
        {
            RefreshConnectionValues();
        }

        private void RefreshConnectionValues()
        {
            label5.Text = Settings.Default.CpuType;
            label6.Text = Settings.Default.IP;
            label7.Text = Settings.Default.Rack;
            label8.Text = Settings.Default.Slot;
        }

        private void chbBend_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBend.Checked)
            {
                chbBend.BackColor = System.Drawing.Color.White;
                chbBend.ForeColor = System.Drawing.Color.FromArgb(237, 28, 36);
                chbPressure.CheckState = CheckState.Unchecked;
            }
            else
            {
                chbBend.BackColor = System.Drawing.Color.Transparent;
                chbBend.ForeColor = System.Drawing.Color.White;
            }
        }

        private void chbPressure_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPressure.Checked)
            {
                chbPressure.BackColor = System.Drawing.Color.White;
                chbPressure.ForeColor = System.Drawing.Color.FromArgb(237, 28, 36);
                chbBend.CheckState = CheckState.Unchecked;
            }
            else
            {
                chbPressure.BackColor = System.Drawing.Color.Transparent;
                chbPressure.ForeColor = System.Drawing.Color.White;
            }
        }

        private void btMeasure_Click(object sender, EventArgs e)
        {
            if (plc == null)
            {
                MessageBox.Show(msgNotConnected);
            }
            else
            {
                if (plc.IsConnected)
                {
                    if (PlcPinging(Settings.Default.IP))
                    {
                        if (Settings.Default.BendActAddr.Length != 0
                            && Settings.Default.BendMaxAddr.Length != 0
                            && Settings.Default.PresActAddr.Length != 0
                            && Settings.Default.PresMaxAddr.Length != 0
                            && Settings.Default.SelectAddr.Length != 0
                            && Settings.Default.MeasureAddr.Length != 0)
                        {
                            if (tbNmm2.Visible)
                            {
                                tbActMeasure.Top += 15;
                                lbNewtonUnit.Top += 15;
                            }
                            tbNmm2.Visible = false;
                            lbNmm2Unit.Visible = false;


                            tbActMeasure.ResetText();

                            if (lbStatus.Text == msgDisconnected ||
                                lbStatus.Text == msgConTimeout)
                            {
                                lbStatus.Text = msgConnected;
                                lbStatus.ForeColor = System.Drawing.Color.Lime;
                            }

                            if (chbBend.Checked && !chbPressure.Checked)
                            {
                                crtVls.Clear();
                                cartesianChart1.Refresh();

                                addressAct = Settings.Default.BendActAddr.ToUpper();
                                addressMax = Settings.Default.BendMaxAddr.ToUpper();

                                try
                                {
                                    plc.Write(Settings.Default.SelectAddr.ToUpper(),
                                        true);

                                    selection = "Eğilme";

                                    plc.Close();
                                    backgroundWorker1.RunWorkerAsync();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                            }
                            else if (!chbBend.Checked && chbPressure.Checked)
                            {
                                crtVls.Clear();
                                cartesianChart1.Refresh();

                                addressAct = Settings.Default.PresActAddr.ToUpper();
                                addressMax = Settings.Default.PresMaxAddr.ToUpper();

                                try
                                {
                                    plc.Write(Settings.Default.SelectAddr.ToUpper(),
                                        false);

                                    selection = "Basınç";

                                    plc.Close();
                                    backgroundWorker1.RunWorkerAsync();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show(msgNotSelected);
                            }
                        }
                        else
                        {
                            MessageBox.Show(msgAddressLineEmpty);
                        }
                    }
                    else
                    {
                        lbStatus.Text = msgConTimeout;
                        lbStatus.ForeColor = System.Drawing.Color.Red;
                        MessageBox.Show(msgNotConnected);
                    }

                }
                else
                {
                    MessageBox.Show(msgNotConnected);
                }
            }
        }

        private void ConnectToPlc()
        {
            if (PlcPinging(Settings.Default.IP))
            {
                try
                {
                    plc.Open();
                    if (plc.IsConnected)
                    {
                        lbStatus.Text = msgConnected;
                        lbStatus.ForeColor = System.Drawing.Color.Lime;
                        plc.ReadTimeout = 0;
                        plc.WriteTimeout = 0;
                    }
                    else
                    {
                        lbStatus.ForeColor = System.Drawing.Color.Red;
                        lbStatus.Text = msgConTimeout;
                        MessageBox.Show(msgNotConnected);
                    }
                }
                catch (Exception ex)
                {
                    lbStatus.ForeColor = System.Drawing.Color.Red;
                    lbStatus.Text = msgConTimeout;
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                lbStatus.ForeColor = System.Drawing.Color.Red;
                lbStatus.Text = msgConTimeout;
                MessageBox.Show(msgNotConnected);
            }
        }

        private void DisconnectFromPlc()
        {
            if (plc != null && plc.IsConnected)
            {
                btStopMeasure.PerformClick();
                plc.Close();

                if (!plc.IsConnected)
                {
                    lbStatus.Text = msgDisconnected;
                    lbStatus.ForeColor = System.Drawing.Color.Red;
                }
            }
        }


        private float CalculateLastSlope()
        {
            return (crtVls[crtVls.Count - 1].Value - crtVls[crtVls.Count - 2].Value)
                / (crtVls[crtVls.Count - 1].Time.Ticks
                - crtVls[crtVls.Count - 2].Time.Ticks);
        }

        private void btStopMeasure_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void SaveToDatabase()
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO mukayit(Tarih,\"Ölçüm Türü\"," +
                    "\"Ölçüm Sonucu\",\"Ölçümü Yapan\",\"Ürün Cinsi\")" +
                    "VALUES(\'" + timeOfMeasurement + "\',\'" + selection + 
                    "\'," + maxMeasure + ",\'" + cbUser.Text + "\',\'" + 
                    cbProduct.SelectedItem.ToString() + "\')";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();

                query = "INSERT INTO graf (\"No\",\"Değer\",\"Süre\") VALUES";
                string selectNo = "(SELECT \"No\" FROM mukayit ORDER BY \"No\"" +
                    " DESC LIMIT 1)";
                
                foreach (MeasureModel sample in crtVls)
                {
                    query += '(' + selectNo + ',' +
                        sample.Value.ToString(CultureInfo.InvariantCulture) +
                        ',' + sample.Time.Ticks.ToString() + ')';
                    if (!sample.Equals(crtVls[crtVls.Count - 1]))
                    {
                        query += ',';
                    }
                }
                command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            ConnectToPlc();
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            DisconnectFromPlc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!pnConnection.Visible)
                pnConnection.Visible = true;
            else
                pnConnection.Visible = false;
            FlipButtonIcon((Button)sender);
        }

        private void FlipButtonIcon(Button button)
        {
            Image image = button.Image;
            image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            button.Image = image;
        }

        private void FormMeasure_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectFromPlc();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Text = "Bağlantı Paneli";

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            string addressActMes = addressAct;
            string addressMaxMes = addressMax;
            CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType),
                Settings.Default.CpuType);
            string ip = Settings.Default.IP;
            short rack = Convert.ToInt16(Settings.Default.Rack);
            short slot = Convert.ToInt16(Settings.Default.Slot);
            Plc plc1 = new Plc(cpu, ip, rack, slot)
            {
                ReadTimeout = 0
            };
            plc1.Open();

            if (plc1.IsConnected)
            {
                try
                {
                    Stopwatch st = new Stopwatch();
                    st.Start();
                    plc1.Write(Settings.Default.MeasureAddr.ToUpper(), true);
                    measuring = (bool)plc1.Read(Settings.Default.MeasureAddr);
                    while (measuring)
                    {
                        if (worker.CancellationPending)
                        {
                            plc1.Write(Settings.Default.MeasureAddr.ToUpper(), false);
                            st.Reset();
                            plc1.Close();
                            e.Cancel = true;
                            break;
                        }

                        long time1 = st.ElapsedTicks;
                        uint uintres = (uint)plc1.Read(addressActMes);
                        long time2 = st.ElapsedTicks;
                        TimeSpan time = TimeSpan.FromTicks((time1 + time2) / 2);
                        //int res = uintres.ConvertToInt();
                        float res = uintres.ConvertToFloat();
                        MeasureModel resAndTime = new MeasureModel()
                        {
                            Value = res,
                            Time = time
                        };

                        measuring = (bool)plc1.Read(Settings.Default.MeasureAddr);
                        if (measuring)
                            worker.ReportProgress(0, resAndTime);
                    }

                    if (!worker.CancellationPending)
                    {
                        TimeSpan time3 = TimeSpan.FromTicks(st.ElapsedTicks);
                        uint uintRes = (uint)plc1.Read(addressMaxMes);
                        float result = uintRes.ConvertToFloat();
                        e.Result = new MeasureModel()
                        {
                            Value = result,
                            Time = time3
                        };

                        st.Reset();

                        plc1.Close();
                    }
                }
                catch (Exception ex)
                {
                    plc1.Close();
                    MessageBox.Show(ex.Message);
                    e.Cancel = true;
                }
            }
            else
            {
                plc1.Close();
                MessageBox.Show(msgNotConnected);
                e.Cancel = true;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                float result = ((MeasureModel)e.Result).Value;
                maxMeasure = result.ToString(CultureInfo.InvariantCulture);
                tbActMeasure.ResetText();
                tbActMeasure.Text = result.ToString();
                tbNmm2.Text = (result / 1600).ToString();
                tbNmm2.Visible = true; lbNmm2Unit.Visible = true;
                tbActMeasure.Top -= 15; lbNewtonUnit.Top -= 15;
                //float slope = CalculateLastSlope();
                //TimeSpan lastTime = new TimeSpan(
                //    Convert.ToInt64((result - crtVls[crtVls.Count - 1].Value)
                //    / slope) + crtVls[crtVls.Count - 1].Time.Ticks
                //    );
                //TimeSpan lastTime = new TimeSpan();
                //lastTime = crtVls.Last().Time + TimeSpan.FromMilliseconds(22);
                TimeSpan lastTime = ((MeasureModel)e.Result).Time;
                DrawChart(lastTime, result);

                timeOfMeasurement = DateTime.Now.ToString
                    ("yyyy-MM-dd HH:mm:ss");
                SaveToDatabase();
                plc.Open();
                SystemSounds.Exclamation.Play();
            }
            else
            {
                tbActMeasure.ResetText();
                plc.Open();

            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //float actVal = Convert.ToUInt32(e.ProgressPercentage);
            float actVal = ((MeasureModel)e.UserState).Value;
            TimeSpan time = ((MeasureModel)e.UserState).Time;
            tbActMeasure.Text = actVal.ToString();
            //            if (chartWrite % 10 == 0)
            DrawChart(time, actVal);

        }

        private bool PlcPinging(string ipAdr)
        {
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(ipAdr, 200);
                if (reply != null)
                {
                    if (reply.Status == IPStatus.Success)
                        return true;

                    else
                        return false;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        private void FormMeasure_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisconnectFromPlc();
        }
    }
}
