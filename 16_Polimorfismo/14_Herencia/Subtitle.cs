using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Herencia
{
    public class Subtitle
    {
        //Properties
        public string Language { get; set; }
        public Author Author { get; set; }

        //Constructor
        public Subtitle(string language, Author author)
        {
            this.Language = language;
            this.Author = author;
        }
    }
}
