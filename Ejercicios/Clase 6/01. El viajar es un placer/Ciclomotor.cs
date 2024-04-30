using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _01.El_viajar_es_un_placer.Program;

namespace _01.El_viajar_es_un_placer
{
    public class Ciclomotor : VehiculoTerrestre
    {
        public short Cilindrada { get; set; }

        // Constructor de Ciclomotor
        public Ciclomotor(short ruedas, short puertas, Colores color, short marchas, short cilindrada)
            : base(ruedas, puertas, color, marchas)
        {
            Cilindrada = cilindrada;
        }
    }
}
