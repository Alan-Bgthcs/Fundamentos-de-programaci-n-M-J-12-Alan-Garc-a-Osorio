using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperaciones(CapturarOpcion());
            
        }

        static float Division()
        {
            Console.WriteLine("Ingrese el numero 1");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 / numero2;
        }

        static float Resta()
        {
            Console.WriteLine("Ingrese el numero 1");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 - numero2; 
        }
        static float Multiplicacion()
        {
            float numero = 0;
            float multiplicacion = 1;
            char respuesta = ' ';
            do
            {
                Console.WriteLine("Ingrese un número");
                numero = int.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("Deseas multiplicar más numeros, s para continuar");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return multiplicacion;
        }

        static float Suma()
        {
            float numero = 0;
            float suma = 0;
            char respuesta = ' ';
            do
            {
                Console.WriteLine("Ingrese un número");
                numero = int.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Deseas sumar más numeros, s para continuar");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return suma;
        }
        static void RealizarOperaciones (int opcion)
        {
            while (opcion != 0)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"SUMA es: {Suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"RESTA es: {Resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"MULTIPLICACIÓN es: {Multiplicacion()}");
                        break;
                    case 4:
                        Console.WriteLine($"DIVISIÓN es: {Division()}");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                MostrarMenu();
                opcion = CapturarOpcion();
            }
        }

        static int CapturarOpcion()
        {
            return int.Parse(Console.ReadLine());
        }

        static void MostrarMenu ()
        {
            Console.WriteLine("-------------MENÚ--------------");
            Console.WriteLine("1.Suma                  2.Resta");
            Console.WriteLine("3.Multiplicación     4.División");
            Console.WriteLine("5.Salir");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Seleccione una opción del menú");
        }
    }
}
