using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinefolk.Components.Common;

namespace Cinefolk.Components
{
    class YearTextBox : RoundedTextBox
    {
        protected override string GetTitle()
        {
            return "Year...";
        }

        protected override void TxtBox_LostFocus(object sender, EventArgs e)
        {
            TextBox inputTextBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(inputTextBox.Text))
            {
                inputTextBox.Text = "Year...";
                inputTextBox.ForeColor = Color.FromArgb(187, 193, 205);
            }

        }

        protected override void TxtBox_GotFocus(object sender, EventArgs e)
        {
            TextBox inputTextBox = (TextBox)sender;
            if (inputTextBox.Text == "Year...")
            {
                inputTextBox.Text = "";
                inputTextBox.ForeColor = Color.White;
            }
        }
    }
}
