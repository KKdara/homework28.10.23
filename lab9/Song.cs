using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab9
{
    internal class Song
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Song Prev { get; set; }
        public Song(string name, string author)
        {
            Name = name;
            Author = author;
            Prev = null;
            Console.WriteLine($"{name} - {author}");
        }

        public Song(string name, string author, Song prev)
        {
            Name = name;
            Author = author;
            Prev = prev;
        }
        public Song()
        {
            Name = null;
            Author = null; 
            Prev = null;
        }
 
    }
}
