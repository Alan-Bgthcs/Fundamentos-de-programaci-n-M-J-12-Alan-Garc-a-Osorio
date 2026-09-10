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
                    Console.WriteLine("Operaciónfinalizada");
                }
                else if (respuesta == "Y")
                {   
                    repetir = true;
                }

            } while (repetir == true);
            promedio = acumulador / contador;
            Console.WriteLine($" Su promedio de notas es: {promedio}");*/

            //2.
            /*int contador = 1;
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
            }*/

            //3.
            /*bool repetir = true;

            do
            {
                Console.Write("Digite la base: ");
                int numbase = int.Parse(Console.ReadLine());

                Console.Write("Digite el exponente: ");
                int exponente = int.Parse(Console.ReadLine());

                int acumulador = 1;

                for (int i = 1; i <= exponente; i++)
                {
                    acumulador = acumulador * numbase;
                }

                Console.WriteLine($"El resultado de la exponenciación es: {acumulador}");

                Console.Write("¿Desea realizar otra potenciación? (S/N): ");
                string respuesta = Console.ReadLine();

                if (respuesta == "N")
                {
                    repetir = false;
                    Console.WriteLine("Operación finalizada");
                }
                else
                {
                    repetir = true;
                }

            } while (repetir == true);*/

            //4.
            int pruebas = 1;
            int promedio = 0;
            int acumulador = 0;
            bool cumpletime = true;
            bool cumplemenor = false;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite cuántos minutos ocupó en la prueba {pruebas}: ");
                int timetrial = int.Parse(Console.ReadLine());

                pruebas++;
                acumulador = acumulador + timetrial;

                if (timetrial > 20)
                {
                    cumpletime = false;
                }

                if (timetrial < 15)
                {
                    cumplemenor = true;
                }
            }

            promedio = acumulador / 10;

            if (promedio <= 18 && cumpletime == true && cumplemenor == true)
            {
                Console.WriteLine("Es apto para la competencia.");
            }
            else
            {
                Console.WriteLine("No es apto para la competencia.");
            }
        }
    }
}
