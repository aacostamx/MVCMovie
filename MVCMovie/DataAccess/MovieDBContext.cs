using MVCMovie.Models;
using System.Data.Entity;

namespace MVCMovie.DataAccess
{
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MovieDBContext() : base("MovieDBContext")
        {

        }
    }
}