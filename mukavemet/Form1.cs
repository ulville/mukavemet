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
using System.Data.SQLite;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Drawing.Imaging;
using System.Configuration;

namespace mukavemet
{
    public partial class MainScreen : Form
    {
        private Color unselButtonBgColor = Color.FromArgb(0, 97, 193);
        private Color unselButtonTxtColor = Color.White;
        private Color selButtonBgColor = Color.White;
        private Color selButtonTxtColor = Color.FromArgb(237, 28, 36);
        private Form formMeasure;
        private Form formData;
        private Form formAbout;
        private FormSettings formSettings;
        private Form activeForm = null;
        private Bitmap bmpMeasure;
        private Bitmap bmpData;
        private Bitmap bmpSettings;
        private Bitmap bmpMeasureSel;
        private Bitmap bmpDataSel;
        private Bitmap bmpSettingsSel;




        public MainScreen()
        {
            InitializeComponent();
            bmpMeasure = new Bitmap(btMenuMeasure.Image);
            bmpData = new Bitmap(btMenuData.Image);
            bmpSettings = new Bitmap(btMenuSettings.Image);
            bmpMeasureSel = MakeSelBitmap(btMenuMeasure);
            bmpDataSel = MakeSelBitmap(btMenuData);
            bmpSettingsSel = MakeSelBitmap(btMenuSettings);
            CustomizeDesign();
            formMeasure = new FormMeasure();
            formData = new FormData();
            formSettings = new FormSettings();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

            btMenuMeasure.PerformClick();
        }


        ////////// BURADAN SONRA UI TASARIMI //////////

        private void CustomizeDesign()
        {
            pnSubMenuHelp.Visible = false;
            ButtonColorUnsel(btMenuMeasure);
            ButtonColorUnsel(btMenuData);
            ButtonColorUnsel(btMenuSettings);
        }

        private void HideSubMenu()
        {
            if (pnSubMenuHelp.Visible == true)
                pnSubMenuHelp.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void ButtonColorUnsel(Button button)
        {
            if (button.BackColor == selButtonBgColor)
            {
                button.BackColor = unselButtonBgColor;
                button.ForeColor = unselButtonTxtColor;
                switch (button.Text)
                {
                    case "  Ölçüm":
                        button.Image = bmpMeasure;
                        break;
                    case "  Kayıt":
                        button.Image = bmpData;
                        break;
                    case "  Ayarlar":
                        button.Image = bmpSettings;
                        break;
                }
            }
        }

        private void ButtonColorSel(Button button)
        {
            CustomizeDesign();
            if (button.BackColor == unselButtonBgColor)
            {
                button.BackColor = selButtonBgColor;
                button.ForeColor = selButtonTxtColor;
                switch (button.Text)
                {
                    case "  Ölçüm":
                        button.Image = bmpMeasureSel;
                        break;
                    case "  Kayıt":
                        button.Image = bmpDataSel;
                        break;
                    case "  Ayarlar":
                        button.Image = bmpSettingsSel;
                        break;
                }

            }
        }

        private Bitmap MakeSelBitmap(Button button)
        {
            Bitmap bmp = new Bitmap(button.Image);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color oldColor = bmp.GetPixel(x, y);
                    Color newColor = Color.FromArgb(oldColor.A, selButtonTxtColor.R, selButtonTxtColor.G, selButtonTxtColor.B);
                    bmp.SetPixel(x, y, newColor);
                }
            }
            return bmp;
        }

        private void btMenuHelp_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubMenuHelp);
        }

        private void btMenuMeasure_Click(object sender, EventArgs e)
        {
            ButtonColorSel((Button)sender);
            openChildForm(formMeasure);
        }

        private void btMenuData_Click(object sender, EventArgs e)
        {
            ButtonColorSel((Button)sender);
            openChildForm(formData);
        }

        private void btMenuSettings_Click(object sender, EventArgs e)
        {
            ButtonColorSel((Button)sender);
            openChildForm(formSettings);
            formSettings.ReloadMainScreen += RefreshFormMeasure;
            formSettings.ReturnMainScreen += ReturnFormMeasure;
        }

        private void btMenuAbout_Click(object sender, EventArgs e)
        {
            if (formAbout == null || formAbout.IsDisposed)
            {
                formAbout = new FormAbout();
                formAbout.Show();
            }
            else
            {
                formAbout.Focus();
            }
        }

        public void openChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            if(!pnChildForm.Controls.Contains(childForm))
                pnChildForm.Controls.Add(childForm);
            pnChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            if (activeForm != null && activeForm != childForm)
                activeForm.Hide();
            activeForm = childForm;
        }

        private void RefreshFormMeasure()
        {
            if (formMeasure != null)
                formMeasure.Close();
            formMeasure = new FormMeasure();
        }

        private void ReturnFormMeasure()
        {
            btMenuMeasure.PerformClick();
        }


    }
}
