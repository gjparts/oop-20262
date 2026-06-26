using _13_Herencia.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Herencia
{
    public class Catedratico : Empleado
    {
        //Propiedades
        public string Profesion { get; set; }

        //Constructor
        public Catedratico(string nombre, int edad, Genero genero, float salario, string profesion)
        :base(nombre, edad, genero,salario,"Docente")
        {
            this.Profesion = profesion;
        }
        /*A pesar de que la clase padre permite usar constructor sin parametros; tambien cuenta con un
         constructor que tiene todos los parametros, para Catedratico decidi usar el constructor
        de Empleasdo que tiene todos los parametros.*/

        //Metodos
        public void Educar()
        {
            Console.WriteLine($"Soy graduado de {this.Profesion}");
        }
    }
}
