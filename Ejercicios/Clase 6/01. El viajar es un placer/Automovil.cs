using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _01.El_viajar_es_un_placer.Program;

namespace _01.El_viajar_es_un_placer
{
    // Clase Automovil hereda de VehiculoTerrestre
    public class Automovil : VehiculoTerrestre
    {
        public int CantidadPasajeros { get; set; }

        // Constructor de Automovil
        public Automovil(short ruedas, short puertas, Colores color, short marchas, int pasajeros)
            : base(ruedas, puertas, color, marchas)
        {
            CantidadPasajeros = pasajeros;
        }
    }
}
