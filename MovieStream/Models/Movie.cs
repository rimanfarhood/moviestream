using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStream.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Genere { get; set; }
        public int ReleaseYear { get; set; }
        public int Rating { get; set; }
        public int Duration { get; set; }
        public required string PosterUrl { get; set; }
        public required string  Description {  get;  set; } 

    }
}