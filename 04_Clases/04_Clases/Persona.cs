using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Clases
{
    public class Persona
    {
        //Propiedades
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public char Genero { get; set; }
        public String DNI { get; set; }

        /*Metodo Constructor
         Es aquel que permite asignar memoria a un objeto
         Se crea a partir de una clase y devuelve un apuntador de
         memoria.
         -> Si Usted no le define ningun constructor a su clase
            el lenguaje C# se crea un constructor sin parametros
        
        Caracteristicas de un constructor:
        1) Son publicos (C#, Java, C++)
        2) En C# se deben nombrar igual que a la clase que pertenecen
        3) No llevan tipo de dato puesto que retornan un apuntador
        4) En C# una clase puede tener uno o varios constructores
           siempre y cuando tengan diferente firma
        5) Normalmente los constructores se usan para inicializar
           valores en las propiedades de la clase; pero tambien
           los puede usar para ejecutar otras acciones como por ejemplo
           conectar a un servidor, a una base de datos, registrar algo
           en una bitacora, ejecutar calculos de inicio.*/
        public Persona()
        {
            //Constructor sin parametros
            this.Nombre = "No tiene";
            this.Edad = 0;
            this.Genero = 'X';
            this.DNI = "No definido";
        }
        public Persona(string nombre, int edad, char genero, string dni)
        {
            //Constructor con todos los parametros (se le llama asi
            //a un constructor que inicializa todas las propiedades
            //de una clase
            //para nombrar los parametros de un constructor se recomienda
            //usar camel Case o sino snake_case
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.DNI = dni;
        }
        public Persona(string nombre, int edad)
        {
            //Constructor con dos parametros
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = 'X';
            this.DNI = "No definido";
        }
        //Metodos: son funciones declaradas dentro de una clase
        public void Imprimir()
        {
            Console.WriteLine("*********** Perfil de la Persona ***********");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Edad: {this.Edad}");
            Console.WriteLine($"Genero: {this.GetGeneroDescripcion()}");
            Console.WriteLine($"DNI: {this.DNI}");
        }
        public bool EsMayorDeEdad()
        {
            if (this.Edad >= 18)
                return true;
            else
                return false;
        }
        //otras formas de hacer el metodo anterior:
        /*public bool EsMayorDeEdad()
        {
            return this.Edad >= 18;
        }*/
        //public bool EsMayorDeEdad() => this.Edad >= 18;
        public string GetGeneroDescripcion()
        {
            if (this.Genero == 'M') return "Masculino";
            if (this.Genero == 'F') return "Femenino";
            if (this.Genero == 'X') return "Otros";
            //Si llego hasta aqiu es porque no se cumplio ningun if anterior
            return "No configurado";
        }
    }
}
