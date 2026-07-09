using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Abstraccion
{
    public class Humano : SerVivo
    {
        //Propiedades
        public string Nombre { get; set; }

        //Constructor
        public Humano(string nombre) : base("Homo Sapiens")
        {
            this.Nombre = nombre;
        }

        //Metodos
        public override void Alimentarse() => Console.WriteLine("Come cualquier cosa");
        public override void Dormir() => Console.WriteLine("ZZZ");
        public override void Desplazarse() => Console.WriteLine("Camina de forma bipeda");
        public override void Hablar() => Console.WriteLine("Se comunica en su idioma");
    }
}
