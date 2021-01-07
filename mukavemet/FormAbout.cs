//    This file is part of Mukavemet.

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
