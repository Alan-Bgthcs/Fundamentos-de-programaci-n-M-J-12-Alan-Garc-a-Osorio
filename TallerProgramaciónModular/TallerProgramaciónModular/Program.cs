using System;

namespace TallerProgramaciónModular
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("--- Convertir Unidades ---");
            Console.WriteLine("1. Masa        2. Capacidad");
            Console.WriteLine("3. Longitud    4. Tiempo");
            Console.Write("Elija el tipo de unidad: ");
            string tipo = Console.ReadLine();

            switch (tipo)
            {
                case "1":
                    ProcesarMasa();
                    break;

                case "2":
                    ProcesarCapacidad();
                    break;

                case "3":
                    ProcesarLongitud();
                    break;

                case "4":
                    ProcesarTiempo();
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }


        static void ProcesarMasa()
        {
            Console.WriteLine("1. De kilogramos a gramos      2. De gramos a kilogramos");
            string opc = Console.ReadLine();
            Console.Write("Ingrese el valor a convertir: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            if (opc == "1")
                Console.WriteLine($"{valor} kilogramos son {valor * 1000} gramos.");
            else if (opc == "2")
                Console.WriteLine($"{valor} gramos son {valor / 1000} kilogramos.");
        }

        static void ProcesarCapacidad()
        {
            Console.WriteLine("1. De litro a mililitro      2. De mililitro a litro");
            string opc = Console.ReadLine();
            Console.Write("Ingrese el valor a convertir: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            if (opc == "1")
                Console.WriteLine($"{valor} litros son {valor * 1000} mililitros.");
            else if (opc == "2")
                Console.WriteLine($"{valor} mililitros son {valor / 1000} litros.");
        }

        static void ProcesarLongitud()
        {
            Console.WriteLine("1. De kilómetro a metro      2. De metro a kilómetro");
            string opc = Console.ReadLine();
            Console.Write("Ingrese el valor a convertir: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            if (opc == "1")
                Console.WriteLine($"{valor} kilómetros son {valor * 1000} metros.");
            else if (opc == "2")
                Console.WriteLine($"{valor} metros son {valor / 1000} kilómetros.");
        }

        static void ProcesarTiempo()
        {
            Console.WriteLine("1. De hora a segundos      2. De segundos a hora");
            string opc = Console.ReadLine();
            Console.Write("Ingrese el valor a convertir: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            if (opc == "1")
                Console.WriteLine($"{valor} horas son {valor * 3600} segundos.");
            else if (opc == "2")
                Console.WriteLine($"{valor} segundos son {valor / 3600} horas.");
        }
    }
}
