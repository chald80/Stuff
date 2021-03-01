using InClass_LINQ.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InClass_LINQ.Services
{
    public class MovieCatalog
    {
        List<Movie> movies;
        public MovieCatalog()
        {
            movies = new List<Movie>();
           movies.Add(new Movie() {  Title = "Se7en", Year = 1995, DurationInMins = 127, StudioName="New Line Cinema" });
            movies.Add(new Movie() { Title = "Alien", Year = 1979, DurationInMins = 117, StudioName = "20th Century Fox" });
            movies.Add(new Movie() { Title = "Forrest Gump", Year = 1994, DurationInMins = 142, StudioName = "Paramount Pictures" });
            movies.Add(new Movie() { Title = "True Grit", Year = 2010, DurationInMins = 110, StudioName = "Paramount Pictures" });
            movies.Add(new Movie() { Title = "Dark  City", Year = 1998, DurationInMins = 111, StudioName = "New Line Cinema" });
        }
        public IEnumerable<Movie> GetMovies()
        {
            return movies;
        }
    }
}
