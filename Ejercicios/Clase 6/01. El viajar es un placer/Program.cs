using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.El_viajar_es_un_placer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Base course template
            Console.Title = "Clase 6";
            Console.WriteLine("01. El viajar es un placer");

            // Ejemplo de uso
            var miFurgon = new Furgon(4, 2, VehiculoTerrestre.Colores.Blanco, 6, 5000);
            Console.WriteLine($"Furgon - Peso de carga: {miFurgon.PesoCarga} kg");
            Console.WriteLine($"Furgon - Marchas: {miFurgon.CantidadMarchas}");
            Console.WriteLine($"Furgon - Puertas: {miFurgon.CantidadPuertas}");
            Console.WriteLine($"Furgon - Color: {miFurgon.Color}");

            // Ejemplo de uso
            var miCiclomotor = new Ciclomotor(2, 0, VehiculoTerrestre.Colores.Gris, 4, 250);
            Console.WriteLine($"Ciclomotor - Cilindrada: {miCiclomotor.Cilindrada} cc");
            Console.WriteLine($"Ciclomotor - Marchas: {miCiclomotor.CantidadMarchas}");
            Console.WriteLine($"Ciclomotor - Puertas: {miCiclomotor.CantidadPuertas}");
            Console.WriteLine($"Ciclomotor - Color: {miCiclomotor.Color}");

            // Ejemplo de uso
            var miAutomovil = new Automovil(5, 5, VehiculoTerrestre.Colores.Rojo, 5, 2);
            Console.WriteLine($"Automovil - CantidadPasajeros: {miAutomovil.CantidadPasajeros}");
            Console.WriteLine($"Automovil - Marchas: {miAutomovil.CantidadMarchas}");
            Console.WriteLine($"Automovil - Puertas: {miAutomovil.CantidadPuertas}");
            Console.WriteLine($"Automovil - Color: {miAutomovil.Color}");
            Console.ReadLine();

        }
    }
}
