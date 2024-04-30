using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _01.El_viajar_es_un_placer.Program;

namespace _01.El_viajar_es_un_placer
{
    public class Furgon : VehiculoTerrestre
    {
        public int PesoCarga { get; set; }

        // Constructor de Furgon
        public Furgon(short ruedas, short puertas, Colores color, short marchas, int pesoCarga)
            : base(ruedas, puertas, color, marchas)
        {
            PesoCarga = pesoCarga;
        }
    }
}
