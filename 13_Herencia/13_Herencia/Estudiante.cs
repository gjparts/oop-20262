using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _13_Herencia.Enum;

namespace _13_Herencia
{
    public class Estudiante : Persona //Herencia
    {
        //Propiedades
        public string Cuenta { get; set; }
        public string Carrera { get; set; }

        //Constructor
        public Estudiante(string nombre, int edad, Genero genero,
            string cuenta, string carrera)
            : base(nombre, edad, genero)
        {
            //inicializar las propiedades de la clase hija
            this.Cuenta = cuenta;
            this.Carrera = carrera;
        }
        /*Observe como en el constructor de la clase hija
         estamos ejecutando el constructor de la clase
         Padre o super clase por medio de base()
         Dentro de base van los parametros de cualquier
        constructor de la clase Padre, en este caso solo hay uno
        que espera nombre, edad y genero*/

        //Metodos
        public void Estudiar()
        {
            Console.WriteLine($"Estudio {this.Carrera}");
            Console.WriteLine($"Mi edad es {this.Edad}");
        }
    }
}
