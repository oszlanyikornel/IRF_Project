using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinefolk.Components.Common
{
    public partial class RoundedNumInc : UserControl
    {
        public int currentNumber = 1;
        public RoundedNumInc()
        {
            InitializeComponent();
            numIconBtn.Text = currentNumber.ToString();
        }

        private void upIconBtn_Click(object sender, EventArgs e)
        {
            if (currentNumber > 8)
            {
                numIconBtn.Text = currentNumber.ToString();
            }
            else
            {
                currentNumber++;
                numIconBtn.Text = currentNumber.ToString();
            }

        }

        private void downButton1_Click(object sender, EventArgs e)
        {
            if (currentNumber < 2)
            {
                numIconBtn.Text = currentNumber.ToString();
            }
            else
            {
                currentNumber--;
                numIconBtn.Text = currentNumber.ToString();
            }
        }
    }
}
