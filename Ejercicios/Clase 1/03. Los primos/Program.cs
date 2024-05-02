using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Los_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Template de ejercicios
            Console.Title = "Clase 1 - Ejercicios";
            Console.WriteLine("Clase 1 - Ejercicio 2");

            bool flag = true;

            while (flag)
            {
                Console.Write("Ingrese un número (o escriba 'salir' para salir): ");
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "salir")
                {
                    flag = false;
                    break;
                }

                if (int.TryParse(entrada, out int numero))
                {
                    if (numero >= 2)
                    {
                        Console.WriteLine("Números primos hasta {0}:", numero);
                        MostrarNumeros(numero);
                    }
                    else
                    {
                        Console.WriteLine("El número debe ser mayor o igual a 2.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            }

            Console.WriteLine("¡Hasta luego!");
        }
        static void MostrarNumeros(int limite)
        {
            for (int i = 2; i <= limite; i++)
            {
                if (EsPrimo(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static bool EsPrimo(int numero)
        {
            if (numero < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}
