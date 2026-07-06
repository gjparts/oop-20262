using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Polimorfismo
{
    public class Perro : Animal
    {
        //Propiedades
        public string Apodo { get; set; }
        public string Raza { get; set; }

        //Constructor
        public Perro(string nombre,
            int patas, bool TieneCola, string apodo, string raza)
            : base(nombre, "Canino", patas, TieneCola)
        {
            this.Apodo = apodo;
            this.Raza = raza;
        }

        //Metodos
        public void Jugar()
        {
            Console.WriteLine("El perro se inquieta, mueve la cola y juega.");
        }
        public override void Hablar()
        {
            //Override total
            Console.WriteLine("bark woof guau");
        }
        public override void Imprimir()
        {
            //Override parcial
            base.Imprimir(); //reutilizar metodo de la super clase
            //nuevas caracteristicas:
            Console.WriteLine($"Apodo: {this.Apodo}");
            Console.WriteLine($"Raza: {this.Raza}");
        }
    }
}
