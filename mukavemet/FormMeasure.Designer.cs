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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeasure));
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btStopMeasure = new System.Windows.Forms.Button();
            this.tbActMeasure = new System.Windows.Forms.TextBox();
            this.chbPressure = new System.Windows.Forms.CheckBox();
            this.chbBend = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btMeasure = new System.Windows.Forms.Button();
            this.tmConTimeout = new System.Windows.Forms.Timer(this.components);
            this.tmReadUpdate = new System.Windows.Forms.Timer(this.components);
            this.lbStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnConnection = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnConnection.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.label13.Location = new System.Drawing.Point(44, 404);
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
            this.btStopMeasure.Location = new System.Drawing.Point(1054, 410);
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
            this.tbActMeasure.Location = new System.Drawing.Point(581, 404);
            this.tbActMeasure.Margin = new System.Windows.Forms.Padding(2);
            this.tbActMeasure.Name = "tbActMeasure";
            this.tbActMeasure.Size = new System.Drawing.Size(280, 58);
            this.tbActMeasure.TabIndex = 44;
            this.tbActMeasure.Text = "000000,0000";
            // 
            // chbPressure
            // 
            this.chbPressure.AutoSize = true;
            this.chbPressure.BackColor = System.Drawing.Color.Transparent;
            this.chbPressure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbPressure.ForeColor = System.Drawing.Color.White;
            this.chbPressure.Location = new System.Drawing.Point(49, 114);
            this.chbPressure.Margin = new System.Windows.Forms.Padding(2);
            this.chbPressure.Name = "chbPressure";
            this.chbPressure.Padding = new System.Windows.Forms.Padding(8);
            this.chbPressure.Size = new System.Drawing.Size(249, 40);
            this.chbPressure.TabIndex = 42;
            this.chbPressure.Text = "Basınç Mukavemet Ölçümü";
            this.chbPressure.UseVisualStyleBackColor = false;
            this.chbPressure.CheckedChanged += new System.EventHandler(this.chbPressure_CheckedChanged);
            // 
            // chbBend
            // 
            this.chbBend.AutoSize = true;
            this.chbBend.BackColor = System.Drawing.Color.Transparent;
            this.chbBend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbBend.ForeColor = System.Drawing.Color.White;
            this.chbBend.Location = new System.Drawing.Point(49, 64);
            this.chbBend.Margin = new System.Windows.Forms.Padding(2);
            this.chbBend.Name = "chbBend";
            this.chbBend.Padding = new System.Windows.Forms.Padding(8);
            this.chbBend.Size = new System.Drawing.Size(250, 40);
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
            this.btMeasure.Location = new System.Drawing.Point(892, 410);
            this.btMeasure.Margin = new System.Windows.Forms.Padding(38);
            this.btMeasure.Name = "btMeasure";
            this.btMeasure.Size = new System.Drawing.Size(148, 52);
            this.btMeasure.TabIndex = 39;
            this.btMeasure.Text = "Ölç";
            this.btMeasure.UseVisualStyleBackColor = false;
            this.btMeasure.Click += new System.EventHandler(this.btMeasure_Click);
            // 
            // tmConTimeout
            // 
            this.tmConTimeout.Tick += new System.EventHandler(this.tmConTimeout_Tick);
            // 
            // tmReadUpdate
            // 
            this.tmReadUpdate.Interval = 110;
            this.tmReadUpdate.Tick += new System.EventHandler(this.tmReadUpdate_Tick);
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbStatus.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbStatus.ForeColor = System.Drawing.Color.Black;
            this.lbStatus.Location = new System.Drawing.Point(0, 74);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(264, 51);
            this.lbStatus.TabIndex = 54;
            this.lbStatus.Text = "***";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 74);
            this.label9.TabIndex = 53;
            this.label9.Text = "Bağlantı Durumu:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnConnection
            // 
            this.pnConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnConnection.Controls.Add(this.panel5);
            this.pnConnection.Controls.Add(this.panel4);
            this.pnConnection.Controls.Add(this.panel8);
            this.pnConnection.Controls.Add(this.panel3);
            this.pnConnection.Controls.Add(this.panel2);
            this.pnConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnConnection.Location = new System.Drawing.Point(0, 0);
            this.pnConnection.Margin = new System.Windows.Forms.Padding(4);
            this.pnConnection.Name = "pnConnection";
            this.pnConnection.Size = new System.Drawing.Size(1250, 125);
            this.pnConnection.TabIndex = 55;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(780, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 125);
            this.panel5.TabIndex = 58;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 70);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 55);
            this.panel7.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(129, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 55);
            this.label8.TabIndex = 66;
            this.label8.Text = "****";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 55);
            this.label4.TabIndex = 65;
            this.label4.Text = "Slot:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 70);
            this.panel6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(129, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 70);
            this.label7.TabIndex = 63;
            this.label7.Text = "****";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 70);
            this.label3.TabIndex = 59;
            this.label3.Text = "Rack:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(505, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 125);
            this.panel4.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 74);
            this.label2.TabIndex = 63;
            this.label2.Text = "IP:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(0, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 51);
            this.label6.TabIndex = 62;
            this.label6.Text = "****";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btDisconnect);
            this.panel8.Controls.Add(this.btConnect);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1030, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(220, 125);
            this.panel8.TabIndex = 59;
            // 
            // btDisconnect
            // 
            this.btDisconnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDisconnect.BackColor = System.Drawing.Color.White;
            this.btDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDisconnect.ForeColor = System.Drawing.Color.Black;
            this.btDisconnect.Location = new System.Drawing.Point(24, 62);
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
            this.btConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConnect.BackColor = System.Drawing.Color.White;
            this.btConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConnect.ForeColor = System.Drawing.Color.Black;
            this.btConnect.Location = new System.Drawing.Point(24, 11);
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
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(264, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 125);
            this.panel3.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 74);
            this.label1.TabIndex = 57;
            this.label1.Text = "CPU Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 51);
            this.label5.TabIndex = 61;
            this.label5.Text = "****";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lbStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 125);
            this.panel2.TabIndex = 55;
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
            this.button1.Margin = new System.Windows.Forms.Padding(4);
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
            this.panel1.Controls.Add(this.cartesianChart1);
            this.panel1.Controls.Add(this.cbUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cbProduct);
            this.panel1.Controls.Add(this.btMeasure);
            this.panel1.Controls.Add(this.btStopMeasure);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.chbBend);
            this.panel1.Controls.Add(this.tbActMeasure);
            this.panel1.Controls.Add(this.chbPressure);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 531);
            this.panel1.TabIndex = 57;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart1.Location = new System.Drawing.Point(344, 44);
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
            this.cbUser.Location = new System.Drawing.Point(49, 448);
            this.cbUser.Margin = new System.Windows.Forms.Padding(4);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(254, 28);
            this.cbUser.TabIndex = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(476, 390);
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
            this.cbProduct.Location = new System.Drawing.Point(49, 236);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(254, 28);
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMeasure";
            this.Text = "FormMeasure";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMeasure_FormClosing);
            this.Load += new System.EventHandler(this.FormMeasure_Load);
            this.pnConnection.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Timer tmConTimeout;
        private System.Windows.Forms.Timer tmReadUpdate;
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
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbUser;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}