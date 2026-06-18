using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Multiplicidad
{
    public class Persona
    {
        //Propiedades
        public string Identidad {  get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public Direccion Direccion { get; set; } //asoc. por agregacion
        public Empresa EmpresaLabora { get; set; } //asoc. por agregacion
        public Mascota[] Mascotas { get; set; } //asoc. por agregacion

        //Constructor
        public Persona(string identidad, string nombre, string telefono)
        {
            this.Identidad = identidad;
            this.Nombre = nombre;
            this.Telefono = telefono;
        }

        //Metodos
        public void Imprimir()
        {
            //elegir un color al azar de entre 4 posbilidades
            int azar = new Random().Next(1,5); //objeto Volatil de un solo uso
            switch (azar)
            {
                case 1: Console.ForegroundColor = ConsoleColor.Green; break;
                case 2: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case 3: Console.ForegroundColor = ConsoleColor.Blue; break;
                case 4: Console.ForegroundColor = ConsoleColor.White; break;
            }

            Console.WriteLine("**** Perfil ****");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Identidad: {this.Identidad}");
            Console.WriteLine($"Telefono: {this.Telefono}");

            //relacion por agregacion para Direccion, potencialmente puede ser null
            if(this.Direccion != null)
            {
                Console.WriteLine("Direccion:");
                Console.WriteLine($"\tBarrio o colonia: {this.Direccion.Colonia.Nombre}");
                Console.WriteLine($"\tCalle: {this.Direccion.Calle}");
                Console.WriteLine($"\tAvenida: {this.Direccion.Avenida}");
                Console.WriteLine($"\tBloque: {this.Direccion.Bloque}");
                Console.WriteLine($"\tCasa: {this.Direccion.Casa}");
            }

            //relacion por agregacion para Empresa, potencialmente puede ser null
            if(this.EmpresaLabora != null)
            {
                Console.WriteLine("Empresa donde trabaja:");
                Console.WriteLine($"\tNombre: {this.EmpresaLabora.Nombre}");
                Console.WriteLine($"\tTelefono: {this.EmpresaLabora.Telefono}");
                Console.WriteLine($"\tBarrio o colonia: {this.EmpresaLabora.Direccion.Colonia.Nombre}");
            }

            //relacion por agregacion para Mascota, potencialmente puede ser null
            if(this.Mascotas != null)
            {
                //solo recorrer el arreglo si tiene al menos un item
                if(this.Mascotas.Length > 0)
                {
                    Console.WriteLine("Mascotas:");
                    foreach(Mascota item in this.Mascotas)
                    {
                        //si el item es null no se imprime
                        if(item != null)
                        {
                            Console.WriteLine($"\tNombre: {item.Nombre}, Especie: {item.Especie}");
                        }
                    }
                }
            }

            //regresar el color de la consola al original
            Console.ResetColor();
        }
    }
}
