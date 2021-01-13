namespace mukavemet
{
    partial class FormMeasure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeasure));
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btStopMeasure = new System.Windows.Forms.Button();
            this.tbActMeasure = new System.Windows.Forms.TextBox();
            this.chbPressure = new System.Windows.Forms.CheckBox();
            this.chbBend = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btMeasure = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnConnection = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNmm2Unit = new System.Windows.Forms.Label();
            this.tbNmm2 = new System.Windows.Forms.TextBox();
            this.lbNewtonUnit = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpProductionDate = new System.Windows.Forms.DateTimePicker();
            this.dtpMoldDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.pnConnection.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(42, 184);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 29);
            this.label14.TabIndex = 51;
            this.label14.Text = "Ürün Çeşidi:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(42, 441);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 20);
            this.label13.TabIndex = 49;
            this.label13.Text = "Ölçümü Yapan Kişi:";
            // 
            // btStopMeasure
            // 
            this.btStopMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btStopMeasure.BackColor = System.Drawing.Color.White;
            this.btStopMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStopMeasure.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btStopMeasure.Location = new System.Drawing.Point(1054, 448);
            this.btStopMeasure.Margin = new System.Windows.Forms.Padding(2);
            this.btStopMeasure.Name = "btStopMeasure";
            this.btStopMeasure.Size = new System.Drawing.Size(148, 52);
            this.btStopMeasure.TabIndex = 47;
            this.btStopMeasure.Text = "Durdur";
            this.btStopMeasure.UseVisualStyleBackColor = false;
            this.btStopMeasure.Click += new System.EventHandler(this.btStopMeasure_Click);
            // 
            // tbActMeasure
            // 
            this.tbActMeasure.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbActMeasure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(168)))));
            this.tbActMeasure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbActMeasure.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbActMeasure.ForeColor = System.Drawing.Color.White;
            this.tbActMeasure.Location = new System.Drawing.Point(486, 435);
            this.tbActMeasure.Margin = new System.Windows.Forms.Padding(2);
            this.tbActMeasure.Name = "tbActMeasure";
            this.tbActMeasure.Size = new System.Drawing.Size(288, 58);
            this.tbActMeasure.TabIndex = 44;
            this.tbActMeasure.Text = "000000,0000";
            this.tbActMeasure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chbPressure
            // 
            this.chbPressure.BackColor = System.Drawing.Color.Transparent;
            this.chbPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbPressure.ForeColor = System.Drawing.Color.White;
            this.chbPressure.Location = new System.Drawing.Point(2, 47);
            this.chbPressure.Margin = new System.Windows.Forms.Padding(2);
            this.chbPressure.Name = "chbPressure";
            this.chbPressure.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chbPressure.Size = new System.Drawing.Size(252, 41);
            this.chbPressure.TabIndex = 42;
            this.chbPressure.Text = "Basınç Mukavemet Ölçümü";
            this.chbPressure.UseVisualStyleBackColor = false;
            this.chbPressure.CheckedChanged += new System.EventHandler(this.chbPressure_CheckedChanged);
            // 
            // chbBend
            // 
            this.chbBend.BackColor = System.Drawing.Color.Transparent;
            this.chbBend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbBend.ForeColor = System.Drawing.Color.White;
            this.chbBend.Location = new System.Drawing.Point(2, 2);
            this.chbBend.Margin = new System.Windows.Forms.Padding(2);
            this.chbBend.Name = "chbBend";
            this.chbBend.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chbBend.Size = new System.Drawing.Size(252, 41);
            this.chbBend.TabIndex = 41;
            this.chbBend.Text = "Eğilme Mukavemet Ölçümü";
            this.chbBend.UseVisualStyleBackColor = false;
            this.chbBend.CheckedChanged += new System.EventHandler(this.chbBend_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(42, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 29);
            this.label10.TabIndex = 40;
            this.label10.Text = "Ölçüm Türü:";
            // 
            // btMeasure
            // 
            this.btMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btMeasure.BackColor = System.Drawing.Color.White;
            this.btMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMeasure.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btMeasure.Location = new System.Drawing.Point(892, 448);
            this.btMeasure.Margin = new System.Windows.Forms.Padding(38, 38, 38, 38);
            this.btMeasure.Name = "btMeasure";
            this.btMeasure.Size = new System.Drawing.Size(148, 52);
            this.btMeasure.TabIndex = 39;
            this.btMeasure.Text = "Ölç";
            this.btMeasure.UseVisualStyleBackColor = false;
            this.btMeasure.Click += new System.EventHandler(this.btMeasure_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatus.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbStatus.ForeColor = System.Drawing.Color.Black;
            this.lbStatus.Location = new System.Drawing.Point(0, 70);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(160, 55);
            this.lbStatus.TabIndex = 54;
            this.lbStatus.Text = "***";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 70);
            this.label9.TabIndex = 53;
            this.label9.Text = "Bağlantı Durumu";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnConnection
            // 
            this.pnConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnConnection.Controls.Add(this.panel9);
            this.pnConnection.Controls.Add(this.panel5);
            this.pnConnection.Controls.Add(this.panel4);
            this.pnConnection.Controls.Add(this.panel8);
            this.pnConnection.Controls.Add(this.panel3);
            this.pnConnection.Controls.Add(this.panel2);
            this.pnConnection.Controls.Add(this.panel6);
            this.pnConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnConnection.Location = new System.Drawing.Point(0, 0);
            this.pnConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnConnection.Name = "pnConnection";
            this.pnConnection.Size = new System.Drawing.Size(1250, 125);
            this.pnConnection.TabIndex = 55;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(669, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(160, 125);
            this.panel9.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(0, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 55);
            this.label8.TabIndex = 68;
            this.label8.Text = "****";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 70);
            this.label4.TabIndex = 67;
            this.label4.Text = "Slot";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(509, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 125);
            this.panel5.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 55);
            this.label7.TabIndex = 65;
            this.label7.Text = "****";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 70);
            this.label3.TabIndex = 64;
            this.label3.Text = "Rack";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(349, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 125);
            this.panel4.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(0, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 55);
            this.label6.TabIndex = 62;
            this.label6.Text = "888.888.8.888";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 70);
            this.label2.TabIndex = 63;
            this.label2.Text = "IP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btDisconnect);
            this.panel8.Controls.Add(this.btConnect);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1040, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(210, 125);
            this.panel8.TabIndex = 59;
            // 
            // btDisconnect
            // 
            this.btDisconnect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btDisconnect.BackColor = System.Drawing.Color.White;
            this.btDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDisconnect.ForeColor = System.Drawing.Color.Black;
            this.btDisconnect.Location = new System.Drawing.Point(14, 62);
            this.btDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(148, 48);
            this.btDisconnect.TabIndex = 65;
            this.btDisconnect.Text = "Bağlantıyı Kes";
            this.btDisconnect.UseVisualStyleBackColor = false;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btConnect
            // 
            this.btConnect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btConnect.BackColor = System.Drawing.Color.White;
            this.btConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConnect.ForeColor = System.Drawing.Color.Black;
            this.btConnect.Location = new System.Drawing.Point(14, 11);
            this.btConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(148, 48);
            this.btConnect.TabIndex = 56;
            this.btConnect.Text = "Bağlan";
            this.btConnect.UseVisualStyleBackColor = false;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(189, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 125);
            this.panel3.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 55);
            this.label5.TabIndex = 61;
            this.label5.Text = "****";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 70);
            this.label1.TabIndex = 57;
            this.label1.Text = "CPU Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbStatus);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(29, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 125);
            this.panel2.TabIndex = 55;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(29, 125);
            this.panel6.TabIndex = 61;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(168)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 125);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1250, 35);
            this.button1.TabIndex = 56;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpMoldDate);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dtpProductionDate);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbNmm2Unit);
            this.panel1.Controls.Add(this.tbNmm2);
            this.panel1.Controls.Add(this.lbNewtonUnit);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.cartesianChart1);
            this.panel1.Controls.Add(this.cbUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cbProduct);
            this.panel1.Controls.Add(this.btMeasure);
            this.panel1.Controls.Add(this.btStopMeasure);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.tbActMeasure);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 531);
            this.panel1.TabIndex = 57;
            // 
            // lbNmm2Unit
            // 
            this.lbNmm2Unit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbNmm2Unit.AutoSize = true;
            this.lbNmm2Unit.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbNmm2Unit.ForeColor = System.Drawing.Color.White;
            this.lbNmm2Unit.Location = new System.Drawing.Point(741, 480);
            this.lbNmm2Unit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNmm2Unit.Name = "lbNmm2Unit";
            this.lbNmm2Unit.Size = new System.Drawing.Size(113, 37);
            this.lbNmm2Unit.TabIndex = 60;
            this.lbNmm2Unit.Text = "N/mm²";
            this.lbNmm2Unit.Visible = false;
            // 
            // tbNmm2
            // 
            this.tbNmm2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbNmm2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(168)))));
            this.tbNmm2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNmm2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbNmm2.ForeColor = System.Drawing.Color.White;
            this.tbNmm2.Location = new System.Drawing.Point(521, 476);
            this.tbNmm2.Margin = new System.Windows.Forms.Padding(2);
            this.tbNmm2.Name = "tbNmm2";
            this.tbNmm2.Size = new System.Drawing.Size(215, 42);
            this.tbNmm2.TabIndex = 59;
            this.tbNmm2.Text = "000000,0000";
            this.tbNmm2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNmm2.Visible = false;
            // 
            // lbNewtonUnit
            // 
            this.lbNewtonUnit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbNewtonUnit.AutoSize = true;
            this.lbNewtonUnit.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbNewtonUnit.ForeColor = System.Drawing.Color.White;
            this.lbNewtonUnit.Location = new System.Drawing.Point(779, 436);
            this.lbNewtonUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewtonUnit.Name = "lbNewtonUnit";
            this.lbNewtonUnit.Size = new System.Drawing.Size(59, 57);
            this.lbNewtonUnit.TabIndex = 58;
            this.lbNewtonUnit.Text = "N";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chbBend, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chbPressure, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(48, 58);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 90);
            this.tableLayoutPanel1.TabIndex = 57;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart1.Location = new System.Drawing.Point(344, 44);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(2);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(858, 326);
            this.cartesianChart1.TabIndex = 56;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // cbUser
            // 
            this.cbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(48, 471);
            this.cbUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(256, 28);
            this.cbUser.TabIndex = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 412);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // cbProduct
            // 
            this.cbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(48, 217);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(256, 28);
            this.cbProduct.TabIndex = 53;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(46, 257);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 29);
            this.label11.TabIndex = 61;
            this.label11.Text = "Üretim Tarihi:";
            // 
            // dtpProductionDate
            // 
            this.dtpProductionDate.Location = new System.Drawing.Point(48, 290);
            this.dtpProductionDate.Name = "dtpProductionDate";
            this.dtpProductionDate.Size = new System.Drawing.Size(257, 28);
            this.dtpProductionDate.TabIndex = 62;
            // 
            // dtpMoldDate
            // 
            this.dtpMoldDate.Location = new System.Drawing.Point(47, 365);
            this.dtpMoldDate.Name = "dtpMoldDate";
            this.dtpMoldDate.Size = new System.Drawing.Size(257, 28);
            this.dtpMoldDate.TabIndex = 64;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(45, 332);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(219, 29);
            this.label12.TabIndex = 63;
            this.label12.Text = "Kalıp Dökme Tarihi:";
            // 
            // FormMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(1250, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnConnection);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormMeasure";
            this.Text = "FormMeasure";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMeasure_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMeasure_FormClosed);
            this.Load += new System.EventHandler(this.FormMeasure_Load);
            this.Shown += new System.EventHandler(this.FormMeasure_Shown);
            this.pnConnection.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btStopMeasure;
        private System.Windows.Forms.TextBox tbActMeasure;
        private System.Windows.Forms.CheckBox chbPressure;
        private System.Windows.Forms.CheckBox chbBend;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btMeasure;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnConnection;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btDisconnect;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbUser;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbNmm2Unit;
        private System.Windows.Forms.TextBox tbNmm2;
        private System.Windows.Forms.Label lbNewtonUnit;
        private System.Windows.Forms.DateTimePicker dtpMoldDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpProductionDate;
        private System.Windows.Forms.Label label11;
    }
}