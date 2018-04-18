using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieAPI.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string YearReleased { get; set; }
        public string Genre { get; set; }
        public string Tagline { get; set; }
        public decimal Rating { get; set; }
    }
}