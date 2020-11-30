using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Cinefolk.Components.Movie;
using Cinefolk.Models;

namespace Cinefolk.Controllers
{
    static class MovieController
    {
        public static List<Movie> SearchMovies(string searchVal, string year, string type, int page)
        {

            Uri apiUri = createSearchUri(searchVal, year, type, page);

            WebRequest request = WebRequest.Create(apiUri);
            WebResponse response = request.GetResponse();

            string res;

            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                res = reader.ReadToEnd();
            }
            response.Close();

            List<Movie> movies = new List<Movie>();

            var xml = new XmlDocument();
            xml.LoadXml(res);
            int counter = 0;

            foreach (XmlElement element in xml.DocumentElement)
            {
                string imdbId = element.GetAttribute("imdbID").ToString();
                if (page % 2 == 0)
                {
                    if (!(counter < 4))
                    {
                        Movie movie = getMovieDetails(imdbId);

                        int parsedTotalResaults;
                        bool isNumeric = int.TryParse(xml.DocumentElement.GetAttribute("totalResults"), out parsedTotalResaults);
                        if (isNumeric)
                        {
                            movie.TotalResults = parsedTotalResaults;
                        }
                        else
                        {
                            movie.TotalResults = 0;
                        }
                        movies.Add(movie);
                    }
                }
                else
                {
                    if (!(counter > 4))
                    {
                        Movie movie = getMovieDetails(imdbId);

                        int parsedTotalResaults;
                        bool isNumeric = int.TryParse(xml.DocumentElement.GetAttribute("totalResults"), out parsedTotalResaults);
                        if (isNumeric)
                        {
                            movie.TotalResults = parsedTotalResaults;
                        }
                        else
                        {
                            movie.TotalResults = 0;
                        }
                        movies.Add(movie);
                    }
                }

                counter += 1;
            }

            return movies;
        }
        private static Uri createSearchUri(string searchVal, string year, string type, int page)
        {
            double halfPage = page / 2.0;
            int newPage = (int)Math.Ceiling(halfPage);
            //Console.WriteLine(page);
            //Console.WriteLine(halfPage);
            //Console.WriteLine(newPage);
            string url = String.Format("http://www.omdbapi.com/?apikey=abab632e&s={0}&r=xml&type={1}&page={2}",
                searchVal, type.ToLower(), newPage.ToString());
            if (year != "")
            {
                url = url + "&y=" + year;
            }
            Uri apiUri = new Uri(url);
            //Console.WriteLine(apiUri);
            return apiUri;
        }
        private static Uri createDetailsUri(string imdbId)
        {
            string url = String.Format("http://www.omdbapi.com/?apikey=abab632e&i={0}&r=xml",
                imdbId);
            Uri apiUri = new Uri(url);
            //Console.WriteLine(apiUri);
            return apiUri;
        }
        private static Movie getMovieDetails(string imdbId)
        {
            Uri apiUri = createDetailsUri(imdbId);

            WebRequest request = WebRequest.Create(apiUri);
            WebResponse response = request.GetResponse();

            string res;

            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                res = reader.ReadToEnd();
            }
            response.Close();

            var xml2 = new XmlDocument();
            xml2.LoadXml(res);

            string year = "N/A";
            string plot = "N/A";
            string title = "N/A";
            string genre = "N/A";
            string director = "N/A";
            string actors = "N/A";
            string poster = "";
            string imdbRating = "N/A";

            foreach (XmlElement elem in xml2.DocumentElement)
            {
                year = elem.GetAttribute("year").ToString();
                plot = elem.GetAttribute("plot").ToString();
                title = elem.GetAttribute("title").ToString();
                genre = elem.GetAttribute("genre").ToString();
                director = elem.GetAttribute("director").ToString();
                actors = elem.GetAttribute("actors").ToString();
                poster = elem.GetAttribute("poster").ToString();
                imdbRating = elem.GetAttribute("imdbRating").ToString();
            }

            if (poster == "" || poster == "N/A")
            {
                poster = "https://www.linkpicture.com/q/fallback.jpg";
            }

            string rating = imdbRating.Split('.')[0];


            return new Movie()
            {
                Year = year,
                Plot = plot,
                Title = title,
                Genres = genre,
                Director = director,
                Stars = actors,
                ImageUrl = poster,
                Rating = rating
            };
        }
    }
}
