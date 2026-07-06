using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Polimorfismo
{
    public class Gato : Animal
    {
        //Propiedades
        public string Apodo { get; set; }
        public bool TienePelaje { get; set; }

        //Constructor
        public Gato(string nombre,
            int patas, bool TieneCola, string apodo, bool tienePelaje)
            :base(nombre, "Felino", patas,TieneCola)
        {
            this.Apodo = apodo;
            this.TienePelaje = tienePelaje;
        }

        //Metodos
        public void Ronronear()
        {
            Console.WriteLine("Prrrrrrrrrrr");
        }
        /*Aplicar el polimorfismo a los metodos heredados que vuelven a ser
         mencionados en la clase hija.
        Para ello usaremos la clausula: override
        Para poder hacerle override a un metodo heredado este debe tener
        la clausula virtual en la clase padre.
        Hay dos tipos de override:
        1) Total o Completo
        2) Parcial o sea agregar caracteristicas a lo que ya hay*/
        public override void Hablar()
        {
            //Override total o completo: consiste en cambiar
            //la respuesta del metodo heredado
            Console.WriteLine("Miau");
        }
        public override void Imprimir()
        {
            //Override parcial: reutiliza el codigo del metodo heredado
            //manteniendo la funcionalidad original y permitiendonos
            //expandir las funciones del metodo en la clase hija.
            base.Imprimir(); //manda a llamar el metodo hererado de la clase padre

            //agregamos nuevas caracteristicas:
            Console.WriteLine($"Apodo: {this.Apodo}");
            Console.WriteLine($"Tiene Pelaje: {(this.TienePelaje ? "Si" : "No")}");
        }

        //tambien es posible hacer override al metodo ToString()
        //que biene hererado desde Object
        public override string ToString()
        {
            return $"Soy un gato y me apodan {this.Apodo}";
        }
        /*en .Net toda clase hereda de Object, por lo tanto
         cualquier objeto tendra disponible el metodo ToString()
        asi como otros metodos como Equals, GetType, GetHashCode
        a estos metodos se les puede hacer polimorfismo como en el
        ejemplo de arriba con el metodo ToString()*/
    }
}
