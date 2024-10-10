using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFestival
{
    internal class Program
    {
        public Program(DateTime date)
        {
            Date = date;
            Movies = new List<Movie>();
        }

        public DateTime Date { get; set; }
        public List<Movie> Movies { get; set; }

        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }

        public string GetData()
        {
            int totalDuration = Movies.Sum(m => m.Length);
            string movieData = string.Join("\n", Movies.Select(m => m.GetData()));
            return $"{Date:dd/MM/yyyy}\nTotal duration: {totalDuration} mins\n{movieData}";
        }
    }
}
