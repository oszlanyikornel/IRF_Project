using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinefolk.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Year { get; set; }
        public string Plot { get; set; }
        public string Director { get; set; }
        public string Stars { get; set; }
        public string Genres { get; set; }
        public string Rating { get; set; }
        public int TotalResults { get; set; }

    }
}
