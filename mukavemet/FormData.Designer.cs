namespace mukavemet
{
    partial class FormData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormData));
            this.dgwKayit = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbPickDate = new System.Windows.Forms.CheckBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btExportToExcel = new System.Windows.Forms.Button();
            this.btDataBase = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btMinus = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btHide = new System.Windows.Forms.Button();
            this.btRemoveSelected = new System.Windows.Forms.Button();
            this.btHamburgerMenu = new System.Windows.Forms.Button();
            this.btImportDatabase = new System.Windows.Forms.Button();
            this.btBackupDatabase = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKayit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwKayit
            // 
            this.dgwKayit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwKayit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgwKayit.BackgroundColor = System.Drawing.Color.White;
            this.dgwKayit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwKayit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwKayit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwKayit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwKayit.Location = new System.Drawing.Point(49, 41);
            this.dgwKayit.Margin = new System.Windows.Forms.Padding(38, 38, 38, 20);
            this.dgwKayit.Name = "dgwKayit";
            this.dgwKayit.RowHeadersWidth = 51;
            this.dgwKayit.RowTemplate.Height = 24;
            this.dgwKayit.Size = new System.Drawing.Size(1152, 419);
            this.dgwKayit.TabIndex = 28;
            this.dgwKayit.Visible = false;
            this.dgwKayit.Click += new System.EventHandler(this.dgwKayit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.btHamburgerMenu);
            this.panel1.Controls.Add(this.chbPickDate);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.btExportToExcel);
            this.panel1.Controls.Add(this.btDataBase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 125);
            this.panel1.TabIndex = 29;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // chbPickDate
            // 
            this.chbPickDate.AutoSize = true;
            this.chbPickDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbPickDate.ForeColor = System.Drawing.Color.Black;
            this.chbPickDate.Location = new System.Drawing.Point(190, 14);
            this.chbPickDate.Margin = new System.Windows.Forms.Padding(5);
            this.chbPickDate.Name = "chbPickDate";
            this.chbPickDate.Size = new System.Drawing.Size(148, 24);
            this.chbPickDate.TabIndex = 45;
            this.chbPickDate.Text = "Tarih Aralığı Seç";
            this.chbPickDate.UseVisualStyleBackColor = true;
            this.chbPickDate.CheckedChanged += new System.EventHandler(this.chbPickDate_CheckedChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpFrom.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFrom.CalendarTitleBackColor = System.Drawing.Color.LightSteelBlue;
            this.dtpFrom.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpFrom.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Location = new System.Drawing.Point(188, 55);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(362, 28);
            this.dtpFrom.TabIndex = 43;
            // 
            // dtpTo
            // 
            this.dtpTo.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpTo.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpTo.CalendarTitleBackColor = System.Drawing.Color.LightSteelBlue;
            this.dtpTo.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpTo.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtpTo.Enabled = false;
            this.dtpTo.Location = new System.Drawing.Point(584, 55);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(362, 28);
            this.dtpTo.TabIndex = 44;
            // 
            // btExportToExcel
            // 
            this.btExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExportToExcel.BackColor = System.Drawing.Color.White;
            this.btExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExportToExcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btExportToExcel.Location = new System.Drawing.Point(1054, 11);
            this.btExportToExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btExportToExcel.Name = "btExportToExcel";
            this.btExportToExcel.Size = new System.Drawing.Size(148, 48);
            this.btExportToExcel.TabIndex = 42;
            this.btExportToExcel.Text = "Rapor Oluştur";
            this.btExportToExcel.UseVisualStyleBackColor = false;
            this.btExportToExcel.Click += new System.EventHandler(this.btExportToExcel_Click);
            // 
            // btDataBase
            // 
            this.btDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDataBase.BackColor = System.Drawing.Color.White;
            this.btDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDataBase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btDataBase.Location = new System.Drawing.Point(1054, 62);
            this.btDataBase.Margin = new System.Windows.Forms.Padding(2);
            this.btDataBase.Name = "btDataBase";
            this.btDataBase.Size = new System.Drawing.Size(148, 48);
            this.btDataBase.TabIndex = 41;
            this.btDataBase.Text = "Kayıtları Göster";
            this.btDataBase.UseVisualStyleBackColor = false;
            this.btDataBase.Click += new System.EventHandler(this.btDataBase_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btImportDatabase);
            this.panel2.Controls.Add(this.btBackupDatabase);
            this.panel2.Controls.Add(this.btMinus);
            this.panel2.Controls.Add(this.btPlus);
            this.panel2.Controls.Add(this.btHide);
            this.panel2.Controls.Add(this.btRemoveSelected);
            this.panel2.Controls.Add(this.dgwKayit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 566);
            this.panel2.TabIndex = 30;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // btMinus
            // 
            this.btMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinus.BackColor = System.Drawing.Color.RoyalBlue;
            this.btMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinus.ForeColor = System.Drawing.Color.White;
            this.btMinus.Location = new System.Drawing.Point(1135, 7);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(30, 30);
            this.btMinus.TabIndex = 45;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = false;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btPlus
            // 
            this.btPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPlus.BackColor = System.Drawing.Color.RoyalBlue;
            this.btPlus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlus.ForeColor = System.Drawing.Color.White;
            this.btPlus.Location = new System.Drawing.Point(1171, 7);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(30, 30);
            this.btPlus.TabIndex = 44;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = false;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btHide
            // 
            this.btHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btHide.BackColor = System.Drawing.Color.White;
            this.btHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btHide.Location = new System.Drawing.Point(875, 482);
            this.btHide.Margin = new System.Windows.Forms.Padding(2);
            this.btHide.Name = "btHide";
            this.btHide.Size = new System.Drawing.Size(148, 55);
            this.btHide.TabIndex = 43;
            this.btHide.Text = "Gizle";
            this.btHide.UseVisualStyleBackColor = false;
            this.btHide.Click += new System.EventHandler(this.btHide_Click);
            // 
            // btRemoveSelected
            // 
            this.btRemoveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemoveSelected.BackColor = System.Drawing.Color.White;
            this.btRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveSelected.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btRemoveSelected.Location = new System.Drawing.Point(1054, 482);
            this.btRemoveSelected.Margin = new System.Windows.Forms.Padding(2);
            this.btRemoveSelected.Name = "btRemoveSelected";
            this.btRemoveSelected.Size = new System.Drawing.Size(148, 55);
            this.btRemoveSelected.TabIndex = 42;
            this.btRemoveSelected.Text = "Seçili Kaydı Sil";
            this.btRemoveSelected.UseVisualStyleBackColor = false;
            this.btRemoveSelected.Click += new System.EventHandler(this.btRemoveSelected_Click);
            // 
            // btHamburgerMenu
            // 
            this.btHamburgerMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btHamburgerMenu.FlatAppearance.BorderSize = 0;
            this.btHamburgerMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHamburgerMenu.ForeColor = System.Drawing.Color.Black;
            this.btHamburgerMenu.Image = ((System.Drawing.Image)(resources.GetObject("btHamburgerMenu.Image")));
            this.btHamburgerMenu.Location = new System.Drawing.Point(29, 41);
            this.btHamburgerMenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btHamburgerMenu.Name = "btHamburgerMenu";
            this.btHamburgerMenu.Size = new System.Drawing.Size(42, 42);
            this.btHamburgerMenu.TabIndex = 46;
            this.btHamburgerMenu.UseVisualStyleBackColor = false;
            this.btHamburgerMenu.Click += new System.EventHandler(this.btHamburgerMenu_Click);
            this.btHamburgerMenu.Leave += new System.EventHandler(this.btHamburgerMenu_Leave);
            // 
            // btImportDatabase
            // 
            this.btImportDatabase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btImportDatabase.BackColor = System.Drawing.Color.White;
            this.btImportDatabase.FlatAppearance.BorderSize = 0;
            this.btImportDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImportDatabase.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btImportDatabase.ForeColor = System.Drawing.Color.Black;
            this.btImportDatabase.Image = ((System.Drawing.Image)(resources.GetObject("btImportDatabase.Image")));
            this.btImportDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImportDatabase.Location = new System.Drawing.Point(4, 524);
            this.btImportDatabase.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btImportDatabase.Name = "btImportDatabase";
            this.btImportDatabase.Size = new System.Drawing.Size(28, 40);
            this.btImportDatabase.TabIndex = 48;
            this.btImportDatabase.Text = "Yedekten Veri Yükle";
            this.btImportDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImportDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btImportDatabase.UseVisualStyleBackColor = false;
            this.btImportDatabase.Click += new System.EventHandler(this.btImportDatabase_Click);
            // 
            // btBackupDatabase
            // 
            this.btBackupDatabase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btBackupDatabase.BackColor = System.Drawing.Color.White;
            this.btBackupDatabase.FlatAppearance.BorderSize = 0;
            this.btBackupDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBackupDatabase.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btBackupDatabase.ForeColor = System.Drawing.Color.Black;
            this.btBackupDatabase.Image = ((System.Drawing.Image)(resources.GetObject("btBackupDatabase.Image")));
            this.btBackupDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBackupDatabase.Location = new System.Drawing.Point(4, 469);
            this.btBackupDatabase.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btBackupDatabase.Name = "btBackupDatabase";
            this.btBackupDatabase.Size = new System.Drawing.Size(28, 40);
            this.btBackupDatabase.TabIndex = 47;
            this.btBackupDatabase.Text = "Verileri Yedekle";
            this.btBackupDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBackupDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBackupDatabase.UseVisualStyleBackColor = false;
            this.btBackupDatabase.Click += new System.EventHandler(this.btBackupDatabase_Click);
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(1250, 691);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormData";
            this.Text = "FormData";
            ((System.ComponentModel.ISupportInitialize)(this.dgwKayit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwKayit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbPickDate;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btExportToExcel;
        private System.Windows.Forms.Button btDataBase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btRemoveSelected;
        private System.Windows.Forms.Button btHide;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btHamburgerMenu;
        private System.Windows.Forms.Button btImportDatabase;
        private System.Windows.Forms.Button btBackupDatabase;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}