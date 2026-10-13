using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Configuración de la Matriz ---");

            int filas = CapturarFilas();
            int columnas = CapturarColumnas();
            int[,] matriz = LlenarMatriz(filas, columnas);
            MostrarMatriz(matriz);
        }

        static int CapturarFilas()
        {
            int n;
            while (true)
            {
                Console.Write("Ingrese el número de filas: ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    return n;
                }
                Console.WriteLine("Error, ingrese un número entero mayor a 0.");
            }
        }

        static int CapturarColumnas()
        {
            int m;
            while (true)
            {
                Console.Write("Ingrese el número de columnas: ");
                if (int.TryParse(Console.ReadLine(), out m) && m > 0)
                {
                    return m;
                }
                Console.WriteLine("Error, ingrese un número entero mayor a 0.");
            }
        }

        static void BorrarPantalla()
        {
            Console.Clear();
        }

        static bool EsMultiplo(int numero)
        {
            return numero % 5 == 0;
        }

        static int[,] LlenarMatriz(int n, int m)
        {
            int[,] matriz = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    while (true)
                    {
                        BorrarPantalla();
                        Console.WriteLine($"Posición: [{i + 1}][{j + 1}]");
                        Console.Write("Ingrese un número que sea múltiplo de 5  ");

                        int valor;
                        if (int.TryParse(Console.ReadLine(), out valor))
                        {
                            if (EsMultiplo(valor))
                            {
                                matriz[i, j] = valor;
                                break; 
                            }
                            else
                            {
                                Console.WriteLine("\nEl número no es múltiplo de 5");
                                Console.WriteLine("Presione enter para intentar de nuevo");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nIngrese un número entero válido");
                            Console.WriteLine("Presione Enter para continuar");
                            Console.ReadLine();
                        }
                    }
                }
            }
            return matriz;
        }

        static void MostrarMatriz(int[,] matriz)
        {
            BorrarPantalla();
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            Console.WriteLine("---- Matriz ----\n");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j],5} ");
                }
                Console.WriteLine();
            }
        }
    }
}
