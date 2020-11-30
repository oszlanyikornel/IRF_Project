using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinefolk.Components.Common
{
    class RoundedTextBox : Panel
    {
        public RoundedTextBox()
        {
            this.Height = 34;
            this.Font = new Font("Quicksand", 9, FontStyle.Bold);
            CreateTextBox();
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nheightRect,
            int nweightRect
        );

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15,
                15));

        }

        protected void CreateTextBox()
        {
            var txtBox = new TextBox();
            txtBox.Name = "txtBox";
            txtBox.BackColor = Color.FromArgb(33, 41, 60);
            txtBox.ForeColor = Color.FromArgb(187, 193, 205);
            txtBox.BorderStyle = BorderStyle.None;
            txtBox.Location = new Point(txtBox.Location.X + 20, txtBox.Location.Y + this.Height / 2 - txtBox.Height / 2);
            txtBox.Font = new Font("Quicksand", 9, FontStyle.Bold);
            txtBox.Height = 40;
            txtBox.Width = this.Width - 40;
            txtBox.Text = GetTitle();
            txtBox.GotFocus += TxtBox_GotFocus;
            txtBox.LostFocus += TxtBox_LostFocus;
            this.Controls.Add(txtBox);
        }

        public string GetTextVal()
        {
            string textVal = "";
            foreach (Control textBoxPanelControl in this.Controls)
            {
                if (textBoxPanelControl.Name == "txtBox")
                {
                    textVal = textBoxPanelControl.Text;
                }
            }

            return textVal;
        }

        protected virtual string GetTitle()
        {
            return "Search...";
        }

        protected virtual void TxtBox_LostFocus(object sender, EventArgs e)
        {
            TextBox inputTextBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(inputTextBox.Text))
            {
                inputTextBox.Text = "Search...";
                inputTextBox.ForeColor = Color.FromArgb(187, 193, 205);
            }

        }

        protected virtual void TxtBox_GotFocus(object sender, EventArgs e)
        {
            TextBox inputTextBox = (TextBox)sender;
            if (inputTextBox.Text == "Search...")
            {
                inputTextBox.Text = "";
                inputTextBox.ForeColor = Color.White;
            }
        }
    }
}
