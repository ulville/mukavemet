namespace mukavemet
{
    partial class MainScreen
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.pnSideMenu = new System.Windows.Forms.Panel();
            this.pnSubMenuHelp = new System.Windows.Forms.Panel();
            this.btMenuAbout = new System.Windows.Forms.Button();
            this.btMenuUsage = new System.Windows.Forms.Button();
            this.btMenuHelp = new System.Windows.Forms.Button();
            this.btMenuSettings = new System.Windows.Forms.Button();
            this.btMenuData = new System.Windows.Forms.Button();
            this.btMenuMeasure = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnChildForm = new System.Windows.Forms.Panel();
            this.pnSideMenu.SuspendLayout();
            this.pnSubMenuHelp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSideMenu
            // 
            this.pnSideMenu.AutoScroll = true;
            this.pnSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(193)))));
            this.pnSideMenu.Controls.Add(this.pnSubMenuHelp);
            this.pnSideMenu.Controls.Add(this.btMenuHelp);
            this.pnSideMenu.Controls.Add(this.btMenuSettings);
            this.pnSideMenu.Controls.Add(this.btMenuData);
            this.pnSideMenu.Controls.Add(this.btMenuMeasure);
            this.pnSideMenu.Controls.Add(this.panel1);
            this.pnSideMenu.Controls.Add(this.panel2);
            this.pnSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnSideMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnSideMenu.Name = "pnSideMenu";
            this.pnSideMenu.Size = new System.Drawing.Size(200, 553);
            this.pnSideMenu.TabIndex = 30;
            // 
            // pnSubMenuHelp
            // 
            this.pnSubMenuHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(206)))));
            this.pnSubMenuHelp.Controls.Add(this.btMenuAbout);
            this.pnSubMenuHelp.Controls.Add(this.btMenuUsage);
            this.pnSubMenuHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubMenuHelp.Location = new System.Drawing.Point(0, 332);
            this.pnSubMenuHelp.Margin = new System.Windows.Forms.Padding(2);
            this.pnSubMenuHelp.Name = "pnSubMenuHelp";
            this.pnSubMenuHelp.Size = new System.Drawing.Size(200, 100);
            this.pnSubMenuHelp.TabIndex = 6;
            // 
            // btMenuAbout
            // 
            this.btMenuAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMenuAbout.FlatAppearance.BorderSize = 0;
            this.btMenuAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenuAbout.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btMenuAbout.ForeColor = System.Drawing.Color.White;
            this.btMenuAbout.Location = new System.Drawing.Point(0, 50);
            this.btMenuAbout.Margin = new System.Windows.Forms.Padding(2);
            this.btMenuAbout.Name = "btMenuAbout";
            this.btMenuAbout.Size = new System.Drawing.Size(200, 50);
            this.btMenuAbout.TabIndex = 7;
            this.btMenuAbout.Text = "Hakkında";
            this.btMenuAbout.UseVisualStyleBackColor = true;
            this.btMenuAbout.Click += new System.EventHandler(this.btMenuAbout_Click);
            // 
            // btMenuUsage
            // 
            this.btMenuUsage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMenuUsage.FlatAppearance.BorderSize = 0;
            this.btMenuUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenuUsage.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btMenuUsage.ForeColor = System.Drawing.Color.White;
            this.btMenuUsage.Location = new System.Drawing.Point(0, 0);
            this.btMenuUsage.Margin = new System.Windows.Forms.Padding(2);
            this.btMenuUsage.Name = "btMenuUsage";
            this.btMenuUsage.Size = new System.Drawing.Size(200, 50);
            this.btMenuUsage.TabIndex = 6;
            this.btMenuUsage.Text = "Kullanım Yardımı";
            this.btMenuUsage.UseVisualStyleBackColor = true;
            // 
            // btMenuHelp
            // 
            this.btMenuHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMenuHelp.FlatAppearance.BorderSize = 0;
            this.btMenuHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenuHelp.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btMenuHelp.ForeColor = System.Drawing.Color.White;
            this.btMenuHelp.Image = ((System.Drawing.Image)(resources.GetObject("btMenuHelp.Image")));
            this.btMenuHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMenuHelp.Location = new System.Drawing.Point(0, 282);
            this.btMenuHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btMenuHelp.Name = "btMenuHelp";
            this.btMenuHelp.Size = new System.Drawing.Size(200, 50);
            this.btMenuHelp.TabIndex = 5;
            this.btMenuHelp.Text = "Yardım";
            this.btMenuHelp.UseVisualStyleBackColor = true;
            this.btMenuHelp.Click += new System.EventHandler(this.btMenuHelp_Click);
            // 
            // btMenuSettings
            // 
            this.btMenuSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMenuSettings.FlatAppearance.BorderSize = 0;
            this.btMenuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenuSettings.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btMenuSettings.ForeColor = System.Drawing.Color.White;
            this.btMenuSettings.Image = ((System.Drawing.Image)(resources.GetObject("btMenuSettings.Image")));
            this.btMenuSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMenuSettings.Location = new System.Drawing.Point(0, 232);
            this.btMenuSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btMenuSettings.Name = "btMenuSettings";
            this.btMenuSettings.Size = new System.Drawing.Size(200, 50);
            this.btMenuSettings.TabIndex = 4;
            this.btMenuSettings.Text = "  Ayarlar";
            this.btMenuSettings.UseVisualStyleBackColor = true;
            this.btMenuSettings.Click += new System.EventHandler(this.btMenuSettings_Click);
            // 
            // btMenuData
            // 
            this.btMenuData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMenuData.FlatAppearance.BorderSize = 0;
            this.btMenuData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenuData.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btMenuData.ForeColor = System.Drawing.Color.White;
            this.btMenuData.Image = ((System.Drawing.Image)(resources.GetObject("btMenuData.Image")));
            this.btMenuData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMenuData.Location = new System.Drawing.Point(0, 182);
            this.btMenuData.Margin = new System.Windows.Forms.Padding(2);
            this.btMenuData.Name = "btMenuData";
            this.btMenuData.Size = new System.Drawing.Size(200, 50);
            this.btMenuData.TabIndex = 2;
            this.btMenuData.Text = "  Kayıt";
            this.btMenuData.UseVisualStyleBackColor = true;
            this.btMenuData.Click += new System.EventHandler(this.btMenuData_Click);
            // 
            // btMenuMeasure
            // 
            this.btMenuMeasure.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMenuMeasure.FlatAppearance.BorderSize = 0;
            this.btMenuMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenuMeasure.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btMenuMeasure.ForeColor = System.Drawing.Color.White;
            this.btMenuMeasure.Image = ((System.Drawing.Image)(resources.GetObject("btMenuMeasure.Image")));
            this.btMenuMeasure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMenuMeasure.Location = new System.Drawing.Point(0, 132);
            this.btMenuMeasure.Margin = new System.Windows.Forms.Padding(2);
            this.btMenuMeasure.Name = "btMenuMeasure";
            this.btMenuMeasure.Size = new System.Drawing.Size(200, 50);
            this.btMenuMeasure.TabIndex = 1;
            this.btMenuMeasure.Text = "  Ölçüm";
            this.btMenuMeasure.UseVisualStyleBackColor = true;
            this.btMenuMeasure.Click += new System.EventHandler(this.btMenuMeasure_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 32);
            this.panel1.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(52, 6);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Mukavemet";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnChildForm
            // 
            this.pnChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.pnChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChildForm.Location = new System.Drawing.Point(200, 0);
            this.pnChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.pnChildForm.MinimumSize = new System.Drawing.Size(1000, 553);
            this.pnChildForm.Name = "pnChildForm";
            this.pnChildForm.Size = new System.Drawing.Size(1000, 553);
            this.pnChildForm.TabIndex = 31;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(1200, 553);
            this.Controls.Add(this.pnChildForm);
            this.Controls.Add(this.pnSideMenu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1216, 592);
            this.Name = "MainScreen";
            this.Text = "Mukavemet Ölçüm ve Kayıt Sistemi";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.pnSideMenu.ResumeLayout(false);
            this.pnSubMenuHelp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnSideMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btMenuMeasure;
        private System.Windows.Forms.Button btMenuHelp;
        private System.Windows.Forms.Button btMenuSettings;
        private System.Windows.Forms.Button btMenuData;
        private System.Windows.Forms.Panel pnSubMenuHelp;
        private System.Windows.Forms.Button btMenuAbout;
        private System.Windows.Forms.Button btMenuUsage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnChildForm;
    }
}

