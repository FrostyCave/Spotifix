using System;
using System.Linq;
using System.Collections.Generic;

namespace Series
{

    public class serie
    {
        public string name;
        public string length;
        public string type;
        public string date;
        public string platform;

        public serie(string name, string length, string type, string date, string platform)
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

    public class data3
    {
        public List<serie>? series;
        public void Main()
        {
            serie serie1 = new serie(" Mighty Mike", " 1 sez - 78 ep " , "Animation" , "14 march 2019" , "HBO");
            serie serie2 = new serie(" The Good Doctor", " 5 sez - 93 ep", "Emotional", "25 september 2017", "Netflix");
            serie serie3 = new serie("Naruto", "500 ep", "Anime", "15 february 2007", "4anime");
            serie serie4 = new serie("One Piece", "1013 ep", "Anime", "20 october 1999", "AnimeKage");
            serie serie5 = new serie("Rick and Morty", "5 sez - 51 ep", "Animation", "2 december 2013", "Netflix & HBO");

            series = new List<serie>() { serie1, serie2, serie3, serie4, serie5 };

        }
    }
}