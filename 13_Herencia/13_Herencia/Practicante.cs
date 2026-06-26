using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Herencia
{
    /*Observe a continuacion que al heredar de Empleado no se nos exije construir la super clase
     esto sucede porque en la clase padre hay un constructor sin parametros (o quiza no h ay constructores)
    entonces al haber un constructor sin parametros en la clase padre no es necesario decirlo
    en la clase hijo. Internamente el lenguaje asume que va a construir la super clase usando
    el constructor sin parametros.*/
    public class Practicante : Empleado
    {
        //Propiedades
        public int Meses { get; set; }

        //Constructor
        public Practicante(int meses)
        {
            this.Meses = meses;
        }
        /*Observe que no construimos la super clase desde el hijo ya que Empleado tiene el constructor
         sin parametros Empleado(), ese sera el que se va a ejecutar.*/
    }
}
