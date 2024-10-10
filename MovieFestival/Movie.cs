using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFestival
{
    internal class Movie
    {
        public Movie(string title, Genre genre, int length)
        {
            Title = title;
            Genre = genre;
            Length = length;
        }

        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Length { get; set; }

        public string GetData()
        {
            return $"{Title} ({Length} mins) - {Genre.GetData()}";
        }
    }
}
