using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Abstraccion
{
    public abstract class Figura
    {
        //Propiedades
        public string Nombre { get; }

        //Constructor
        public Figura(string nombre)
        {
            this.Nombre = nombre;
        }

        //Metodos abstractos
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }
}
