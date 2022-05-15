using System;
using System.Linq;
using System.Collections.Generic;

namespace Song
{

    public class song
    {
        public string name;
        public string artist;
        public string time;
        public string type;
        public string platform;

        public song(string name, string artist, string time, string type, string platform)
        {
            this.name = name;
            this.artist = artist;
            this.time = time;
            this.type = type;
            this.platform = platform;
        }

        public override string ToString()
        {
            return "[" + name + "," + artist + "," + time + "," + type + "," + platform + "]";
        }
    }

    public class data1
    {
        public List<song>? songs;
        public void Main()
        {
            song song1 = new song("Now That Im Down", "Son Seals", "6:01", "Blues", "Spotify");
            song song2 = new song("Fallen Leaves", "Billy Talent", "3:19", "Rock", "Youtube");
            song song3 = new song("Otherside", "Red Hot Chili Peppers", "4:15", "Rock", "SoundCloud");
            song song4 = new song(" Porn Star Dancing", "My Darkest Days", "3:19", " Rock", "Youtube");
            song song5 = new song("Drive You Insane", "Daniel Di Angelo", "3:22", "Sensual", "Spotify");

            songs = new List<song>() { song1, song2, song3, song4, song5 };

        }
    }
}