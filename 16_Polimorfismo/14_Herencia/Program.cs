using System.Collections.Generic;
using System.Drawing;
using System.Xml.Linq;

namespace _14_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author a1 = new Author("GNula", "gnula.org", "no lo se");
            Author a2 = new Author("Metallica", "", "");

            Document d1 = new Document("Tesis.docx", 1584935,"docx",DateTime.Now,
                new Author("Gerardo","",""),DateTime.Now, 20000);
            d1.Print();

            Audio au1 = new Audio("One", 3048205, "mp3", DateTime.Now, a2,
            5, "Metallica", "...and justice for all", 1990, 4);
            au1.Print();

            string[] pistas = { "Ingles", "Español" };

            Subtitle st1 = new Subtitle("Ingles", null);
            Subtitle st2 = new Subtitle("Español", a1);

            List<Subtitle> subtitulos = new List<Subtitle>();
            subtitulos.Add(st1);
            subtitulos.Add(st2);
            subtitulos.Add( new Subtitle("Chino",a1) );

            Video v1 = new Video("Terminator 2", 500000000,
            "mkv", DateTime.Now, null,98, "Matroska Video", 6, pistas, subtitulos);
            v1.Print();
        }
    }
}