using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CiclosFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int acumulador = 0;

             for (int contador = 1; contador <= 5; contador++)
             {
                 acumulador += contador;
             }
             Console.WriteLine($"La suma de los cinco primeros números es: {acumulador}");*/

            //2.Algortimo que te permita pedirle un numero al usuario y calcular el factorial
            int numero = 0;
            int acumulador = 1;
            Console.WriteLine("Digíte un número para ver su factorial");
            numero=int.Parse(Console.ReadLine());
            for (int contador = 1; contador <= numero; contador++)
            {
                acumulador *= contador;
            }
            Console.WriteLine($"Su factorial es: {acumulador}");
        }
    }
}
