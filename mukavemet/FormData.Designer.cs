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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormData));
            this.dgwKayit = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pnUser = new System.Windows.Forms.Panel();
            this.clbxUserFilter = new System.Windows.Forms.CheckedListBox();
            this.btUserFilter = new System.Windows.Forms.Button();
            this.chbUserFilter = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnProduct = new System.Windows.Forms.Panel();
            this.btProductFilter = new System.Windows.Forms.Button();
            this.clbxProductFilter = new System.Windows.Forms.CheckedListBox();
            this.chbProductFilter = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbBoth = new System.Windows.Forms.RadioButton();
            this.rbBendOnly = new System.Windows.Forms.RadioButton();
            this.rbPressureOnly = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btHamburgerMenu = new System.Windows.Forms.Button();
            this.chbPickDate = new System.Windows.Forms.CheckBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btExportToExcel = new System.Windows.Forms.Button();
            this.btDataBase = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnChart = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btCloseChart = new System.Windows.Forms.Button();
            this.btImportDatabase = new System.Windows.Forms.Button();
            this.btBackupDatabase = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btHide = new System.Windows.Forms.Button();
            this.btRemoveSelected = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKayit)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pnUser.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnProduct.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnChart.SuspendLayout();
            this.panel3.SuspendLayout();
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwKayit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwKayit.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgwKayit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwKayit.Location = new System.Drawing.Point(49, 41);
            this.dgwKayit.Margin = new System.Windows.Forms.Padding(38, 38, 38, 20);
            this.dgwKayit.Name = "dgwKayit";
            this.dgwKayit.RowHeadersWidth = 51;
            this.dgwKayit.RowTemplate.Height = 24;
            this.dgwKayit.Size = new System.Drawing.Size(1152, 419);
            this.dgwKayit.TabIndex = 28;
            this.dgwKayit.Visible = false;
            this.dgwKayit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKayit_CellDoubleClick);
            this.dgwKayit.Sorted += new System.EventHandler(this.dgwKayit_Sorted);
            this.dgwKayit.Click += new System.EventHandler(this.dgwKayit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btHamburgerMenu);
            this.panel1.Controls.Add(this.chbPickDate);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.btExportToExcel);
            this.panel1.Controls.Add(this.btDataBase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 125);
            this.panel1.TabIndex = 29;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pnUser, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(760, 11);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(250, 28);
            this.tableLayoutPanel3.TabIndex = 57;
            // 
            // pnUser
            // 
            this.pnUser.BackColor = System.Drawing.Color.White;
            this.pnUser.Controls.Add(this.clbxUserFilter);
            this.pnUser.Controls.Add(this.btUserFilter);
            this.pnUser.Controls.Add(this.chbUserFilter);
            this.pnUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnUser.Location = new System.Drawing.Point(1, 1);
            this.pnUser.Margin = new System.Windows.Forms.Padding(0);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(248, 26);
            this.pnUser.TabIndex = 0;
            // 
            // clbxUserFilter
            // 
            this.clbxUserFilter.BackColor = System.Drawing.Color.White;
            this.clbxUserFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbxUserFilter.CheckOnClick = true;
            this.clbxUserFilter.Enabled = false;
            this.clbxUserFilter.ForeColor = System.Drawing.Color.Black;
            this.clbxUserFilter.FormattingEnabled = true;
            this.clbxUserFilter.Location = new System.Drawing.Point(0, 0);
            this.clbxUserFilter.Margin = new System.Windows.Forms.Padding(2);
            this.clbxUserFilter.Name = "clbxUserFilter";
            this.clbxUserFilter.Size = new System.Drawing.Size(221, 2);
            this.clbxUserFilter.TabIndex = 53;
            this.clbxUserFilter.Visible = false;
            // 
            // btUserFilter
            // 
            this.btUserFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUserFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btUserFilter.Enabled = false;
            this.btUserFilter.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btUserFilter.FlatAppearance.BorderSize = 0;
            this.btUserFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUserFilter.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btUserFilter.ForeColor = System.Drawing.Color.Black;
            this.btUserFilter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btUserFilter.Location = new System.Drawing.Point(221, -1);
            this.btUserFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btUserFilter.Name = "btUserFilter";
            this.btUserFilter.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btUserFilter.Size = new System.Drawing.Size(28, 28);
            this.btUserFilter.TabIndex = 54;
            this.btUserFilter.Text = "✔";
            this.btUserFilter.UseVisualStyleBackColor = false;
            this.btUserFilter.Visible = false;
            this.btUserFilter.Click += new System.EventHandler(this.btUserFilter_Click);
            // 
            // chbUserFilter
            // 
            this.chbUserFilter.BackColor = System.Drawing.Color.White;
            this.chbUserFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbUserFilter.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbUserFilter.ForeColor = System.Drawing.Color.Black;
            this.chbUserFilter.Location = new System.Drawing.Point(0, 0);
            this.chbUserFilter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chbUserFilter.Name = "chbUserFilter";
            this.chbUserFilter.Padding = new System.Windows.Forms.Padding(5, 2, 1, 1);
            this.chbUserFilter.Size = new System.Drawing.Size(248, 26);
            this.chbUserFilter.TabIndex = 52;
            this.chbUserFilter.Text = "Kullanıcı Filtrele";
            this.chbUserFilter.UseVisualStyleBackColor = false;
            this.chbUserFilter.CheckedChanged += new System.EventHandler(this.chbUserFilter_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pnProduct, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(504, 11);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(250, 28);
            this.tableLayoutPanel2.TabIndex = 56;
            // 
            // pnProduct
            // 
            this.pnProduct.BackColor = System.Drawing.Color.White;
            this.pnProduct.Controls.Add(this.clbxProductFilter);
            this.pnProduct.Controls.Add(this.btProductFilter);
            this.pnProduct.Controls.Add(this.chbProductFilter);
            this.pnProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnProduct.Location = new System.Drawing.Point(1, 1);
            this.pnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.pnProduct.Name = "pnProduct";
            this.pnProduct.Size = new System.Drawing.Size(248, 26);
            this.pnProduct.TabIndex = 1;
            // 
            // btProductFilter
            // 
            this.btProductFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btProductFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btProductFilter.Enabled = false;
            this.btProductFilter.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btProductFilter.FlatAppearance.BorderSize = 0;
            this.btProductFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProductFilter.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btProductFilter.ForeColor = System.Drawing.Color.Black;
            this.btProductFilter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btProductFilter.Location = new System.Drawing.Point(221, 0);
            this.btProductFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btProductFilter.Name = "btProductFilter";
            this.btProductFilter.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btProductFilter.Size = new System.Drawing.Size(28, 28);
            this.btProductFilter.TabIndex = 49;
            this.btProductFilter.Text = "✔";
            this.btProductFilter.UseVisualStyleBackColor = false;
            this.btProductFilter.Visible = false;
            this.btProductFilter.Click += new System.EventHandler(this.btProductFilter_Click);
            // 
            // clbxProductFilter
            // 
            this.clbxProductFilter.BackColor = System.Drawing.Color.White;
            this.clbxProductFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbxProductFilter.CheckOnClick = true;
            this.clbxProductFilter.Enabled = false;
            this.clbxProductFilter.ForeColor = System.Drawing.Color.Black;
            this.clbxProductFilter.FormattingEnabled = true;
            this.clbxProductFilter.Location = new System.Drawing.Point(0, 0);
            this.clbxProductFilter.Margin = new System.Windows.Forms.Padding(2);
            this.clbxProductFilter.Name = "clbxProductFilter";
            this.clbxProductFilter.Size = new System.Drawing.Size(221, 2);
            this.clbxProductFilter.TabIndex = 48;
            this.clbxProductFilter.Visible = false;
            // 
            // chbProductFilter
            // 
            this.chbProductFilter.BackColor = System.Drawing.Color.White;
            this.chbProductFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbProductFilter.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.chbProductFilter.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbProductFilter.ForeColor = System.Drawing.Color.Black;
            this.chbProductFilter.Location = new System.Drawing.Point(0, 0);
            this.chbProductFilter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chbProductFilter.Name = "chbProductFilter";
            this.chbProductFilter.Padding = new System.Windows.Forms.Padding(5, 2, 1, 1);
            this.chbProductFilter.Size = new System.Drawing.Size(248, 26);
            this.chbProductFilter.TabIndex = 47;
            this.chbProductFilter.Text = "Ürüne Göre Filtrele";
            this.chbProductFilter.UseVisualStyleBackColor = false;
            this.chbProductFilter.CheckedChanged += new System.EventHandler(this.chbProductFilter_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel1.Controls.Add(this.rbBoth, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbBendOnly, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbPressureOnly, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(504, 78);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 32);
            this.tableLayoutPanel1.TabIndex = 55;
            // 
            // rbBoth
            // 
            this.rbBoth.Checked = true;
            this.rbBoth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbBoth.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBoth.Location = new System.Drawing.Point(3, 3);
            this.rbBoth.Margin = new System.Windows.Forms.Padding(2);
            this.rbBoth.Name = "rbBoth";
            this.rbBoth.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rbBoth.Size = new System.Drawing.Size(163, 26);
            this.rbBoth.TabIndex = 0;
            this.rbBoth.TabStop = true;
            this.rbBoth.Text = "Tümü";
            this.rbBoth.UseVisualStyleBackColor = true;
            // 
            // rbBendOnly
            // 
            this.rbBendOnly.AutoSize = true;
            this.rbBendOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbBendOnly.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBendOnly.Location = new System.Drawing.Point(171, 3);
            this.rbBendOnly.Margin = new System.Windows.Forms.Padding(2);
            this.rbBendOnly.Name = "rbBendOnly";
            this.rbBendOnly.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rbBendOnly.Size = new System.Drawing.Size(162, 26);
            this.rbBendOnly.TabIndex = 1;
            this.rbBendOnly.Text = "Yalnız Eğilme";
            this.rbBendOnly.UseVisualStyleBackColor = true;
            // 
            // rbPressureOnly
            // 
            this.rbPressureOnly.AutoSize = true;
            this.rbPressureOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbPressureOnly.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPressureOnly.Location = new System.Drawing.Point(338, 3);
            this.rbPressureOnly.Margin = new System.Windows.Forms.Padding(2);
            this.rbPressureOnly.Name = "rbPressureOnly";
            this.rbPressureOnly.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.rbPressureOnly.Size = new System.Drawing.Size(164, 26);
            this.rbPressureOnly.TabIndex = 2;
            this.rbPressureOnly.Text = "Yalnız Basınç";
            this.rbPressureOnly.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(501, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Ölçüm Türüne Göre Filtrele";
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
            this.btHamburgerMenu.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btHamburgerMenu.Size = new System.Drawing.Size(42, 42);
            this.btHamburgerMenu.TabIndex = 46;
            this.btHamburgerMenu.UseVisualStyleBackColor = false;
            this.btHamburgerMenu.Click += new System.EventHandler(this.btHamburgerMenu_Click);
            this.btHamburgerMenu.Leave += new System.EventHandler(this.btHamburgerMenu_Leave);
            // 
            // chbPickDate
            // 
            this.chbPickDate.AutoSize = true;
            this.chbPickDate.ForeColor = System.Drawing.Color.Black;
            this.chbPickDate.Location = new System.Drawing.Point(100, 14);
            this.chbPickDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chbPickDate.Name = "chbPickDate";
            this.chbPickDate.Size = new System.Drawing.Size(152, 24);
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
            this.dtpFrom.Location = new System.Drawing.Point(100, 48);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.dtpTo.Location = new System.Drawing.Point(100, 82);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.panel2.Controls.Add(this.pnChart);
            this.panel2.Controls.Add(this.btImportDatabase);
            this.panel2.Controls.Add(this.btBackupDatabase);
            this.panel2.Controls.Add(this.btMinus);
            this.panel2.Controls.Add(this.btPlus);
            this.panel2.Controls.Add(this.btHide);
            this.panel2.Controls.Add(this.btRemoveSelected);
            this.panel2.Controls.Add(this.dgwKayit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 566);
            this.panel2.TabIndex = 30;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // pnChart
            // 
            this.pnChart.Controls.Add(this.panel3);
            this.pnChart.Controls.Add(this.btCloseChart);
            this.pnChart.Enabled = false;
            this.pnChart.Location = new System.Drawing.Point(132, 24);
            this.pnChart.Margin = new System.Windows.Forms.Padding(2);
            this.pnChart.Name = "pnChart";
            this.pnChart.Size = new System.Drawing.Size(908, 425);
            this.pnChart.TabIndex = 58;
            this.pnChart.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.lbTitle);
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(842, 59);
            this.panel3.TabIndex = 60;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(842, 59);
            this.lbTitle.TabIndex = 59;
            this.lbTitle.Text = "lbTitle";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCloseChart
            // 
            this.btCloseChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCloseChart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCloseChart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCloseChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCloseChart.ForeColor = System.Drawing.Color.White;
            this.btCloseChart.Location = new System.Drawing.Point(848, 18);
            this.btCloseChart.Margin = new System.Windows.Forms.Padding(2);
            this.btCloseChart.Name = "btCloseChart";
            this.btCloseChart.Size = new System.Drawing.Size(30, 30);
            this.btCloseChart.TabIndex = 58;
            this.btCloseChart.Text = "x";
            this.btCloseChart.UseVisualStyleBackColor = false;
            this.btCloseChart.Click += new System.EventHandler(this.btCloseChart_Click);
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
            // btMinus
            // 
            this.btMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinus.BackColor = System.Drawing.Color.RoyalBlue;
            this.btMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinus.ForeColor = System.Drawing.Color.White;
            this.btMinus.Location = new System.Drawing.Point(1135, 8);
            this.btMinus.Margin = new System.Windows.Forms.Padding(2);
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
            this.btPlus.Location = new System.Drawing.Point(1171, 8);
            this.btPlus.Margin = new System.Windows.Forms.Padding(2);
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
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormData";
            this.Text = "FormData";
            ((System.ComponentModel.ISupportInitialize)(this.dgwKayit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.pnUser.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnProduct.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnChart.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.CheckedListBox clbxProductFilter;
        private System.Windows.Forms.CheckBox chbProductFilter;
        private System.Windows.Forms.Button btProductFilter;
        private System.Windows.Forms.RadioButton rbPressureOnly;
        private System.Windows.Forms.RadioButton rbBendOnly;
        private System.Windows.Forms.RadioButton rbBoth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbxUserFilter;
        private System.Windows.Forms.CheckBox chbUserFilter;
        private System.Windows.Forms.Button btUserFilter;
        private System.Windows.Forms.Panel pnChart;
        private System.Windows.Forms.Button btCloseChart;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnProduct;
        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}