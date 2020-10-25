using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mukavemet
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            textBox2.TabStop = false;
            textBox1.TabStop = false;
            tbVersion.TabStop = false;
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            tbVersion.Text = "Versiyon: " + GetAppVersion();
        }

        private string GetAppVersion()
        {
            var versionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);
            return versionInfo.ProductVersion;
        }
    }
}
