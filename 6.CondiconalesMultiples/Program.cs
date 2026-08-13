using System;

namespace _6.CondiconalesMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales múltiples
            //Crear un algoritmo que muestre por pantalla un menú con 5 opciones, y según la opción elegida del menú, muestre un mensaje por pantalla donde se muestre la opción elegida, en caso de que se seleccione una opción que no está en el menú mostrar un mensaje de error.

            int respuesta = 0;
            Console.WriteLine("----------Menú----------");
            Console.WriteLine("1. Opción 1  2. Opción 2");
            Console.WriteLine("3. Opción 3  4. Opción 4");
            Console.WriteLine("5. Opción 5");
            Console.WriteLine("------------------------");
            Console.WriteLine("Elija una opción del menú:");
            respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Eligió la opción 1");
                    break;
                case 2:
                    Console.WriteLine("Eligió la opción 2");
                    break;
                case 3:
                    Console.WriteLine("Eligió la opción 3");
                    break;
                case 4:
                    Console.WriteLine("Eligió la opción 4");
                    break;
                case 5:
                    Console.WriteLine("Eligió la opción 5");
                    break;
                default:
                    Console.WriteLine("Elija una opción valida");
                    break;
            }
        }
    }
}
