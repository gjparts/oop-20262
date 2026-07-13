using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Abstraccion
{
    public class TrianguloEquilatero:Figura
    {
        //Propiedades
        public double Altura { get; set; }
        public double Base { get; set; }

        //Constructor
        public TrianguloEquilatero(double altura, double valor_base)
            :base("Triángulo Equilatero")
        {
            this.Altura = altura;
            this.Base = valor_base;
        }

        //Metodos
        //Implementacion de metodos abstractos
        public override double CalcularArea()
        {
            return 0.5*this.Base*this.Altura;
        }
        public override double CalcularPerimetro()
        {
            return this.Base*3.0;
        }
    }
}
