using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MovieAPI.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext():base("name=DefaultConnection")
        {

        }

        public DbSet<Models.Movie> Movies { get; set; }
    }


}