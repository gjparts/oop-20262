using _05_CuentaAhorro.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CuentaAhorro
{
    public class CuentaAhorro
    {
        //Propiedades
        public string NombreCliente { get; set; }
        public string NumeroCuenta { get; set; }
        public float Saldo { get; private set; }
        public TipoCuenta Tipo {  get; set; }
        /*Observe que la propiedad Saldo hace mencion
         a private: esto quiere decir que la propiedad
        es privada; pero su acceso de lectura es publico a
        traves del metodo get; pero su acceso de escritura
        es privado a traves de private set lo que quiere decir
        que para escribir Saldo vamos a tener que programar
        nuestros propios metodos lo que hace innecesaria
        la existencia de un Campo Privado.*/

        //Constructores
        public CuentaAhorro(string nombreCliente, string numeroCuenta)
        {
            this.NombreCliente = nombreCliente;
            this.NumeroCuenta = numeroCuenta;
            this.Saldo = 0.00f;
            this.Tipo = TipoCuenta.Ahorro;
        }

        //Metodos
        public void Depositar(float monto)
        {
            if (monto < 0)
                throw new ArgumentException("Monto a depositar no puede ser negativo.");
            else
                this.Saldo += monto; //sumamos el monto al Saldo que ya tenemos
        }
        public void Retirar(float monto)
        {
            if (monto < 0) throw new ArgumentException("Monto a retirar no puede ser negativo");
            if (monto > this.Saldo) throw new ArgumentException("Fondos insuficientes");
            this.Saldo -= monto; //si llego aqui se resta el monto al Saldo que ya tenemos

            /*Lo anterior se le conoce como patron Early Returns lo cual 
             funciona que si algun if se cumple; entonces se ejecuta el throw
            el cual rompe con la ejecucion del Metodo y no continua procesando
            las demas lineas.*/
        }
    }
}
