using _13_Herencia.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Herencia
{
    public class Empleado : Persona
    {
        //Propiedades
        public float Salario {  get; set; }
        public string Cargo { get; set; }

        //Constructores
        public Empleado(string nombre, int edad, Genero genero, float salario, string cargo)
            :base(nombre,edad,genero) //construir la super clase
        {
            this.Salario = salario;
            this.Cargo = cargo;
        }
        //en la clase hijo es posible tener mas de un constructor a pesar que la clase padre
        //solo tiene un constructor
        public Empleado()
            :base("No tiene nombre",0,Genero.Otros) //puede enviar valores genericos para construir la clase padre
        {
            this.Salario = 0;
            this.Cargo = "No tiene cargo";
        }
        //La clase hijo puede tener mas constructores que la clase Padre

        //Metodos
        public void Trabajar()
        {
            Console.WriteLine($"Trabajo en el cargo de {this.Cargo}");
            Console.WriteLine($"Mi edad es {this.Edad}");
        }
    }
}
