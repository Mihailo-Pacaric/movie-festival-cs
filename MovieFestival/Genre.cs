using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFestival
{
    internal class Genre
    {
        public Genre(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        private string GetData()
        {
            return Name[0].ToString().ToUpper() + Name[Name.Length - 1].ToString().ToUpper();
        }
    }
}
