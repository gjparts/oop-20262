using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Abstraccion
{
    /*Una clase abstracta es aquella que se utiliza para ser
     heredada y servir como modelo para otras clases
    a traves de la estandarizacion por medio de metodos
    que deben ser implementados obligatoriamente en las clases
    hijas.*/
    public abstract class SerVivo //colocar la clausula: abstract
    {
        //Propiedades
        public string Especie { get; } //si solo le pone get entonces solo se puede leer
                                       //si desea escribirlo solo se puede por constructor
                                       //esto no tiene nada que ver con el tema de abstraccion

        //Constructor
        public SerVivo(string Especie)
        {
            this.Especie = Especie;
        }

        //Metodos
        //Metodos abstractos: son prototipos de funcion
        //solo se les coloca la firma, no van implementadas (sin cuerpo)
        public abstract void Hablar();
        public abstract void Desplazarse();
        public abstract void Alimentarse();
        public abstract void Dormir();

        //Metodos concretos (los metodos normales de toda la vida,
        //aquellos que no son abstractos)
        public void Vivir()
        {
            //en este ejemplo el metodo vivir va a depender de los
            //metodos abstractos
            this.Hablar();
            this.Alimentarse();
            this.Desplazarse();
            this.Dormir();
        }

        /*Metodos estáticos: son aquellos que se pueden usar sin necesidad
         de instanciar un nuevo objeto de la clase.
        Siempre llevan la clausula static porque solo se definen una vez por
        ejecución estando fijos en una posicion dentro de la memoria principal (RAM)*/
        public static void Saludar()
        {
            Console.WriteLine("Hola soy un texto impreso desde un metodo estatico.");
        }
        public static double FormulaCuadratica(double a, double b, double c)
        {
            if (a == 0) //Guard clause
                throw new ArgumentException("el valor de a no puede ser cero");

            double discriminante = Math.Pow(b, 2) - 4 * a * c;
            if (discriminante < 0) //Guard clause
                throw new ArgumentException("discriminante negativo, no se puede calcular");

            return (-b + Math.Sqrt(discriminante))/ (2 * a);
        }

        /*La mayoria de clases abstractas suelen incluir algo conocido
         como método de instanciación el cual es un metodo que les permite
        crear un objeto basado en la clase abstracta a través de un objeto
        cuyo tipo de dato sea compatible con la clase abstracta.
        -> En la mayoria de lenguajes este metodo se llama GetInstance
        -> El tipo de dato de retorno de este metodo será el mismo de la clase abstracta
        -> Tiene que ser estatico*/
        public static SerVivo GetInstance()
        {
            //retornar un nuevo objeto de una clase compatible (clase hija)
            //para darle variedad, vamos a devolver Gato o Humano dependiendo
            //de la hora del dia, si es par Gato si es impar Humano
            if( DateTime.Now.Hour%2 == 0 )
                return new Gato("No tiene nombre");
            else
                return new Humano("Sin nombre");
        }
    }
}
