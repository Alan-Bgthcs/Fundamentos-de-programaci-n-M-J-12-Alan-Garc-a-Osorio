using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.EjercicioCicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dígite el número de inicio: ");
            int inicio = int.Parse(Console.ReadLine());

            Console.Write("Digíte el número de fin: ");
            int fin = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nLos múltiplos de 5 entre {inicio} y {fin} son:");

            for (int i = inicio; i <= fin; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
