using System;

namespace _3.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores numericos
            //incremento decremento
            int dato1 = 0;
            dato1++;//dato1 = dato1 + 1
            dato1--;//dato1 = dato1 - 1
            dato1 += 15; //dato1 = dato1 + 15
            dato1 -= 14; //dato1 = dato1 - 14
            dato1 *= 3; //dato1 = dato1 * 3
            dato1 /= 2; //dato1 = dato1 * 3
            dato1 *= dato1;

            // orden de evaluación
            int dato2 = 4 * 3 / 2;
            int dato3 = 5 / 2 * 4;
            int dato4 = 4 * (5 / 2);
            int dato5 = 3 - 1 * (4 / 2);
            Console.WriteLine(dato2);

            //operadores logicos
            // conjunción - And - Y - &&
            Console.WriteLine("Tabla de la Conjución");
            Console.WriteLine("V && V="+(true&&true));
            Console.WriteLine("V && F=" + (true && false));
            Console.WriteLine("F && V=" + (false && true));
            Console.WriteLine("F && F=" + (false && false));

            //disfunción - OR - O - ||
            Console.WriteLine("V || V=" + (true || true));
            Console.WriteLine("V || F=" + (true || false));
            Console.WriteLine("F || V=" + (false || true));
            Console.WriteLine("F || F=" + (false || false));

            //negación
            bool dato6 = true;
            bool dato7 = !dato6;

            //operadores de comparación
            bool dato8 = 5 > 4;
            bool dato9 = 1002 == 102;
            bool dato10 = 10 >= 9;
            bool dato11 = 0 != 1;
            bool dato12 = 4 < 5 && 3 == 0;
            bool dato13 = 0 != 2 && dato8 || dato9;

        }
    }
}
