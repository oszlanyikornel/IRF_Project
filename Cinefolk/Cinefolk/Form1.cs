using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Cinefolk.Components;
using Cinefolk.Components.Movie;
using System.Web;
using Cinefolk.Controllers;
using Cinefolk.Models;
using Cinefolk.Utilities;

namespace Cinefolk
{
    public partial class Form1 : Form
    {
        private int page = 1;
        private MovieType type = MovieType.Movie;
        private int currentTotalResults = 0;
        private string currentSearchVal = "";
        private string currentYear = "";
        private MovieType currentType = MovieType.Movie;

        public Form1()
        {
            InitializeComponent();
            SetErrorMessage("Type in the search field to see results");
        }

        private void movieSwitchBtn_Click(object sender, EventArgs e)
        {
            type = MovieType.Movie;
            this.seriesSwitchBtn.BackColor = Color.FromArgb(33, 41, 60);
            this.movieSwitchBtn.BackColor = Color.FromArgb(45, 56, 82);
            Console.WriteLine(type);
        }

        private void seriesSwitchBtn_Click(object sender, EventArgs e)
        {
            type = MovieType.Series;
            this.seriesSwitchBtn.BackColor = Color.FromArgb(45, 56, 82);
            this.movieSwitchBtn.BackColor = Color.FromArgb(33, 41, 60);
            Console.WriteLine(type);
        }

        private void searchIconBtn_Click(object sender, EventArgs e)
        {
            page = 1;
            GetMovies();
        }
        private void exportIconBtn_Click(object sender, EventArgs e)
        {
            if (currentSearchVal == "" || currentYear == "" || currentTotalResults == 0)
            {
                return;
            }

            ExportForm Form2 = new ExportForm(currentTotalResults, currentType, currentSearchVal, currentYear);
            Form2.ShowDialog();

        }
        private void forwardIconBtn_Click(object sender, EventArgs e)
        {
            page += 1;
            GetMovies();
        }
        private void backwardsIconBtn_Click(object sender, EventArgs e)
        {
            if (page != 1)
            {
                page -= 1;
            }
            GetMovies();
        }
        private void SetErrorMessage(string errorMsg)
        {
            //Console.WriteLine(errorMsg);
            currentTotalResults = 0;
            currentSearchVal = "";
            currentYear = "";

            moviesFlowLayoutPanel.Controls.Clear();
            var errorMsgTxtBox = new Label();
            errorMsgTxtBox.Text = errorMsg;
            errorMsgTxtBox.ForeColor = Color.FromArgb(187, 193, 205);
            errorMsgTxtBox.Margin = new Padding(0,5,0,0);
            errorMsgTxtBox.Font = new Font("Quicksand", 9, FontStyle.Bold);
            errorMsgTxtBox.AutoSize = true;
            moviesFlowLayoutPanel.Controls.Add(errorMsgTxtBox);
        }
        private void SetMovies(List<Movie> movies)
        {
            for (int i = 0; i < movies.Count(); i++)
            {
                if (i > 4)
                {
                    return;
                }
                MovieUserControl movie = new MovieUserControl(movies[i]);
                moviesFlowLayoutPanel.Controls.Add(movie);
            }
        }
        private bool ValidateInputs()
        {
            if (searchTextBox.GetTextVal() == "" || searchTextBox.GetTextVal() == "Search...")
            {
                SetErrorMessage("Please enter something in the search field!");
                return false;
            }

            if (
                !Validation.isYear(yearTextBox.GetTextVal()) &&
                yearTextBox.GetTextVal() != "" &&
                yearTextBox.GetTextVal() != "Year..."
            )
            {
                SetErrorMessage("Year input is not valid!");
                return false;
            }

            return true;
        }
        private void GetMovies()
        {
            moviesFlowLayoutPanel.Controls.Clear();
            currentTotalResults = 0;
            currentSearchVal = "";
            currentYear = "";

            if (!ValidateInputs())
            {
                return;
            }

            string year = InputParser.modifyYear(yearTextBox.GetTextVal());

            List<Movie> movies = MovieController.SearchMovies(searchTextBox.GetTextVal(), year, type.ToString(), page);

            SetPaginationButtonSate(movies);

            if (IsEmpty(movies))
            {
                return;
            }

            currentTotalResults = movies[0].TotalResults;
            currentSearchVal = searchTextBox.GetTextVal();
            currentType = type;
            currentYear = year;

            SetMovies(movies);
        }

        private void SetPaginationButtonSate(List<Movie> movies)
        {
            if (movies.Count > 0 && movies[0].TotalResults != 0)
            {
                if (movies[0].TotalResults < 6)
                {
                    forwardIconBtn.Enabled = false;
                    forwardIconBtn.BackColor = Color.FromArgb(37, 43, 56);
                    backwardsIconBtn.Enabled = false;
                    backwardsIconBtn.BackColor = Color.FromArgb(37, 43, 56);

                }
                else
                {
                    if (page > 1)
                    {
                        backwardsIconBtn.Enabled = true;
                        backwardsIconBtn.BackColor = Color.FromArgb(33, 41, 60);
                        if (movies[0].TotalResults < page * 5 + 1)
                        {
                            forwardIconBtn.Enabled = false;
                            forwardIconBtn.BackColor = Color.FromArgb(37, 43, 56);
                        }
                        else
                        {
                            forwardIconBtn.Enabled = true;
                            forwardIconBtn.BackColor = Color.FromArgb(33, 41, 60);
                        }
                    }
                    else
                    {
                        forwardIconBtn.Enabled = true;
                        forwardIconBtn.BackColor = Color.FromArgb(33, 41, 60);
                        backwardsIconBtn.Enabled = false;
                        backwardsIconBtn.BackColor = Color.FromArgb(37, 43, 56);
                    }
                }
            }
        }

        private bool IsEmpty(List<Movie> movies)
        {
            if (movies.Count < 2)
            {
                bool empty = false;
                if (movies[0].Title == "")
                {
                    SetErrorMessage("No results");
                    empty = true;
                }
                return empty;
            }
            else
            {
                return false;
            }
        }


        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown_1(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }

}
