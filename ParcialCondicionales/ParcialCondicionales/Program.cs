using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Selecciona tu mes de nacimiento------------");
            Console.WriteLine(" 1. Enero                                    2. Febrero");
            Console.WriteLine(" 3. Marzo                                    4. Abril");
            Console.WriteLine(" 5. Mayo                                     6. Junio");
            Console.WriteLine(" 7. Julio                                    8. Agosto");
            Console.WriteLine(" 9. Septiembre                               10. Octubre (El mejor)");
            Console.WriteLine("11. Noviembre                                12. Diciembre");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Escribre el número correspondiente a tu mes de nacimiento");
            int Mes;
            Mes = int.Parse(Console.ReadLine());
            switch (Mes)
            {
                case 1:
                    Console.WriteLine("Seleccionaste Enero");
                    break;
                case 2:
                    Console.WriteLine("Seleccionaste Febrero");
                    break;
                case 3:
                    Console.WriteLine("Seleccionaste Marzo");
                    break;
                case 4:
                    Console.WriteLine("Seleccionaste Abril");
                    break;
                case 5:
                    Console.WriteLine("Seleccionaste Mayo");
                    break;
                case 6:
                    Console.WriteLine("Seleccionaste Junio");
                    break;
                case 7:
                    Console.WriteLine("Seleccionaste Julio");
                    break;
                case 8:
                    Console.WriteLine("Seleccionaste Agosto");
                    break;
                case 9:
                    Console.WriteLine("Seleccionaste Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Seleccionaste Octubre (GOAT)");
                    break;
                case 11:
                    Console.WriteLine("Seleccionaste Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Seleccionaste Diciembre");
                    break;
                default:
                    Console.WriteLine("No seleccionaste una opción valida");
                    break;
                   
            }
            int Zodiaco;
            Console.WriteLine("-----------Selecciona tu signo del Zodiaco---------");
            Console.WriteLine(" 1. Aries                                   2. Leo");
            Console.WriteLine(" 3. Sagitario                               4. Tauro");
            Console.WriteLine(" 5. Virgo                                   6. Capricornio");
            Console.WriteLine(" 7. Géminis                                 8. Libra");
            Console.WriteLine(" 9. Sagitario                               10. Cáncer");
            Console.WriteLine("11. Escorpión                               12. Piscis");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Escribre el número correspondiente a tu signo zodiacal");
            Zodiaco = int.Parse(Console.ReadLine());
            switch (Zodiaco)
            {
                case 1:
                    Console.WriteLine("Seleccionaste Aries");
                    break;
                case 2:
                    Console.WriteLine("Seleccionaste Leo");
                    break;
                case 3:
                    Console.WriteLine("Seleccionaste Sagitario");
                    break;
                case 4:
                    Console.WriteLine("Seleccionaste Tauro");
                    break;
                case 5:
                    Console.WriteLine("Seleccionaste Virgo");
                    break;
                case 6:
                    Console.WriteLine("Seleccionaste Capricornio");
                    break;
                case 7:
                    Console.WriteLine("Seleccionaste Géminis");
                    break;
                case 8:
                    Console.WriteLine("Seleccionaste Libra");
                    break;
                case 9:
                    Console.WriteLine("Seleccionaste Sagitario");
                    break;
                case 10:
                    Console.WriteLine("Seleccionaste Cáncer");
                    break;
                case 11:
                    Console.WriteLine("Seleccionaste Escorpión");
                    break;
                case 12:
                    Console.WriteLine("Seleccionaste Piscis");
                    break;
                default:
                    Console.WriteLine("No seleccionaste una opción valida");
                    break;

            }
            if ((Zodiaco == 1 || Zodiaco == 2 || Zodiaco == 3) && ( Mes == 3 || Mes == 4 || Mes == 7 || Mes == 8 || Mes == 11 || Mes == 12 ))
            {
                Console.WriteLine("Eres elemento Fuego");
            }
            else if ((Zodiaco == 4 || Zodiaco == 5 || Zodiaco == 6) && (Mes == 4 || Mes == 5 || Mes == 8 || Mes == 9 || Mes == 12 || Mes == 1))
            {
                Console.WriteLine("Eres elemento Tierra");
            }
            else if ((Zodiaco == 7 || Zodiaco == 8 || Zodiaco == 9) && (Mes == 5 || Mes == 6 || Mes == 9 || Mes == 10 || Mes == 1 || Mes == 2))
            {
                Console.WriteLine("Eres elemento Aire");
            }
            else if ((Zodiaco == 10 || Zodiaco == 11 || Zodiaco == 12) && (Mes == 3 || Mes == 6 || Mes == 7 || Mes == 10 || Mes == 11 || Mes == 2))
            {
                Console.WriteLine("Eres elemento Agua");
            }
            else
            {
                Console.WriteLine("El Mes y Signo Zodiacal no coinciden con ningún elemento");
            }
        }
    }
}