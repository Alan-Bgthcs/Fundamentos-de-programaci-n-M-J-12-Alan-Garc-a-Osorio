using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[15];

            Console.WriteLine("Por favor, ingrese 15 números:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\n");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"[{numeros[i]}] ");
            }
            Console.WriteLine("\n");

            double mayor = numeros[0];
            int posicionMayor = 0;

            double menor = numeros[0];
            int posicionMenor = 0;

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                    posicionMayor = i;
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    posicionMenor = i;
                }
            }
            Console.WriteLine($"El número mayor es: {mayor} (se encuentra en la posición {posicionMayor + 1})");
            Console.WriteLine($"El número menor es: {menor} (se encuentra en la posición {posicionMenor + 1})");
        }
    }
}
