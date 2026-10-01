using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de Fundamentos de Programación");
            MostrarMensaje("Alan");
            MostrarMensaje("Alan", "García Osorio");
            Console.ReadKey();
            Console.WriteLine($"Alan tiene {CalcularEdad()}");
            Console.WriteLine($"Alan tiene {CalcularEdad(2026, 2009)}");
        }

        //Funciones sin parámetros
        static int CalcularEdad()
        {
            int añonacimiento = 2009;
            int añoactual = 2026;
            int edad = añoactual - añonacimiento;
            return edad;
        }

        //Funciones con parámetros
        static int CalcularEdad(int añoactual, int añonacimiento)
        {
            return añoactual - añonacimiento;
        }

        //
        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso de Fundamentos de Programación");
        }
        static void MostrarMensaje(string nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido, {nombre} {apellidos} al curso de Fundamentos de Programación");
        }
    }
}
