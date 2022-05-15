using System;
using System.Linq;
using System.Collections.Generic;

namespace Movie
{

    public class movie
    {
        public string name;
        public string length;
        public string type;
        public string date;
        public string platform;

        public movie(string name, string length, string type, string date, string platform)
        {
            this.name = name;
            this.length = length;
            this.type = type;
            this.date = date;
            this.platform = platform;
        }

        public override string ToString()
        {
            return "[" + name + "," + length + "," + type + "," + date + "," + platform + "]";
        }
    }

    public class data2
    {
        public List<movie>? movies;
        public void Main()
        {
            movie movie1 = new movie("Bad Boys For Life", "2:40 h", "Action", "16. januar 2020", "ViaPlay");
            movie movie2 = new movie("Moonfall", "2:10 h", "Sci-fi", "17. februar 2022", "ViaPlay/YouTube");
            movie movie3 = new movie("Ready Player One", "2:20 h", "Eventyr", "29. marts 2018", "Google Play Film");
            movie movie4 = new movie("The Grudge", "1:33 h", "Horror", " 30 october 2020", "Netflix");
            movie movie5 = new movie("Rango", " 1:42 h", "Animation", "15 april 2011", "HBO");

            movies = new List<movie>() { movie1, movie2, movie3, movie4, movie5 };

        }
    }
}