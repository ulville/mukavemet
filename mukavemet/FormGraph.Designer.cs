namespace mukavemet
{
    partial class FormGraph
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
            this.btCloseChart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCloseChart
            // 
            this.btCloseChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCloseChart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCloseChart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCloseChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCloseChart.ForeColor = System.Drawing.Color.White;
            this.btCloseChart.Location = new System.Drawing.Point(1209, 28);
            this.btCloseChart.Margin = new System.Windows.Forms.Padding(2);
            this.btCloseChart.Name = "btCloseChart";
            this.btCloseChart.Size = new System.Drawing.Size(30, 30);
            this.btCloseChart.TabIndex = 59;
            this.btCloseChart.Text = "x";
            this.btCloseChart.UseVisualStyleBackColor = false;
            this.btCloseChart.Click += new System.EventHandler(this.btCloseChart_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.lbTitle);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1176, 59);
            this.panel3.TabIndex = 61;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1176, 59);
            this.lbTitle.TabIndex = 59;
            this.lbTitle.Text = "lbTitle";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(1250, 566);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btCloseChart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGraph";
            this.Text = "FormGraph";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGraph_FormClosed);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCloseChart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTitle;
    }
}