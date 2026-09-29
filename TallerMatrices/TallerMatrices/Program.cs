using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas = 10;
            int columnas = 20;
            int[,] matriz = new int[filas, columnas];
            Random random = new Random();
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    matriz[f, c] = random.Next(1, 10);
                }
            }
            Console.WriteLine("Suma de cada columna");
            for (int c = 0; c < columnas; c++)
            {
                int sumaColumna = 0;
                for (int f = 0; f < filas; f++)
                {
                    sumaColumna += matriz[f, c];
                }
                Console.WriteLine($"Columna {c + 1}: {sumaColumna}");
            }
        }
    }
}
