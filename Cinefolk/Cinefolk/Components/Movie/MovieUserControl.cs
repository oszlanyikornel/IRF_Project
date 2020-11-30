using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinefolk.Models;

namespace Cinefolk.Components.Movie
{
    public partial class MovieUserControl : UserControl
    {
        public MovieUserControl(Models.Movie movie)
        {
            InitializeComponent();
            setData(movie);
            setYearLabelVal(movie.Year);
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

        public void setYearLabelVal(string year)
        {
            yearLabel.Text = year;
            yearLabel.Location = new Point(titleLabel.Location.X + titleLabel.Width + 10, yearLabel.Location.Y);
        }

        public void setData(Models.Movie movie)
        {
            titleLabel.Text = movie.Title;
            ratingIcon.Text = movie.Rating.ToString();
            plotLabel.Text = movie.Plot;
            directorLabel.Text = movie.Director;
            starsLabel.Text = movie.Stars;
            posterPictureBox.ImageLocation = movie.ImageUrl;

            string[] genres = movie.Genres.Split(',');

            switch (genres.Length)
            {
                case 0:
                    break;
                case 1:
                    genreLabel1.Visible = true;
                    genreLabel1.Text = genres[0];
                    break;
                case 2:
                    genreLabel1.Visible = true;
                    genreLabel1.Text = genres[0];
                    genreLabel2.Visible = true;
                    genreLabel2.Text = genres[1];
                    break;
                default:
                    genreLabel1.Visible = true;
                    genreLabel1.Text = genres[0];
                    genreLabel2.Visible = true;
                    genreLabel2.Text = genres[1];
                    genreLabel3.Visible = true;
                    genreLabel3.Text = genres[2];
                    break;
            }
        }
    }
}
