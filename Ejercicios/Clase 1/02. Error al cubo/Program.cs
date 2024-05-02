using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Error_al_cubo
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
                String valor = Console.ReadLine();
                if (int.Parse(valor) > 0)
                {
                    flag = false;
                    //Valor al cuadrado
                    Console.WriteLine($"El valor al cuadrado es: {Math.Pow(int.Parse(valor), 2)}");
                    //Valor al cubo
                    Console.WriteLine($"El valor al cubo es: {Math.Pow(int.Parse(valor), 3)}");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("ERROR | Por favor, volver a ingresar un valor superior a 0");
                }
            }
        }
    }
}
