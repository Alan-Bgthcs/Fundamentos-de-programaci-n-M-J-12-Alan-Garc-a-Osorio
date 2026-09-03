using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.OtroEjercicioDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente:
            //1.Si el saldo es mayor o igual a 3'000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y "Es apto para el credito"
            //2.Si el saldo es menor a 3'000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y "No es apto para el crédito"
            //El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no desea preguntar más.Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos.
            string nombre;
            int cuenta = 0;
            int saldo = 0;
            int contador = 0;
            int acumulador = 0;
            bool repetir = true;
            int promedio = 0;
            do
            {
                Console.WriteLine("digíte su nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("digíte el número de cuenta");
                cuenta = int.Parse(Console.ReadLine());
                Console.WriteLine("digíte su saldo");
                saldo = int.Parse(Console.ReadLine());
                if (saldo >= 3000000)
                {
                    Console.WriteLine($"{nombre}, cuyo número de cuenta es {cuenta}, y un saldo de {saldo} es apto para el crédito");
                }
                else
                {
                    Console.WriteLine($"{nombre}, cuyo número de cuenta es {cuenta}, y con saldo {saldo} no es apto para el crédito");
                }
                contador++;
                acumulador = acumulador + saldo;
                Console.WriteLine("¿Ingresar otro usuario para el prestamo? Y/N");
                string respuesta = Console.ReadLine()?.Trim().ToUpper();
                if ( respuesta == "N" )
                {
                    repetir = false;
                    Console.WriteLine("Consulta finalizada");
                }
                else if (respuesta == "Y" )
                {
                    repetir = true;
                }

            } while (repetir == true);
            promedio = acumulador / contador;
            Console.WriteLine($" {contador} usuarios consultaron un crédito, y el promedio de sus salarios es de: {promedio}.");
        }
    }
}
