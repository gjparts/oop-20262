using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Herencia
{
    public class Media : File
    {
        //Propierties
        public Author Author { get; set; }
        public int Duration{ get; set; }

        //Constructor
        public Media(string name, int size, string type,
            string extension, DateTime creationDate, Author author,
            int duration)
            :base(name,size,type,extension,creationDate)
        {
            this.Author = author;
            this.Duration = duration;
        }

        //Methods
        public override void Print()
        {
            base.Print(); //Parcial override
            //new sentences:
            if( this.Author != null) //Agregation: Author can be null
            {
                Console.WriteLine($"Author: {this.Author.Name}");
            }
            
            Console.WriteLine($"Duration: {this.Duration} Minutes");
        }
    }
}
