using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Configurations;
using System.Windows.Media;
using System.Data.SQLite;

namespace mukavemet
{
    public partial class FormGraph : Form
    {
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private ChartValues<MeasureModel> crtVls { get; set; }


        public FormGraph(string noOfClicked)
        {
            InitializeComponent();

            lbTitle.Text = "Ölçüm No: " + noOfClicked;
            int LocX = this.Width / 50;
            int LocY = this.Height / 8;

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
                Size = new Size(this.Width - (LocX * 2), this.Height - LocY * 2),
                TabIndex = 57,
                Text = "cartesianChart1",
                BackColor = System.Drawing.Color.FromArgb(0, 86, 168),
                AnimationsSpeed = TimeSpan.FromMilliseconds(250),
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

            this.Controls.Add(cartesianChart1);
            cartesianChart1.BringToFront();
            this.Show();

            #region SQLite Reading

            using (SQLiteConnection connection = new SQLiteConnection(@"data source=./mukavemet.db"))
            {
                try
                {
                    var models = new MeasureModel[0];

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

        }

        private void btCloseChart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGraph_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (IDisposable disposable in Controls)
            {
                disposable.Dispose();
            }
            crtVls.Clear();
            crtVls = null;
        }
    }
}
