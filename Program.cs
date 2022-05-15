using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Song;
using Movie;
using Series;


namespace Spotifix
{
    class Program
    {
        public static void Main(string[] args)

        {

            Console.WriteLine("Chose media:");
            Console.WriteLine("1) Song");
            Console.WriteLine("2) Movie");
            Console.WriteLine("3) Serie");

            string media;
            media = Console.ReadLine();
            if (media == "1")
            {
                SortSong();
            }
            if (media == "2")
            {
                SortMovie();
            }
            if (media == "3")
            {
                SortSerie();
            }
        }

        static void SortSong()
        
        {
            data1 list = new data1();
            list.Main();

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Sort song by name");
            Console.WriteLine("2) Sort song by artist");
            Console.WriteLine("3) Sort song by time");
            Console.WriteLine("4) Sort song by type");
            Console.WriteLine("5) Sort song by platform");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        List<song> sorted = (from e in list.songs
                                             orderby e.name
                                             select e).ToList();

                        Console.WriteLine(String.Join(Environment.NewLine, sorted));
                        break;
                    }
                case "2":
                    {
                        List<song> sorted = (from e in list.songs
                                             orderby e.artist
                                             select e).ToList();

                        Console.WriteLine(String.Join(Environment.NewLine, sorted));
                        break;
                    }
                case "3":
                    {
                        List<song> sorted = (from e in list.songs
                                             orderby e.time
                                             select e).ToList();

                        Console.WriteLine(String.Join(Environment.NewLine, sorted));
                        break;
                    }
                case "4":
                    {
                        List<song> sorted = (from e in list.songs
                                             orderby e.type
                                             select e).ToList();

                        Console.WriteLine(String.Join(Environment.NewLine, sorted));
                        break;
                    }
                case "5":
                    {
                        List<song> sorted = (from e in list.songs
                                             orderby e.platform
                                             select e).ToList();

                        Console.WriteLine(String.Join(Environment.NewLine, sorted));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error");
                        break;
                    }
                    Console.ReadKey();
            }
        }
        static void SortMovie()

        {
            data2 list = new data2();
            list.Main();

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Sort movie by name");
            Console.WriteLine("2) Sort movie by length");
            Console.WriteLine("3) Sort movie by type");
            Console.WriteLine("4) Sort movie by date");
            Console.WriteLine("5) Sort movie by platform");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        List<movie> sorted = (from e in list.movies
                                             orderby e.name
                                             select e).ToList();

                        Console.WriteLine(String.Join(Environment.NewLine, sorted));
                        break;
                    }
                case "2":
                    {
                        List<movie> sorted = (from e in list.movies
                                             orderby e.length
                                             select e).ToList();

                        Console.WriteLine(String.Join(Environment.NewLine, sorted));
                        break;
                    }
                case "3":
                    {
                        List<movie> sorted = (from e in list.movies
                                             orderby e.type
                                             select e).ToList();

                        Console.WriteLine(String.Join(Environment.NewLine, sorted));
                        break;
                    }
                case "5":
                    {
                        List<movie> sorted = (from e in list.movies
                                             orderby e.date
                                             select e).ToList();

                        Console.WriteLine(String.Join(Environment.NewLine, sorted));
                        break;
                    }
                case "6":
                    {
                        List<movie> sorted = (from e in list.movies
                                              orderby e.platform
                                              select e).ToList();

                        Console.WriteLine(String.Join(Environment.NewLine, sorted));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error");
                        break;
                    }
                    Console.ReadKey();
            }
        }
        static void SortSerie()

        {
            data3 list = new data3();
            list.Main();

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Sort serie by name");
            Console.WriteLine("2) Sort serie by length");
            Console.WriteLine("3) Sort serie by type");
            Console.WriteLine("4) Sort serie by date");
            Console.WriteLine("5) Sort serie by platform");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        List<serie> sorted = (from e in list.series
                                              orderby e.name
                                              select e).ToList();

                        Console.WriteLine(String.Join(Environment.NewLine, sorted));
                        break;
                    }
                case "2":
                    {
                        List<serie> sorted = (from e in list.series
                                              orderby e.length
                                              select e).ToList();

                        Console.WriteLine(String.Join(Environment.NewLine, sorted));
                        break;
                    }
                case "3":
                    {
                        List<serie> sorted = (from e in list.series
                                              orderby e.type
                                              select e).ToList();

                        Console.WriteLine(String.Join(Environment.NewLine, sorted));
                        break;
                    }
                case "5":
                    {
                        List<serie> sorted = (from e in list.series
                                              orderby e.date
                                              select e).ToList();

                        Console.WriteLine(String.Join(Environment.NewLine, sorted));
                        break;
                    }
                case "6":
                    {
                        List<serie> sorted = (from e in list.series
                                              orderby e.platform
                                              select e).ToList();

                        Console.WriteLine(String.Join(Environment.NewLine, sorted));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error");
                        break;
                    }
                    Console.ReadKey();
            }
        }
    }
}