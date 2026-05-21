using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Clases
{
    public class Mascota
    {
        //Propiedades: caracteristicas de la clase
        public String Nombre { get; set; }
        public String Especie { get; set; }
        public int Edad { get; set; }
        public char Genero { get; set; }

        //{ get; set; } se les conoce como descriptores
        //de acceso, cuando una Propiedad es publica
        //se escriben como en el ejemplo arriba.
        //{ get; set; } indica que la propiedad es lectura/escritura
        //{ get; } indica que la propiedad es de solo lectura
        //si no coloca nada es como que dijera: { get; set; }
    }
}
