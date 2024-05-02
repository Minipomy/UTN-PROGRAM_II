using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Máximo__mínimo_y_promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Template de ejercicios
            Console.Title = "Clase 1 - Ejercicios";
            Console.WriteLine("Clase 1 - Ejercicio 2");

            // Crear una variable para almacenar la suma total
            double suma = 0;

            // Crear variables para el valor máximo y mínimo
            double valorMaximo = double.MinValue;
            double valorMinimo = double.MaxValue;

            // Pedir al usuario que ingrese 5 números
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Ingresa el número {i}: ");
                double numero;
                if (double.TryParse(Console.ReadLine(), out numero))
                {
                    // Actualizar la suma total
                    suma += numero;

                    // Actualizar el valor máximo y mínimo
                    valorMaximo = Math.Max(valorMaximo, numero);
                    valorMinimo = Math.Min(valorMinimo, numero);
                }
                else
                {
                    Console.WriteLine("¡Entrada inválida! Ingresa un número válido.");
                    i--; // Reintentar la entrada
                }
            }

            // Calcular el promedio
            double promedio = suma / 5;

            // Mostrar los resultados
            Console.WriteLine($"Valor máximo: {valorMaximo}");
            Console.WriteLine($"Valor mínimo: {valorMinimo}");
            Console.WriteLine($"Promedio: {promedio:F4}"); // Mostrar con 4 decimales
            Console.ReadLine();
        }
    }
}

