using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Abstraccion
{
    public class Rectangulo : Figura
    {
        //Propiedades
        public double Largo { get; set; }
        public double Ancho { get; set; }

        //Constructor
        public Rectangulo(double largo, double ancho) : base("Rectángulo")
        {
            this.Largo = largo;
            this.Ancho = ancho;
        }

        //Metodos
        //Implementacion de metodos abstractos
        public override double CalcularArea()
        {
            return this.Largo * this.Ancho;
        }
        public override double CalcularPerimetro()
        {
            return 2.0 * this.Largo + 2.0 * this.Ancho;
        }
    }
}
