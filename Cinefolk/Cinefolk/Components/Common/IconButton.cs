using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Cinefolk.Components.Common
{
    class IconButton : Button
    {
        public IconButton()
        {
            this.Height = 34;
            this.Width = this.Height;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // X-coordinate of upper-left corner or padding at start
            int nTopRect, // Y-coordinate of upper-left corner or padding at the top of the textbox
            int nRightRect, // X-coordinate of lower-right corner or Width of the object
            int nBottomRect, // Y-coordinate of lower-right corner or Height of the object
            //RADIUS, how round do you want it to be?
            int nheightRect, //height of ellipse 
            int nweightRect //width of ellipse
        );

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15,
                15));

        }
    }
}
