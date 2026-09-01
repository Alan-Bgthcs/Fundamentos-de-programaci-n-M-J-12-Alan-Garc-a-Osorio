using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int acumulador = 0;

            do
            {
                acumulador += contador;
                contador++;
            } while (contador <= 5);
            Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador} ");*/

            char continuar;

            do
            {
                Console.Write("Digíte un número para ver su tabla de multiplicar: ");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nTabla de multiplicar del {numero}:");

                int contador = 1;

                do
                {
                    int acumulador = numero * contador;
                    Console.WriteLine($"{numero} x {contador} = {acumulador}");
                    contador++;
                } while (contador <= 10);
                Console.Write("\n¿Desea generar otra tabla? (S/N): ");
                continuar = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

            } while (continuar == 'S');

        }
   }
}
