using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.El_viajar_es_un_placer
{
    public class VehiculoTerrestre
    {
        // Atributos compartidos por todas las clases
        public short CantidadRuedas { get; set; }
        public short CantidadPuertas { get; set; }
        public Colores Color { get; set; }
        public short CantidadMarchas { get; set; }

        // Constructor de VehiculoTerrestre
        public VehiculoTerrestre(short ruedas, short puertas, Colores color, short marchas)
        {
            CantidadRuedas = ruedas;
            CantidadPuertas = puertas;
            Color = color;
            CantidadMarchas = marchas;
        }
        // Enumerado para los colores
        public enum Colores
        {
            Rojo,
            Blanco,
            Azul,
            Gris,
            Negro
        }

    }
}
