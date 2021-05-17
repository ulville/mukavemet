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

//    Copyright, 2020, Ulvican Kahya

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using mukavemet.Properties;
using System.Configuration;
using System.IO;
using System.IO.Compression;

namespace mukavemet
{
    public partial class FormSettings : Form
    {
        public event Action ReloadMainScreen;
        public event Action ReturnMainScreen;

        private Panel pnHamburger = new Panel();
        private Timer tmrDelayHiding = new Timer { Interval = 10 };
        private OpenFileDialog openFileDialog2 = new OpenFileDialog();
        private string conffile = ConfigurationManager.OpenExeConfiguration(
            ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath;
        private string confPath;

        public FormSettings()
        {
            InitializeComponent();
            cbCpuType.DataSource = Enum.GetNames(typeof(CpuType));
            cbCpuType.MouseWheel += new MouseEventHandler(cbCpuType_MouseWheel);
            panel2.Width = this.Width / 2;
            panel3.Width = this.Width / 2;
            pnHamburger.Top = btHamburgerMenu.Bottom + 10;
            pnHamburger.Left = btHamburgerMenu.Left;
            pnHamburger.BackColor = Color.Black;
            pnHamburger.Size = new Size(240, 104);
            pnHamburger.BorderStyle = BorderStyle.FixedSingle;
            pnHamburger.Controls.Add(btImportSettings);
            btImportSettings.Dock = DockStyle.Top;
            pnHamburger.Controls.Add(btExportSettings);
            btExportSettings.Dock = DockStyle.Bottom;
            btExportSettings.Height = pnHamburger.Height / 2 - 1;
            btImportSettings.Height = pnHamburger.Height / 2 -1;
            tmrDelayHiding.Tick += TmrDelayHiding_Tick;
            if (!File.Exists(conffile))
            {
                Settings.Default.IP = Settings.Default.IP;
                Settings.Default.Save();
            }
            confPath = conffile + @"\..";
            //MessageBox.Show(conffile);


        }


        private void FormSettings_Load(object sender, EventArgs e)
        {
            RefreshSettingsScreen();
        }

        private void btSaveSettings_Click(object sender, EventArgs e)
        {
            Settings.Default.CpuTypeIndex = cbCpuType.SelectedIndex;
            Settings.Default.CpuType = cbCpuType.SelectedItem.ToString();
            Settings.Default.IP = tbIP.Text;
            Settings.Default.Rack = tbRack.Text;
            Settings.Default.Slot = tbSlot.Text;
            Settings.Default.BendActAddr = tbBendActAddr.Text.ToUpper();
            Settings.Default.BendMaxAddr = tbBendMaxAddr.Text.ToUpper();
            Settings.Default.PresActAddr = tbPresActAddr.Text.ToUpper();
            Settings.Default.PresMaxAddr = tbPresMaxAddr.Text.ToUpper();
            Settings.Default.MeasureAddr = tbMeasureAddr.Text.ToUpper();
            Settings.Default.SelectAddr = tbSelectionAddr.Text.ToUpper();
            string[] products = new string[0];
            foreach (var item in cbProducts.Items)
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = item.ToString();
            }
            string[] users = new string[0];
            foreach (var item in cbUsers.Items)
            {
                Array.Resize(ref users, users.Length + 1);
                users[users.Length - 1] = item.ToString();
            }
            Settings.Default.ProductList = products;
            Settings.Default.UserList = users;
            Settings.Default.TestModeAddr = tbTestModeAddr.Text.ToUpper();
            Settings.Default.TestValSetAddr = tbTestValSetAddr.Text.ToUpper();

            if (Double.TryParse(tbBendCoef.Text, out double bendCoef))
                Settings.Default.BendCoef = bendCoef;
            else
                MessageBox.Show("Eğilme katsayısı için girdiğiniz değer geçersiz olduğundan kaydedilmedi.");

            if (Double.TryParse(tbPressCoef.Text, out double presCoef))
                Settings.Default.PresCoef = presCoef;
            else
                MessageBox.Show("Basınç katsayısı için girdiğiniz değer geçersiz olduğundan kaydedilmedi.");

            Settings.Default.Save();
            RefreshSettingsScreen();
            ReloadMainScreen();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            RefreshSettingsScreen();
            ReturnMainScreen();
        }

        private void btSaveExit_Click(object sender, EventArgs e)
        {
            btSaveSettings.PerformClick();
            ReturnMainScreen();
        }

        private void RefreshSettingsScreen()
        {
            cbCpuType.SelectedIndex = Settings.Default.CpuTypeIndex;
            tbIP.Text = Settings.Default.IP;
            tbRack.Text = Settings.Default.Rack;
            tbSlot.Text = Settings.Default.Slot;
            tbBendActAddr.Text = Settings.Default.BendActAddr;
            tbBendMaxAddr.Text = Settings.Default.BendMaxAddr;
            tbPresActAddr.Text = Settings.Default.PresActAddr;
            tbPresMaxAddr.Text = Settings.Default.PresMaxAddr;
            tbMeasureAddr.Text = Settings.Default.MeasureAddr;
            tbSelectionAddr.Text = Settings.Default.SelectAddr;
            cbProducts.Items.Clear();
            cbUsers.Items.Clear();
            if (Settings.Default.ProductList != null)
                cbProducts.Items.AddRange(Settings.Default.ProductList);
            if (Settings.Default.UserList != null)
                cbUsers.Items.AddRange(Settings.Default.UserList);
            tbBendCoef.Text = Settings.Default.BendCoef.ToString();
            tbPressCoef.Text = Settings.Default.PresCoef.ToString();
            tbTestValSetAddr.Text = Settings.Default.TestValSetAddr;
            tbTestModeAddr.Text = Settings.Default.TestModeAddr;

        }

        void cbCpuType_MouseWheel(object sender, MouseEventArgs e)
        {
            ComboBox control = (ComboBox)sender;
            if (!control.DroppedDown)
                ((HandledMouseEventArgs)e).Handled = true;
        }

        private void FormSettings_Resize(object sender, EventArgs e)
        {
            panel2.Width = this.Width / 2;
            panel3.Width = this.Width / 2;
        }

        private void btEnableAdvancedSettings_Click(object sender, EventArgs e)
        {
            if (!panel7.Visible)
            {
                var result = MessageBox.Show
                    (
                    "Bu ayarların düzenlemesi teknik olarak yetkili kişilerce " +
                    "yapılmalıdır.\n Sorumluluğu kabul ediyor musunuz?",
                    "Sorumluluk Bildirgesi", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Information
                    );
                if (result == DialogResult.Yes)
                {
                    panel7.Visible = true;
                    panel7.Enabled = true;
                    btEnableAdvancedSettings.Text = "Gizle";
                }
            }
            else
            {
                panel7.Visible = false;
                panel7.Enabled = false;
                btEnableAdvancedSettings.Text = "Düzenle";
            }

        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            cbProducts.Items.Add(tbAddProduct.Text);
            tbAddProduct.ResetText();
        }

        private void btRemoveProduct_Click(object sender, EventArgs e)
        {
            if (cbProducts.Items.Count != 0)
                cbProducts.Items.RemoveAt(cbProducts.SelectedIndex);
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            cbUsers.Items.Add(tbAddUser.Text);
            tbAddUser.ResetText();
        }

        private void btRemoveUser_Click(object sender, EventArgs e)
        {
            if (cbUsers.Items.Count != 0)
                cbUsers.Items.RemoveAt(cbUsers.SelectedIndex);
        }

        private void btExportSettings_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string outpath = folderBrowserDialog1.SelectedPath;
                string outfile = outpath + @"\Mukavemet Ayar Yedek " +
                    DateTime.Now.ToString("yy-MM-dd HH-mm-ss")+".zip";

                ZipFile.CreateFromDirectory(confPath, outfile);
            }
        }

        private void btImportSettings_Click(object sender, EventArgs e)
        {
            openFileDialog2.FileName = "";

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show("Mevcut Ayarların Üzerine Yazılacak. " +
                    "Emin Misiniz?",
                    "Dikkat!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string infile = openFileDialog2.FileName;
                    if (File.Exists(conffile))
                    {
                        File.Delete(conffile);
                    }
                    ZipFile.ExtractToDirectory(infile, confPath);

                }
            }
            Settings.Default.Reload();
            RefreshSettingsScreen();
            ReloadMainScreen();
        }


        private void btHamburgerMenu_Click(object sender, EventArgs e)
        {

            if (!this.Controls.Contains(pnHamburger))
            {
                this.Controls.Add(pnHamburger);
                pnHamburger.BringToFront();

            }
            else if (pnHamburger.Visible)
            {
                pnHamburger.Enabled = false;
                pnHamburger.Visible = false;
            }
            else
            {
                pnHamburger.Enabled = true;
                pnHamburger.Visible = true;
            }
        }

        private void btHamburgerMenu_Leave(object sender, EventArgs e)
        {
            if (!btImportSettings.Focused && !btExportSettings.Focused)
            {
                tmrDelayHiding.Interval = 1;
                tmrDelayHiding.Enabled = true;
            }
            else
            {
                tmrDelayHiding.Interval = 1000;
                tmrDelayHiding.Enabled = true;
            }
        }

        private void TmrDelayHiding_Tick(object sender, EventArgs e)
        {
            tmrDelayHiding.Enabled = false;
            if (pnHamburger.Visible)
            {
                pnHamburger.Enabled = false;
                pnHamburger.Visible = false;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (pnHamburger.Visible)
            {
                pnHamburger.Enabled = false;
                pnHamburger.Visible = false;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (pnHamburger.Visible)
            {
                pnHamburger.Enabled = false;
                pnHamburger.Visible = false;
            }
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (pnHamburger.Visible)
            {
                pnHamburger.Enabled = false;
                pnHamburger.Visible = false;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (pnHamburger.Visible)
            {
                pnHamburger.Enabled = false;
                pnHamburger.Visible = false;
            }
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            if (pnHamburger.Visible)
            {
                pnHamburger.Enabled = false;
                pnHamburger.Visible = false;
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (pnHamburger.Visible)
            {
                pnHamburger.Enabled = false;
                pnHamburger.Visible = false;
            }
        }

        private void btChangePass_Click(object sender, EventArgs e)
        {
            string promptValue1 = Prompt.ShowDialog("Yeni Parola:", "Parola Değiştir");
            string promptValue2 = Prompt.ShowDialog("Parolayı Tekrar Girin:", "Parola Değiştir");
            if (promptValue1 == promptValue2)
            {
                Settings.Default.Auth = promptValue2;
                Settings.Default.Save();
                MessageBox.Show("Parola değiştirildi.");
            }
            else
                MessageBox.Show("Parolalar farklıydı. Hiçbir şey değiştirilmedi. Yeniden deneyin.");
        }
    }
}
