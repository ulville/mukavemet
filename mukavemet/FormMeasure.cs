﻿//    This file is part of Mukavemet.

//    Mukavemet is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.

//    Mukavemet is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.

//    You should have received a copy of the GNU General Public License
//    along with Mukavemet.  If not, see <https://www.gnu.org/licenses/>.

//    Copyright, 2020, Ulvican Kahya


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
        private string productionDate;
        private string moldDate;
        private string dbfile = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\ABS Alçı ve Blok Sanayi\Mukavemet\mukavemet.db";
        private double testValue;
        private bool testValueChanged = false;


        //Colors
        private System.Drawing.Color defaultBlue = System.Drawing.Color.FromArgb(0, 86, 168);
        private System.Drawing.Color testModeColor = System.Drawing.Color.FromArgb(143, 24, 24);

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

            RoundButton panicButton = new RoundButton();
            panicButton.Left = chbTestMode.Left + chbTestMode.Width / 2 - chbTestMode.Height / 2;
            panicButton.Top = chbTestMode.Bottom + 4;
            panicButton.Width = chbTestMode.Height;
            panicButton.Height = panicButton.Width;
            panicButton.Name = "panicButton";
            panicButton.FlatStyle = FlatStyle.Flat;
            panicButton.FlatAppearance.BorderSize = 0;
            panicButton.BackColor = System.Drawing.Color.Red;
            panicButton.ForeColor = System.Drawing.Color.White;
            panicButton.Text = " !";
            panicButton.Font = new Font(panicButton.Font, FontStyle.Bold);
            panicButton.UseVisualStyleBackColor = false;
            pnConnection.Controls.Add(panicButton);
            panicButton.Click += new System.EventHandler(this.panicButton_Click);

        }

        private void panicButton_Click(object sender, EventArgs e)
        {
            btStopMeasure.PerformClick();
            if (plc != null)
            {
                if (PlcPinging(Settings.Default.IP))
                {
                    if (plc.IsConnected)
                    {
                        ZeroFillEverything();
                    }
                    else
                    {
                        btConnect.PerformClick();
                        ZeroFillEverything();
                    }
                }
                else
                {
                    MessageBox.Show(msgConTimeout);
                }
            }
            else
            {
                MessageBox.Show(msgNotConnected);
            }

            SystemSounds.Exclamation.Play();
        }

        private void ZeroFillEverything()
        {
            UnsetTestMode();
            plc.Write(Settings.Default.MeasureAddr.ToUpper(), false);
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

        private bool SelectBend()
        {
            if (plc == null)
            {
                MessageBox.Show(msgNotConnected);
                return false;
            }
            else
            {
                if (plc.IsConnected)
                {
                    if (PlcPinging(Settings.Default.IP))
                    {
                        if (IsAdressesDefined())
                        {
                            try
                            {
                                plc.Write(Settings.Default.SelectAddr.ToUpper(), true);
                                return true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show(msgAddressLineEmpty);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(msgConTimeout);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(msgNotConnected);
                    return false;
                }
            }
        }

        private bool SelectPressure()
        {
            if (plc == null)
            {
                MessageBox.Show(msgNotConnected);
                return false;
            }
            else
            {
                if (plc.IsConnected)
                {
                    if (PlcPinging(Settings.Default.IP))
                    {
                        if (IsAdressesDefined())
                        {
                            try
                            {
                                plc.Write(Settings.Default.SelectAddr.ToUpper(), false);
                                return true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show(msgAddressLineEmpty);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(msgConTimeout);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(msgNotConnected);
                    return false;
                }
            }
        }

        private void chbBend_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBend.Checked && SelectBend())
            {
                chbBend.BackColor = System.Drawing.Color.White;
                chbBend.ForeColor = System.Drawing.Color.FromArgb(237, 28, 36);
                chbPressure.CheckState = CheckState.Unchecked;
            }
            else
            {
                chbBend.BackColor = System.Drawing.Color.Transparent;
                chbBend.ForeColor = System.Drawing.Color.White;
                chbBend.CheckState = CheckState.Unchecked;
            }
        }

        private void chbPressure_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPressure.Checked && SelectPressure())
            {
                chbPressure.BackColor = System.Drawing.Color.White;
                chbPressure.ForeColor = System.Drawing.Color.FromArgb(237, 28, 36);
                chbBend.CheckState = CheckState.Unchecked;
            }
            else
            {
                chbPressure.BackColor = System.Drawing.Color.Transparent;
                chbPressure.ForeColor = System.Drawing.Color.White;
                chbPressure.CheckState = CheckState.Unchecked;
            }
        }

        private bool IsAdressesDefined()
        {
            return Settings.Default.BendActAddr.Length != 0
                && Settings.Default.BendMaxAddr.Length != 0
                && Settings.Default.PresActAddr.Length != 0
                && Settings.Default.PresMaxAddr.Length != 0
                && Settings.Default.SelectAddr.Length != 0
                && Settings.Default.MeasureAddr.Length != 0
                && Settings.Default.TestModeAddr.Length != 0
                && Settings.Default.TestValSetAddr.Length != 0;
        }

        private void IndicateConnected()
        {
            if (lbStatus.Text == msgDisconnected ||
                lbStatus.Text == msgConTimeout)
            {
                lbStatus.Text = msgConnected;
                lbStatus.ForeColor = System.Drawing.Color.Lime;
            }
        }

        private bool SetTestMode()
        {
            try
            {
                plc.Write(Settings.Default.TestValSetAddr.ToUpper(), ((float)testValue).ConvertToUInt());
                plc.Write(Settings.Default.TestModeAddr.ToUpper(), true);
                tbTestSetVal.ForeColor = default;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool UnsetTestMode()
        {
            try
            {
                plc.Write(Settings.Default.TestValSetAddr.ToUpper(), ((float)0).ConvertToUInt());
                plc.Write(Settings.Default.TestModeAddr.ToUpper(), false);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool TestModeOn()
        {
            if (plc == null)
            {
                MessageBox.Show(msgNotConnected);
                return false;
            }
            else
            {
                if (plc.IsConnected)
                {
                    if (PlcPinging(Settings.Default.IP))
                    {
                        if (IsAdressesDefined())
                        {
                            try
                            {
                                plc.Write(Settings.Default.TestModeAddr.ToUpper(), true);
                                return true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show(msgAddressLineEmpty);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(msgConTimeout);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(msgNotConnected);
                    return false;
                }
            }
        }

        private bool TestModeOff()
        {
            if (plc == null)
            {
                MessageBox.Show(msgNotConnected);
                return false;
            }
            else
            {
                if (plc.IsConnected)
                {
                    if (PlcPinging(Settings.Default.IP))
                    {
                        if (IsAdressesDefined())
                        {
                            try
                            {
                                plc.Write(Settings.Default.TestModeAddr.ToUpper(), false);
                                return true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show(msgAddressLineEmpty);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(msgConTimeout);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(msgNotConnected);
                    return false;
                }
            }
        }

        private void StartMeasurement(bool isBendMeasurement)
        {
            crtVls.Clear();
            cartesianChart1.Refresh();
            
            if (isBendMeasurement)
            {
                addressAct = Settings.Default.BendActAddr.ToUpper();
                addressMax = Settings.Default.BendMaxAddr.ToUpper();
            }
            else
            {
                addressAct = Settings.Default.PresActAddr.ToUpper();
                addressMax = Settings.Default.PresMaxAddr.ToUpper();
            }
            
            try
            {
                plc.Write(Settings.Default.SelectAddr.ToUpper(),
                    isBendMeasurement);
            
                plc.Close();
                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        if (IsAdressesDefined())
                        {
                            if (tbNmm2.Visible)
                            {
                                tbActMeasure.Top += 15;
                                lbNewtonUnit.Top += 15;
                            }

                            tbNmm2.Visible = false;
                            lbNmm2Unit.Visible = false;
                            tbActMeasure.ResetText();
                            IndicateConnected();

                            if (chbTestMode.Checked)
                            {
                                if (IsStringValidAndInRange())
                                {
                                    if (SetTestMode())
                                    {
                                        if (chbBend.Checked && !chbPressure.Checked)
                                        {
                                            selection = "Eğilme";
                                            StartMeasurement(true);

                                        }
                                        else if (!chbBend.Checked && chbPressure.Checked)
                                        {
                                            selection = "Basınç";
                                            StartMeasurement(false);
                                        }
                                        else
                                        {
                                            MessageBox.Show(msgNotSelected);
                                        }
                                    }

                                }
                                else
                                    MessageBox.Show("Düzgün bir değer girin", "Lütfen :')");
                            }
                            else
                            {
                                if (UnsetTestMode())
                                {
                                    if (chbBend.Checked && !chbPressure.Checked)
                                    {
                                        selection = "Eğilme";
                                        StartMeasurement(true);

                                    }
                                    else if (!chbBend.Checked && chbPressure.Checked)
                                    {
                                        selection = "Basınç";
                                        StartMeasurement(false);
                                    }
                                    else
                                    {
                                        MessageBox.Show(msgNotSelected);
                                    }
                                }
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

        /////////////////////////////////////////////////////////////////////////////

        //private float CalculateLastSlope()
        //{
        //    return (crtVls[crtVls.Count - 1].Value - crtVls[crtVls.Count - 2].Value)
        //        / (crtVls[crtVls.Count - 1].Time.Ticks
        //        - crtVls[crtVls.Count - 2].Time.Ticks);
        //}

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
                    "\"Ölçüm Sonucu\",\"Ölçümü Yapan\",\"Ürün Cinsi\",\"Üretim Tarihi\",\"Kalıp Tarihi\",\"N/mm2\")" +
                    "VALUES(\'" + timeOfMeasurement + "\',\'" + selection + 
                    "\'," + maxMeasure + ",\'" + cbUser.Text + "\',\'" + 
                    cbProduct.SelectedItem.ToString() + "\',\'" + productionDate + "\',\'" + moldDate + "\',\'" +
                    float.Parse(tbNmm2.Text).ToString(CultureInfo.InvariantCulture) + "\')";
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

                        if (testValueChanged)
                        {
                            plc1.Write(Settings.Default.TestValSetAddr.ToUpper(), ((float)testValue).ConvertToUInt());
                            testValueChanged = false;
                            float debuggi = ((uint)plc1.Read(Settings.Default.TestValSetAddr.ToUpper())).ConvertToFloat();
                            Debug.WriteLine("written: " + testValue.ToString());
                            Debug.WriteLine("read   : " + debuggi.ToString());
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

                        if (chbTestMode.Checked && (bool)plc1.Read(Settings.Default.TestModeAddr))
                            System.Threading.Thread.Sleep(100);
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
                if (selection == "Basınç")
                    tbNmm2.Text = (result * Settings.Default.PresCoef).ToString();
                else if (selection == "Eğilme")
                    tbNmm2.Text = (result * Settings.Default.BendCoef).ToString();
                else
                    tbNmm2.Text = "Nabıyon sen NaBıyoN?";

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
                productionDate = dtpProductionDate.Value.Date.ToString
                    ("yyyy-MM-dd");
                moldDate = dtpMoldDate.Value.Date.ToString
                    ("yyyy-MM-dd");

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

        private void FormMeasure_Shown(object sender, EventArgs e)
        {
            ConnectToPlc();
        }

        private void chbTestMode_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chb = sender as CheckBox;
            bool varChecked = chb.Checked;
            panel12.Visible = !varChecked;
            panel12.Enabled = !varChecked;


            panel10.Visible = varChecked;
            panel10.Enabled = varChecked;
            tbTestSetVal.Enabled = varChecked;
            tbTestSetVal.Visible = varChecked;
            label15.Visible = varChecked;

            if (varChecked && TestModeOn())
            {
                chb.BackColor = testModeColor;
                chb.ForeColor = defaultBlue;
                foreach (Control control in this.Controls)
                {
                    if (control.BackColor == defaultBlue)
                    {
                        control.BackColor = testModeColor;
                    }
                }
                tbActMeasure.BackColor = testModeColor;
            }
            else if (!varChecked && TestModeOff())
            {
                chb.BackColor = default(System.Drawing.Color);
                chb.ForeColor = default(System.Drawing.Color);
                foreach (Control control in this.Controls)
                {
                    if (control.BackColor == testModeColor)
                    {
                        control.BackColor = default(System.Drawing.Color);
                    }
                }
                tbActMeasure.BackColor = defaultBlue;
            }
        }

        /*
        private void UpdateTextBox(object sender, bool updatetext)
        {
            TrackBar trb = (TrackBar)sender;
            double height = Convert.ToDouble(trb.Height);
            double value = Convert.ToDouble(trb.Value);
            double max = Convert.ToDouble(trb.Maximum);
            double top = Convert.ToDouble(trb.Top);
            tbTestSetVal.Top = Convert.ToInt32(100.0 / max * (-(height + 39.0 - top) / 100 * value) + height + 39.0);
            if (updatetext)
            {
                tbTestSetVal.Text = (Convert.ToDouble(trb.Value)/10.0).ToString();
            }
        }
        */
        private bool IsStringValidAndInRange()
        {
            return double.TryParse(tbTestSetVal.Text, out testValue) && testValue * 10 <= (double)trackBar1.Maximum && testValue * 10 >= (double)trackBar1.Minimum;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //UpdateTextBox(sender, true);

            TrackBar trb = (TrackBar)sender;
            tbTestSetVal.Text = (Convert.ToDouble(trb.Value) / 10.0).ToString();
            tbTestSetVal.ForeColor = default;
            IsStringValidAndInRange();
            testValueChanged = true;
        }

        private void tbTestSetVal_Enter(object sender, EventArgs e)
        {
            tbTestSetVal.ForeColor = System.Drawing.Color.Gray;
        }

        private void tbTestSetVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (IsStringValidAndInRange())
                {
                    trackBar1.Value = Convert.ToInt32(testValue * 10);
                    tbTestSetVal.ForeColor = default;
                    testValueChanged = true;
                }
                else
                {
                    tbTestSetVal.ForeColor = System.Drawing.Color.Red;
                }
            }
            
        }

    }
}
