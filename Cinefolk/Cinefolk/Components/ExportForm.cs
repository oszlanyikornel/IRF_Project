using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinefolk.Models;

namespace Cinefolk.Components
{
    public partial class ExportForm : Form
    {
        private SortType sort = SortType.Title;
        private int totalResults;
        private MovieType type;
        private string searchVal;
        private string year;

        public ExportForm(int totalResults, MovieType type, string searchVal, string year)
        {
            InitializeComponent();
            this.year = year;
            this.type = type;
            this.totalResults = totalResults;
            this.searchVal = searchVal;
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

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ratingSwitchBtn_Click(object sender, EventArgs e)
        {
            sort = SortType.Rating;
            titleSwitchBtn.BackColor = Color.FromArgb(28, 34, 48);
            ratingSwitchBtn.BackColor = Color.FromArgb(33, 41, 60);
            Console.WriteLine(sort);
        }

        private void titleSwitchBtn_Click(object sender, EventArgs e)
        {
            sort = SortType.Title;
            titleSwitchBtn.BackColor = Color.FromArgb(33, 41, 60);
            ratingSwitchBtn.BackColor = Color.FromArgb(28, 34, 48);
            Console.WriteLine(sort);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
