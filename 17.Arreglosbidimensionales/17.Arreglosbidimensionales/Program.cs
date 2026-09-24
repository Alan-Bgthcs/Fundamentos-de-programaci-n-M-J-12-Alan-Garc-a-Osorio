using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Arreglosbidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int[,] numeros = new int[2,3];

            //numeros[2, 1] = 23; no se puede almacenar porque el índice la fila no existe
            //numeros[1, 3] = 54; no se puede almacenar porque el índice la columna no existe
            numeros[0, 0] = 25;
            numeros[0, 1] = 41;
            numeros[0, 2] = 104;
            numeros[1, 0] = 47;
            numeros[1, 1] = 56;
            numeros[1, 2] = 06;

            Console.WriteLine($"El valor almacenado en numeros[1,1]: {numeros[1, 1]}");
            char[,] simbolos = new char[3,2];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Ingrese el caracter para simbolos [{i},{j}]:");
                    simbolos[i, j] = char.Parse(Console.ReadLine()); 
                }
            }

            for(int i=0; i<simbolos.GetLength(0);i++)
            {
                for(int j=0; j<simbolos.GetLength(1);j++)
                {
                    Console.Write($"{simbolos[i, j]}|");
                }
                Console.WriteLine();
            }

            string[,] nombres = {
                                  { "Ana", "Carlos", "Alex", "Mauricio" },
                                  { "Juan", "Marta", "María", "Álvaro" },
                                  { "Ramiro", "Guillermo", "Cristian", "Blanca" }
                                };
*/
            //1. Crear una matriz[10,20], en cada posición de la matriz poner el número 100; mostrar la matriz en consola
          /*  int[,] matriz = new int[10, 20];

            for(int i=0;i<10; i++)
            {
                for( int j=0; j<20; j++)
                {
                    matriz[i, j] = 100;
                    Console.WriteLine($"{matriz[i, j]}|");
                }
                Console.WriteLine();
            }*/

            //2. Escribe un programa que realice la suma de dos matrices de dimensiones 2x3, primero solicite al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas, luego, lo mismo para la segunda matriz, segundo, calcule la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices, y finalmente muestre la matriz resultante de la suma en formato de matriz, 2 filas 3 columnas
            int[,] A = new int[2, 3];
            int[,] B = new int[2, 3];
            int[,] Resultado= new int[2,3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el número para A[{i},{j}]:");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el número para B[{i},{j}]:");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Resultado[i, j] = A[i, j] + B[i, j];
                    Console.WriteLine($"La matriz resultado de la suma de A y B es: [{i},{j}]={Resultado[i, j]}");
                }
            }
        }
    }
}
