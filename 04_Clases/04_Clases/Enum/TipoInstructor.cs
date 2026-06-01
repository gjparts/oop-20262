using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Clases.Enum
{
    public enum TipoInstructor
    {
        General,
        LaboratorioFisica,
        LaboratorioQuimica,
        LaboratorioMatematicas,
        Deporte,
        Dibujo
    }
    //si no asigna un valor a cada item
    //de la enumeracion; entonces C# se asignará
    //internamente un numero de 0 a N a cada una.
}
