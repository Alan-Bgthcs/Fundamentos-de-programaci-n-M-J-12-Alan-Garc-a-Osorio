using System;

namespace _5.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales Anidados
            //Diseñar algoritmo que lea tres números A, B, C  y visualice en pantalla el valor más grande. El usuario debe ingresar tres valores diferentes.
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Por favor, ingrese 3 valores diferentes para saber cuál es el mayor");
            Console.WriteLine("ingrese el valor del número 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del número 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del número 3");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                //Verdadera
                if (num1 > num3)
                {
                    Console.WriteLine("El número 1 es el mayor");
                }
                else
                {
                    Console.WriteLine("El número 3 es el mayor");
                }
            }
            else
            {
                //Falsa
                if (num2 > num3)
                {
                    Console.WriteLine("El número 2 es el mayor");
                }
                else
                {
                    Console.WriteLine("El número 3 es el mayor");
                }
            }
        }
    }
}