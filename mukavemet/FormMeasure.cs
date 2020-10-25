using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mukavemet.Properties;
using S7.Net;
using System.Data.SQLite;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using LiveCharts.Configurations;

namespace mukavemet
{
    public partial class FormMeasure : Form
    {
        private bool connected = false;
        private Plc plc { get; set; } = null;
        int i = 0;
        private string addressAct;
        private string addressMax;
        private string selection;
        private string maxMeasure;
        private bool measuring = false;
        private SQLiteConnection connection;
        string timeOfMeasurement;
        DateTime startTime;
        int chartWrite;
        private float result;
        private float[] valBuffer;
        private TimeSpan[] timeBuffer;




        //Hata Mesajları ve Bildirimler:
        private string msgConnected = "Bağlandı";
        private string msgDisconnected = "Bağlantı Kesildi";
        private string msgConTimeout = "Bağlantı Zaman Aşımı";
        private string msgNotConnected = "PLC Bağlı Değil!";
        private string msgNotSelected = "Ölçüm Türü Seçili Değil!";
        private string msgAddressLineEmpty = "Adresler Tanımlı Değil!";

        public ChartValues<MeasureModel> crtVls { get; set; }


        public FormMeasure()
        {
            InitializeComponent();
            ConnectToPlc();
            connection = new SQLiteConnection(@"data source=./mukavemet.db");
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
                    PointGeometrySize = 7,
                    StrokeThickness = 2
                }
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new TimeSpan((long)value)
                .TotalMilliseconds.ToString() + "ms",
                Separator = new Separator
                {
                    Step = TimeSpan.FromMilliseconds(1000).Ticks
                }
            });
            cartesianChart1.AxisX[0].MaxValue = TimeSpan.FromMilliseconds(100).Ticks;
            cartesianChart1.AxisX[0].MinValue = TimeSpan.FromMilliseconds(0).Ticks;
            cartesianChart1.AnimationsSpeed = TimeSpan.FromMilliseconds(30);
            ////////////////////////////////////////////////////////////////////
            ///
            valBuffer = new float[0];
            timeBuffer = new TimeSpan[0];
        }

        private void DrawFinalChart(TimeSpan[] t, float[] value)
        {
            for (int i = 0; i < 500; i++)
            {
                crtVls.Add(new MeasureModel
                {
                    Time = t[i],
                    Value = value[i]
                });
            }

            cartesianChart1.AxisX[0].MaxValue = crtVls[crtVls.Count - 1].Time.Ticks
                + TimeSpan.FromMilliseconds(100).Ticks;
            cartesianChart1.AxisX[0].MinValue = 0;  /// KALDIR
            cartesianChart1.AxisY[0].MinValue = 0;  /// KALDIR
        }

        private void DrawChart(TimeSpan t, float value)
        {
                crtVls.Add(new MeasureModel
                {
                    Time = t,
                    Value = value
                });

            cartesianChart1.AxisX[0].MaxValue = crtVls[crtVls.Count - 1].Time.Ticks
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
                chbBend.BackColor = Color.White;
                chbBend.ForeColor = Color.FromArgb(237, 28, 36);
                chbPressure.CheckState = CheckState.Unchecked;
            }
            else
            {
                chbBend.BackColor = Color.Transparent;
                chbBend.ForeColor = Color.White;
            }
        }

        private void chbPressure_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPressure.Checked)
            {
                chbPressure.BackColor = Color.White;
                chbPressure.ForeColor = Color.FromArgb(237, 28, 36);
                chbBend.CheckState = CheckState.Unchecked;
            }
            else
            {
                chbPressure.BackColor = Color.Transparent;
                chbPressure.ForeColor = Color.White;
            }
        }

        private void btMeasure_Click(object sender, EventArgs e)
        {
            //if (plc == null)
            //{
            //    MessageBox.Show(msgNotConnected);
            //}
            //else
            //{
            //    if (plc.IsConnected)
            //    {
            //        if (Settings.Default.BendActAddr.Length != 0 
            //            && Settings.Default.BendMaxAddr.Length != 0
            //            && Settings.Default.PresActAddr.Length != 0 
            //            && Settings.Default.PresMaxAddr.Length != 0
            //            && Settings.Default.SelectAddr.Length != 0 
            //            && Settings.Default.MeasureAddr.Length != 0)
            //        {
            //            tbActMeasure.ResetText();
            //            if (chbBend.Checked && !chbPressure.Checked)
            //            {
            //                crtVls.Clear();
            //                cartesianChart1.Refresh();
            //                addressAct = Settings.Default.BendActAddr.ToUpper();
            //                addressMax = Settings.Default.BendMaxAddr.ToUpper();
            //                plc.Write(Settings.Default.SelectAddr.ToUpper(), true);
            //                plc.Write(Settings.Default.MeasureAddr.ToUpper(), true);
                            startTime = DateTime.Now;
            result = 0f;

            //                chartWrite = 0;
            //                selection = "Eğilme";
            tmReadUpdate.Enabled = true;
            //            }
            //            else if (!chbBend.Checked && chbPressure.Checked)
            //            {
            //                crtVls.Clear();
            //                cartesianChart1.Refresh();
            //                addressAct = Settings.Default.PresActAddr.ToUpper();
            //                addressMax = Settings.Default.PresMaxAddr.ToUpper();
            //                plc.Write(Settings.Default.SelectAddr.ToUpper(), false);
            //                plc.Write(Settings.Default.MeasureAddr.ToUpper(), true);
            //                startTime = DateTime.Now;
            //                chartWrite = 0;
            //                selection = "Basınç";
            //                tmReadUpdate.Enabled = true;
            //            }
            //            else
            //            {
            //                MessageBox.Show(msgNotSelected);
            //            }

            //        }
            //        else
            //        {
            //            MessageBox.Show(msgAddressLineEmpty);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show(msgNotConnected);
            //    }
            //}
        }

        private void ConnectToPlc()
        {
            if (!connected)
            {
                CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), 
                    Settings.Default.CpuType);
                string ip = Settings.Default.IP;
                short rack = Convert.ToInt16(Settings.Default.Rack);
                short slot = Convert.ToInt16(Settings.Default.Slot);
                plc = new Plc(cpu, ip, rack, slot);
                plc.OpenAsync();
                i = 0;
                tmConTimeout.Enabled = true;
            }

        }

        private void tmConTimeout_Tick(object sender, EventArgs e)
        {
            if (plc.IsConnected)
            {
                connected = true;
                lbStatus.Text = msgConnected;
                lbStatus.ForeColor = Color.Lime;
                plc.ReadTimeout = 0;
                tmConTimeout.Enabled = false;
            }
            else if (i > 10)
            {
                i = -1;
                tmConTimeout.Enabled = false;
                lbStatus.Text = msgConTimeout;
                lbStatus.ForeColor = Color.Red;
            }

            i++;
        }

        private void tmReadUpdate_Tick(object sender, EventArgs e)
        {
            //if (plc.IsConnected)
            //{
            //    try
            //    {
            //        measuring = (bool)plc.Read(Settings.Default.MeasureAddr);
            //        if (measuring)
            //        {
            //            uint uintRes = (uint)plc.Read(addressAct);
            //            float result = uintRes.ConvertToFloat();
            //            tbActMeasure.Text = result.ToString();
            //            if (chartWrite % 10 == 0)
            Array.Resize(ref valBuffer, valBuffer.Length + 1);
            valBuffer[(int)result] = result;
            Array.Resize(ref timeBuffer, timeBuffer.Length + 1);
            timeBuffer[(int)result] = DateTime.Now.Subtract(startTime);
            if ((int)result % 5 == 0)
            {
                DrawChart(timeBuffer[(int)result], valBuffer[(int)result]);
            }

            if ((int)result % 500 == 499)
            {
                crtVls.Clear();
                cartesianChart1.Refresh();
                DrawFinalChart(timeBuffer, valBuffer);
                tmReadUpdate.Enabled = false;
            }

            //                DrawChart(DateTime.Now.Subtract(startTime), result);
            //        }
            //        else
            //        {
            //            uint uintRes = (uint)plc.Read(addressMax);
            //            float result = uintRes.ConvertToFloat();
            //            maxMeasure = result.ToString(CultureInfo.InvariantCulture);
            //            tmReadUpdate.Enabled = false;
            //            tbActMeasure.ResetText();
            //            tbActMeasure.Text = result.ToString();
            //            float slope = CalculateLastSlope();
            //            TimeSpan lastTime = new TimeSpan(
            //                Convert.ToInt64((result - crtVls[crtVls.Count - 1].Value)
            //                / slope) + crtVls[crtVls.Count - 1].Time.Ticks
            //                );
            //            DrawChart(lastTime, result);
            //            timeOfMeasurement = DateTime.Now.ToString
            //                ("yyyy-MM-dd HH:mm:ss");
            //            SaveToDatabase();
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        tmReadUpdate.Enabled = false;
            //        MessageBox.Show(ex.Message);
            //        tbActMeasure.ResetText();
            //        btStopMeasure.PerformClick();
            //    }
            //}
            //else
            //{
            //    btStopMeasure.PerformClick();
            //    connected = false;
            //    lbStatus.Text = msgDisconnected;
            //    lbStatus.ForeColor = Color.Red;
            //}
            //chartWrite++;
            result++;
        }

        private float CalculateLastSlope()
        {
            return (crtVls[crtVls.Count - 1].Value - crtVls[crtVls.Count - 2].Value)
                / (crtVls[crtVls.Count - 1].Time.Ticks
                - crtVls[crtVls.Count - 2].Time.Ticks);
        }

        private void btStopMeasure_Click(object sender, EventArgs e)
        {
            if (measuring)
            {
                plc.Write(Settings.Default.MeasureAddr.ToUpper(), false);
                tmReadUpdate.Enabled = false;
                measuring = false;
                tbActMeasure.ResetText();
            }
            tmReadUpdate.Enabled = false;

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
            if (plc != null && plc.IsConnected)
            {
                btStopMeasure.PerformClick();
                plc.Close();

                if (!(plc.IsConnected))
                {
                    connected = false;
                    lbStatus.Text = msgDisconnected;
                    lbStatus.ForeColor = Color.Red;
                }
            }
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
            btDisconnect.PerformClick();
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

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }
    }
}
