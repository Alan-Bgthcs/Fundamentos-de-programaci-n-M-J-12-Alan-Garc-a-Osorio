using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Arreglosunidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int [5] ;
            numeros[0] = 10;
            numeros[1] = 56;
            numeros[2] = 22;
            numeros[3] = 45;
            numeros[4] = 102;

            Console.WriteLine($"El número almacenado en la posición 3 con indice 2 es: {numeros[2]}");
            char[] simbolos = new char[] { '&', 'r' };
            bool[] valoresVerdad = { true, false, false, true, true, false, };
            string[] nombres = new string[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Ingrese el nombre para P{i + 1}: I{i}");
                nombres[i] = Console.ReadLine();
            }
            Console.Clear();
            for (int i = 0; i < nombres.Length; i++) 
            {
                Console.Write($"{nombres[i]}");
            }
        }
    }
}
