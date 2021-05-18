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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace mukavemet
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 360,
                Height = 175,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                Font = new Font("Roboto", 11.25f),
                AutoScaleMode = AutoScaleMode.Dpi,
                MaximizeBox = false
            };
            Panel panelBottom = new Panel() 
            {
                Dock = DockStyle.Bottom,
                Height = 50,
                Padding = new Padding() { Left = 110, Right = 110, Bottom = 10, Top = 10 }
            };
            Panel panelTop = new Panel() 
            { 
                Dock = DockStyle.Top,
                Height = 35,
                BackColor = Color.White
            };
            Panel panelMid = new Panel()
            {
                Dock = DockStyle.Fill,
                Padding = new Padding() { Left = 90, Right = 90, Bottom = 15, Top = 5 },
                BackColor = Color.White
            };

            Label textLabel = new Label() { Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Text = text, AutoSize = false };
            TextBox textBox = new TextBox() { Dock = DockStyle.Fill, PasswordChar = '●' };
            Button confirmation = new Button() 
            { 
                Text = "Tamam",
                Dock = DockStyle.Fill,
                DialogResult = DialogResult.OK
            };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(panelBottom);
            prompt.Controls.Add(panelTop);
            prompt.Controls.Add(panelMid);
            panelMid.BringToFront();
            panelMid.Controls.Add(textBox);
            panelBottom.Controls.Add(confirmation);
            panelTop.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.ActiveControl = textBox;
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
