using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Polimorfismo
{
    public class Animal
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public int Patas { get; set; }
        public bool TieneCola {  get; set; }

        //Constructor
        public Animal(string nombre,  string especie,
            int patas, bool TieneCola)
        {
            this.Nombre = nombre;
            this.Especie = especie;
            this.Patas = patas;
            this.TieneCola = TieneCola;
        }

        //Metodos
        /*Polimorfismo: pilar de la programacion orientada a
        objetos donde un metodo responde de diferente manera
        en cada uno de los hijos de una clase heredada.*/
        //en C# para que un metodo se le pueda aplicar
        //polimorfirmos se le coloca la clausula: virtual
        public virtual void Imprimir()
        {
            Console.WriteLine($"----- Animal -----");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Especie: {this.Especie}");
            Console.WriteLine($"Numero de patas: {this.Patas}");
            Console.WriteLine($"Tiene Cola: {(this.TieneCola ? "Si" : "No")}");
        }

        public virtual void Hablar()
        {
            Console.WriteLine($"El animal {this.Nombre} habla.");
        }
    }
}
