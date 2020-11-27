using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinefolk.Components.Movie;

namespace Cinefolk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // TODO getInitialMovies
            var movie = new MovieUserControl();
            var movie2 = new MovieUserControl();
            var movie3 = new MovieUserControl();
            var movie4 = new MovieUserControl();
            moviesFlowLayoutPanel.Controls.Add(movie);
            moviesFlowLayoutPanel.Controls.Add(movie2);
            moviesFlowLayoutPanel.Controls.Add(movie3);
            moviesFlowLayoutPanel.Controls.Add(movie4);
        }

        private void movieSwitchBtn_Click(object sender, EventArgs e)
        {
            // TODO Set contentTypeSwitch to movie
        }

        private void seriesSwitchBtn_Click(object sender, EventArgs e)
        {
            // TODO Set contentTypeSwitch to series
        }

        private void searchIconBtn_Click(object sender, EventArgs e)
        {
            // TODO validate search and year inputs
            // TODO Call movieController to fetch data with contentTypeSwitch, searchVal, yearVal
            // TODO Set fallback message if not found and initial value(type something and search to get movies...)
        }

        private void exportIconBtn_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form();
            Form2.TopMost = true;
            Form2.StartPosition = FormStartPosition.CenterParent;
            Form2.ShowDialog();
            
        }
    }
}
