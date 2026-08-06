using System;

namespace _4.CondicionalesSimpleDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESTRUCTURAS DE CONTROL CONDICIONALES
            //Simples
            //1.    Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web"
            /*byte edad = 0;
            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToByte( Console.ReadLine() );

            if(edad >= 18)
            {
                //Si se cumple la condición
                Console.WriteLine("Bienvenido a mi sitio web");
            }*/

            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos.

         /*   string nombre;
            float sueldo;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo");
            sueldo = Convert.ToSingle(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine("Usted, " + nombre + " debe abonar impuestos para la gran nación colombiana");
            }*/

            //Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web". De lo contrario, mostrar el mensaje "No es apto para el contenido de este sitio web".
            byte edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToByte( Console.ReadLine() );
            if(edad >=18)
            {
                //Si se cumple la condición
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                //Si NO se cumple la condición
                Console.WriteLine("No es apto para el contenido de este sitio web");
            }
           
        }
    }
}
