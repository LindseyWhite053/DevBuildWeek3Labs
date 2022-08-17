using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_MovieDatabases
{
    internal class Movie
    {
        public string title;
        public string category;
        public int runTime;
        public int year;

        public Movie(string _title, string _category, int _runTime, int _year)
        {
            title = _title;
            category = _category;
            runTime = _runTime;
            year = _year;

        }

        public override string ToString()
        {
            return $"\"{title}\" RunTime: {runTime} min. ({year})";
        }
    }
}
