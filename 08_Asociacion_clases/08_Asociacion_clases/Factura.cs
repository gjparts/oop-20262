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
        private Producto _producto1;

        //Propiedades
        public int Numero {  get; set; }
        public DateTime Fecha {  get; set; }
        public Cliente Cliente { get; set; }
        public Producto Producto1
        {
            get => this._producto1;
            set
            {
                //relacion por composicion
                if (value == null)
                    throw new ArgumentNullException("Producto1 en Factura no puede ser null");
                else
                    this._producto1 = value; //se acepta
            }
        }
        public Producto Producto2 { get; set; }
        public Producto Producto3 { get; set; }
        public Producto Producto4 { get; set; }
        /*Observe que Producto2, 3 y 4 son por agregacion ya que son publicos
         en el diagrama, aunque la relacion con Producto sea por composicion.
        La relacion por Composicion solo es aplicable a Producto1.*/

        //Constructor
        public Factura(int numero, DateTime fecha, Cliente cliente, Producto producto1)
        {
            this.Numero = numero;
            this.Fecha = fecha;
            this.Cliente = cliente;
            this.Producto1 = producto1;
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
            //como Producto1 ya se valido en el set que no venga null solo se imprime y se suma
            Console.WriteLine($"{this.Producto1.Nombre}\t{this.Producto1.PrecioVenta}");
            suma += this.Producto1.PrecioVenta;

            //Producto2 al 4 pueden llegar a ser null, antes de imprimir y sumar se validan
            if( this.Producto2 != null)
            {
                Console.WriteLine($"{this.Producto2.Nombre}\t{this.Producto2.PrecioVenta}");
                suma += this.Producto2.PrecioVenta;
            }

            if (this.Producto3 != null)
            {
                Console.WriteLine($"{this.Producto3.Nombre}\t{this.Producto3.PrecioVenta}");
                suma += this.Producto3.PrecioVenta;
            }

            if (this.Producto4 != null)
            {
                Console.WriteLine($"{this.Producto4.Nombre}\t{this.Producto4.PrecioVenta}");
                suma += this.Producto4.PrecioVenta;
            }

            //Resultado
            Console.WriteLine($"Subtotal: {Math.Round(suma,2)}");
            Console.WriteLine($"ISV 15%: {Math.Round(suma*0.15f, 2)}");
            Console.WriteLine($"Total: {Math.Round(suma * 1.15f, 2)}");
        }
    }
}
