using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCourse
{
    internal class Film
    {
        public string Name { get; private set; }
        public string Cinema { get; private set; }
        public string Genre { get; private set; }
        public string Date { get; private set; } 
        public string Beginning { get; private set; }
        public int Duration { get; private set; }

        public Film(string nameFilm, string nameCinema, string genreFilm, string dateFilm, string beginningFilm, int durationFilm)
        {
            Name = nameFilm;
            Cinema = nameCinema;
            Genre = genreFilm;
            Date = dateFilm;
            Beginning = beginningFilm;
            Duration = durationFilm;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
