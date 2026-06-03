using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Asociacion_clases
{
    public class Operador
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Pais { get; set; }

        //Constructor
        public Operador(string nombre, string pais)
        {
            this.Nombre = nombre;
            this.Pais = pais;
        }
    }
}
