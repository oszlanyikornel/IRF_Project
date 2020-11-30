using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinefolk.Controllers;
using Cinefolk.Models;
using Cinefolk.Utilities;

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
            List<Models.Movie> movies = FetchMovies(totalResults, type, searchVal, year, pageNumInc.currentNumber);

            // modify list (return with list)
            // sort, minRating param
            // TODO modify the list

            // export as csv (void)
            ExportCSV(movies);
        }

        private List<Models.Movie> FetchMovies(int totalResults, MovieType type, string searchVal, string year, int pageNum)
        {
            List<Models.Movie> allMovies = new List<Models.Movie>();

            int pageNumber = 1;

            double maxPages = totalResults / 5.0;
            int maxPagesInt = (int) Math.Ceiling(maxPages);
            if (maxPagesInt > 9)
            {
                pageNumber = pageNum;
            }
            else
            {
                if (pageNum > maxPagesInt)
                {
                    pageNumber = maxPagesInt;
                }
                else
                {
                    pageNumber = pageNum;
                }
            }

            for (int page = 0; page < pageNumber; page++)
            {
                List<Models.Movie> movies = MovieController.SearchMovies(searchVal, year, type.ToString(), page);
                allMovies.AddRange(movies);
            }

            return allMovies;
        }

        private void ExportCSV(List<Models.Movie> movies)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "movies.csv";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false);

                List<string> headers = new List<string>();

                headers.Add("Title");
                headers.Add("Director");
                headers.Add("Actors");
                headers.Add("Genres");
                headers.Add("Plot");
                headers.Add("Rating");
                headers.Add("Year");
                headers.Add("Poster link");

                sw.WriteLine(string.Join(";", headers.ToArray()));

                foreach (Models.Movie movie in movies)
                {
                    List<string> data = new List<string>();

                    data.Add(movie.Title);
                    data.Add(movie.Director);
                    data.Add(movie.Stars);
                    data.Add(movie.Genres);
                    data.Add(movie.Plot.Replace(";", ","));
                    data.Add(movie.Rating);
                    data.Add(movie.Year);
                    data.Add(movie.ImageUrl);

                    sw.WriteLine(string.Join(";", data.ToArray()));
                }

                sw.Close();
            }

        }
    }
}
