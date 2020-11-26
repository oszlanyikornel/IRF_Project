using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Cinefolk.Components.Common
{
    class RoundedButton : Button
    {
        public RoundedButton()
        {
            this.ForeColor = Color.FromArgb(187, 193, 205);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Height = 34;
            this.Font = new Font("Quicksand", 9, FontStyle.Bold);
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
    }
}
