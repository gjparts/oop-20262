using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Herencia
{
    public class Document : File
    {
        //Properties
        public Author Author { get; set; }
        public DateTime ModificationDate { get; set; }
        public int Words { get; set; }

        //Constructor
        public Document(string name, int size,
            string extension, DateTime creationDate, Author author,
            DateTime modificationDate, int words)
            : base(name,size,"Document File",extension,creationDate)
        {
            this.Author = author;
            this.ModificationDate = modificationDate;
            this.Words = words;
        }
    }
}
