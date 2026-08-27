using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int SumaEnteros = 0;

            Console.WriteLine("ingrese un número positivo para sumar");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                SumaEnteros += numero;
                Console.WriteLine("ingrese un número positivo para sumar");
                numero = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("La suma de los numeros ingresados es" + SumaEnteros);
        }
    }
}
