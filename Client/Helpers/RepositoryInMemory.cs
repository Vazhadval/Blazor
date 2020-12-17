using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>() {
                new Movie() { Title = "Spider-Man", ReleaseDate = new DateTime(2003,2,5) },
                new Movie() { Title = "Inception", ReleaseDate = new DateTime(2010,5,12) },
                new Movie() { Title = "Wild Tales", ReleaseDate = new DateTime(2017,7,15) }
            };
        }
    }
}
