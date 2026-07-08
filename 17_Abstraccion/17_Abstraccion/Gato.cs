using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Abstraccion
{
    public class Gato : SerVivo
    {
        //Propiedades
        public string Apodo { get; set; }

        //Constructor
        public Gato(string apodo) : base("Felino")
        {
            this.Apodo = apodo;
        }

        //Metodos
        //Implementacion de metodos abstractos (se les hace override total)
        public override void Desplazarse()
        {
            Console.WriteLine("Camina sigilosamente");
        }
        public override void Hablar()
        {
            Console.WriteLine("Miau");
        }
        public override void Alimentarse()
        {
            Console.WriteLine("Come alimentos gatunos");
        }
        //si solo usa una instruccion recuerde que puede usar funcion de flecha
        public override void Dormir() => Console.WriteLine("Se enrolla y descansa");
    }
}
