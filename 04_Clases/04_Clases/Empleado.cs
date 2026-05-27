using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Clases
{
    public class Empleado
    {
        //Campos privados: son variables usadas para
        //almacenar los valores reales de las Propiedades.
        //Siempre se declarar antes de todo.
        //Por convencion en C# se nombran iniciando con
        //guion bajo (underscore prexif).
        private int _edad;
        private char _genero;
        private float _salario;
        private char _contrato;

        //Propiedades
        //toda propiedad publica (+) unicamente lleva {get; set;}
        public String Nombre { get; set; }
        //Las propiedades privadas (-) en cambio llevan algo conocido
        //como validador publico el cual permite aplicar las reglas
        public int Edad
        {
            get { return this._edad; } //retornar lo guardado en el campo privado
            set
            {
                //escribe un valor en el campo privado; pero aplica antes las reglas
                if (value >= 18)
                    this._edad = value; //se acepta
                else
                    throw new ArgumentException("La edad debe de ser >= 18");
                //en caso de no cumplir con la regla se lanza una excepcion
            }
        }
        public char Genero
        {
            get { return this._genero; }
            set
            {
                if (value == 'M' || value == 'F' || value == 'X')
                    this._genero = value; //se acepta
                else
                    throw new ArgumentException("Genero debe de ser M, F ó X");
            }
        }
        public float Salario
        {
            get { return this._salario; }
            set
            {
                if (value >= 0)
                    this._salario = value; //se acepta
                else
                    throw new ArgumentException("Salario debe de ser >= 0");
            }
        }
        public char Contrato
        {
            get => this._contrato; //pueden acortar sus get usando funcion de flecha
            set
            {
                if (value == 'P' || value == 'T')
                    this._contrato = value; //se acepta
                else
                    throw new ArgumentException("Contrato debe de ser P ó T");
            }
        }
        
        //Constructores
        public Empleado(string nombre, int edad, char genero, float salario, char contrato)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.Salario = salario;
            this.Contrato = contrato;
        }
        public Empleado(string nombre, int edad, char genero)
        {
            this.Nombre= nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.Salario = 0.00f;
            this.Contrato = 'T';
        }

        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("----------- Perfil de Empleado -----------");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Edad: {this.Edad}");
            Console.WriteLine($"Genero: {this.Genero}");
            Console.WriteLine($"Salario: {this.Salario}");
            Console.WriteLine($"Contrato: {this.Contrato}");
        }
    }
}
