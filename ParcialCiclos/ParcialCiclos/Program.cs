using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* El director del colegio “María Estévez” desea conocer información estadística sobre las edades de un grupo piloto de 15 estudiantes.
 Utilizando obligatoriamente una estructura repetitiva, el programa debe cumplir con las siguientes reglas:
 Ingreso y Validación de Datos: Solicita por teclado la edad de cada uno de los 15 estudiantes.El programa debe asegurar que solo se acepten los valores 4, 5 o 6.Si el usuario ingresa una edad inválida, el programa debe rechazarla, mostrar un mensaje de error y volver a pedirla para ese mismo estudiante(puedes usar un ciclo de validación).
 Cálculo de Promedio: Calcula el promedio de edad de todo el grupo de 15 alumnos.
 Conteo por Categoría: Cuenta y muestra de manera independiente cuántos estudiantes tienen 4 años, cuántos tienen 5 años y cuántos tienen 6 años.
 Análisis de Mayoría(Condicionales): Compara las cantidades obtenidas y muestra un mensaje especial en pantalla según el siguiente criterio:
             Si la cantidad de estudiantes de 6 años es estrictamente mayor que la de 4 y la de 5 años, mostrar: “Grupo mayor”.
 Si la cantidad de estudiantes de 4 años es estrictamente mayor que la de 5 y la de 6 años, mostrar: “Grupo menor”.
 Si ninguna de las dos anteriores se cumple(por ejemplo, si gana el de 5 años o hay un empate), mostrar: “Grupo equilibrado”.
 Reporte Final: Muestra claramente el promedio general de edad y los contadores finales de cada edad.
         }*/
            bool validacionedad = false;
            double acumuladoredad = 0;
            int edadvalida = 0;
            int contador6 = 0;
            int contador4 = 0;
            int contador5 = 0;
            double promedio = 0;
            for (int estudiantes = 1; estudiantes <= 15; estudiantes++)
            {
                do
                {
                    Console.WriteLine("Digíte su edad");
                    int edad = int.Parse(Console.ReadLine());
                    if (edad == 6 )
                    {
                        validacionedad = true;
                        edadvalida = edad;
                        contador6 ++;
                    }
                    else if (edad == 4)
                    {
                        validacionedad = true;
                        edadvalida = edad;
                        contador4++;
                    }
                    else if (edad == 5)
                    {
                        validacionedad = true;
                        edadvalida = edad;
                        contador5++;
                    }
                    else if (edad != 4 || edad != 5 || edad  != 6)
                    {
                        Console.WriteLine("Error, la deda debe estar entre 4 y 6 años");
                        validacionedad = false;
                    }

                } while (validacionedad == false);

                acumuladoredad = acumuladoredad + edadvalida;
            }
            
            if (contador6 > contador4 && contador6 > contador5)
            {
                Console.WriteLine("Grupo mayor");
            }
            else if (contador4 > contador6 && contador4 > contador5)
            {
                Console.WriteLine("Grupo menor");
            }
            else
            {
                Console.WriteLine("Grupo Equilibrado");
            }
            promedio = acumuladoredad / 15;
            Console.WriteLine($"El promedio de edad es: {promedio}");
            Console.WriteLine($"Hay {contador4} estudiantes con 4 años de edad\nHay {contador5} estudiantes con 5 años de edad\nHay {contador6} estudiantes con 6 años de edad\n");
        }
    }
}
