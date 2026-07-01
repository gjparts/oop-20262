using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Herencia
{
    public class Audio:Media
    {
        //Properties
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Year { get; set; }
        public int Track { get; set; }

        //Constructor
        public Audio(string name, int size,
            string extension, DateTime creationDate, Author author,
            int duration, string artist, string album,
            int year, int track)
            :base(name,size, "Audio File", extension, creationDate, author, duration)
        {
            this.Artist = artist;
            this.Album = album;
            this.Year = year;
            this.Track = track;
        }
    }
}
