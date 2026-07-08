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
    }
}
