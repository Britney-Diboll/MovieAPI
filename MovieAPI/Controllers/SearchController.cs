using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieAPI.Models;
using MovieAPI.Data;

namespace MovieAPI.Controllers
{
    public class SearchController : ApiController
    {
        public IHttpActionResult Get(string title)
        {
            var db = new MoviesContext();
            var results = db.Movies.Where(w => w.Title == title);
            return Ok(results);
        }

        public IEnumerable<Movie> GetMovie(string genre)
        {
            var db = new MoviesContext();
            var getMovie = db.Movies.Where(movie => movie.Genre == genre);
            return getMovie;
        }
    }
}
