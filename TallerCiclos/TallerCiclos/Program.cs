using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.
            double calificación = 0;
            int contador = 0;
            double acumulador = 0;
            bool repetir = true;
            double promedio = 0;
            do
            {
                Console.WriteLine("digíte su calificación");
                calificación = double.Parse(Console.ReadLine());
                contador++;
                acumulador = acumulador + calificación;
                Console.WriteLine("¿Desea ingresar otra calificación? Y/N");
                string respuesta = Console.ReadLine();
                if (respuesta == "N")
                {
                    repetir = false;
                    Console.WriteLine("Consulta finalizada");
                }
                else if (respuesta == "Y")
                {   
                    repetir = true;
                }

            } while (repetir == true);
            promedio = acumulador / contador;
            Console.WriteLine($" Su promedio de notas es: {promedio}");*/

            //2.
            int contador = 1; 
            Console.Write("Dígite un número para ver sus divisores: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nLos divisores de {num} son:");

            for (int i = num; i == num;)
            {
                if (i % contador == 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }
        }
    }
}
