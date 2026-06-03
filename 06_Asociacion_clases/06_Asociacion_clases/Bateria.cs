using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Asociacion_clases
{
    public class Bateria
    {
        //Campos privados
        private Fabricante _marca;

        //Propiedades
        public Fabricante Marca
        {
            get => this._marca;
            set
            {
                /*Vea que en el diagrama la asociacion entre
                 Bateria y Fabricante es por composicion, por lo
                tanto en algun momento nos debemos cerciorar de que marca
                no vaya a quedar sin asignar o sea sin memoria (null)*/

                //impedir que a Marca se le asigne un valor null
                //Asociacion por composicion
                if (value == null)
                    throw new ArgumentNullException("Marca en Bateria no puede ser null");
                else
                    this._marca = value; //se acepta
            }
        }
        public float Miliamperios { get; set; }

        //Constructor
        public Bateria(Fabricante marca, float miliamperios)
        {
            this.Marca = marca;
            this.Miliamperios = miliamperios;
        }
    }
}
