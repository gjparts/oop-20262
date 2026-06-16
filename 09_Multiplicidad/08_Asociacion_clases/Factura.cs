using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Asociacion_clases
{
    public class Factura
    {
        //Campos privados
        private Producto[] _productos; //arreglo de elementos de clase Producto

        //Propiedades
        public int Numero {  get; set; }
        public DateTime Fecha {  get; set; }
        public Cliente Cliente { get; set; }
        public Producto[] Productos
        {
            get => this._productos;
            set
            {
                //validar que Productos tenga al menos un item por logica
                //tampoco puede venir null
                if(value == null)
                    throw new ArgumentNullException("Productos en Factura no puede ser null");
                else
                {
                    //arreglo debe tener al menos un item
                    if (value.Length == 0)
                        throw new ArgumentException("Productos en Factura debe tener al menos un item");
                    else
                    {
                        //elemento 0 en el arreglo no se permite null
                        if (value[0] == null)
                            throw new ArgumentNullException("Item 0 en Productos no puede ser null");
                        else
                            this._productos = value; //se acepta el arreglo
                    }
                }
            }
        }

        //Constructor
        public Factura(int numero, DateTime fecha, Cliente cliente, Producto[] productos)
        {
            this.Numero = numero;
            this.Fecha = fecha;
            this.Cliente = cliente;
            this.Productos = productos;
        }

        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("*** Factura ***");
            Console.WriteLine($"Numero: {this.Numero}");
            Console.WriteLine($"Fecha: {this.Fecha.ToString("yyyy/MM/dd")}");
            
            //como cliente se asocia por agregacion, antes de imprimir
            //valido que sea null
            if( this.Cliente == null)
                Console.WriteLine("Cliente: Consumidor final");
            else
            {
                Console.WriteLine($"Cliente: {this.Cliente.Nombre}");
                Console.WriteLine($"RTN: {this.Cliente.Rtn}");
            }

            //tabla de productos
            float suma = 0.00f;
            Console.WriteLine("producto\tprecio");
            
            //recorrer cada item del arreglo de Productos
            //para cada Producto como item en la coleccion Productos:
            foreach(Producto item in this.Productos)
            {
                //ignorar cualquier item que venga null
                if( item != null)
                {
                    //se imprime y suma solo aquellos item distintos a null
                    Console.WriteLine($"{item.Nombre}\t{item.PrecioVenta}");
                    suma += item.PrecioVenta;
                }
            }

            //Resultado
            Console.WriteLine($"Subtotal: {Math.Round(suma,2)}");
            Console.WriteLine($"ISV 15%: {Math.Round(suma*0.15f, 2)}");
            Console.WriteLine($"Total: {Math.Round(suma * 1.15f, 2)}");
        }
    }
}
