using _06_Asociacion_clases.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Asociacion_clases
{
    public class SmartPhone
    {
        //Campos Privados
        private Fabricante _marca;
        private string _modelo;
        private Bateria _bateria;

        //Propiedades
        public Fabricante Marca
        {
            get => this._marca;
            set
            {
                //relacion por composicion
                if( value == null )
                    throw new ArgumentNullException("Marca en SmartPhone no puede ser null");
                else
                    this._marca = value; //se acepta
            }
        }
        public string Modelo
        {
            get => this._modelo;
            set
            {
                if (value.Trim().Length == 0)
                    throw new ArgumentException("Modelo en SmartPhone no puede ir en blanco");
                else
                    this._modelo = value; //se acepta
            }
        }
        public Capacidad Almacenamiento { get; set;}
        public Capacidad Ram { get; set; }
        public Bateria Bateria
        {
            get => this._bateria;
            set
            {
                //relacion por composicion
                if (value == null)
                    throw new ArgumentNullException("Bateria en SmartPhone no puede ser null");
                else
                    this._bateria = value; //se acepta
            }
        }
        /*Observe que la relacion entre SmartPhone y Chip es por Agregacion, por lo que
         no es obligatorio que Chip1 y Chip2 tenga objeto, o sea que admiten null*/
        public Chip Chip1 { get; set; }
        public Chip Chip2 { get; set; }

        //Constructor
        public SmartPhone(Fabricante marca, string modelo, Capacidad almacenamiento,
            Capacidad ram,  Bateria bateria, Chip chip1, Chip chip2)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Almacenamiento = almacenamiento;
            this.Ram = ram;
            this.Bateria = bateria;
            this.Chip1 = chip1;
            this.Chip2 = chip2;
        }

        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("---------- Ficha de SmartPhone ----------");
            Console.WriteLine($"Fabricante: {this.Marca.Nombre}"); //referencia en cascada
            Console.WriteLine($"Modelo: {this.Modelo}");

            Console.WriteLine($"Almacenamiento: {this.Almacenamiento}Gb");
            Console.WriteLine($"RAM: {this.Ram}Gb");

            Console.WriteLine("Datos de la bateria:");
            Console.WriteLine($"\tMarca: {this.Bateria.Marca.Nombre}");
            Console.WriteLine($"\tMiliamperios: {this.Bateria.Miliamperios}");

            /*En vista que la relacion con Chip es por Agregacion entonces
             existe la posibilidasd de que Chip1 o Chip2 no tengan asignado
            algun objeto o sea que pueden estar apuntando a null.*/
            if( this.Chip1 != null)
            {
                //solo imprime Chip1 si este es diferente de null
                Console.WriteLine("Chip 1:");
                Console.WriteLine($"\tOperador: {this.Chip1.Proveedor.Nombre}");
                Console.WriteLine($"\tNumero telefonico: {this.Chip1.NumeroTelefonico}");
            }
            if (this.Chip2 != null)
            {
                //solo imprime Chip1 si este es diferente de null
                Console.WriteLine("Chip 2:");
                Console.WriteLine($"\tOperador: {this.Chip2.Proveedor.Nombre}");
                Console.WriteLine($"\tNumero telefonico: {this.Chip2.NumeroTelefonico}");
            }
        }
    }
}
