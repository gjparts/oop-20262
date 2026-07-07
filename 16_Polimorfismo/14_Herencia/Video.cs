using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Herencia
{
    public class Video : Media
    {
        //Properties
        public string Codec { get; set; }
        public int Chapters { get; set; }
        public string[] Audio { get; set; }
        public List<Subtitle> Subtitles { get; set; }

        //Constructor
        public Video(string name, int size,
            string extension, DateTime creationDate, Author author,
            int duration, string codec, int chapters, string[] audio,
            List<Subtitle> subtitles)
            :base(name, size, "Video File", extension, creationDate, author, duration)
        {
            this.Codec = codec;
            this.Chapters = chapters;
            this.Audio = audio;
            this.Subtitles = subtitles;
        }

        //Methods
        public override void Print()
        {
            base.Print(); //Parcial Override
            //new sentences:
            Console.WriteLine($"Codec: {this.Codec}");
            Console.WriteLine($"Number of chapters: {this.Chapters}");

            //Audio tracks
            if( this.Audio != null)
            {
                if( this.Audio.Length > 0)
                {
                    Console.WriteLine("Audio tracks:");
                    foreach(string item in this.Audio)
                    {
                        Console.WriteLine($"\t->{item}");
                    }
                }
            }

            //Subtitles
            if( this.Subtitles != null)
            {
                if( this.Subtitles.Count > 0)
                {
                    Console.WriteLine("Subtitles:");
                    foreach(Subtitle item in this.Subtitles)
                    {
                        if( item != null)
                        {
                            Console.WriteLine($"\t->{item.Language}");
                        }
                    }
                }
            }  
        }
    }
}
