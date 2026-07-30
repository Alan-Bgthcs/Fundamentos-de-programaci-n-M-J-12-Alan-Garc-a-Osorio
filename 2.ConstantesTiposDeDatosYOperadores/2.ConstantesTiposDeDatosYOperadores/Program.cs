using System;
using System.Data.SqlTypes;

namespace _2.ConstantesTiposDeDatosYOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constantes
            const string gravedad = "9.8";
            string nombre = "Alan";
            nombre = "Big";
            //gravedad= "10"; no se puede cambiar el valor de una variable

            //tipos de datos
            byte dato1 = 8;
            int dato2 = -2048; 
            ulong dato3 = 1234567890;
            float dato4 = 6.7f; 
            double dato5 = 1223812.36d; 
            decimal dato6 = 1.241521536465125m; 
            
            char dato7 = 'β'; 
            string dato8 = "dato88Ø bienvenido agente P"; 
            bool dato9 = true; //true or false
            object dato10 = new object();

            //operadores
            //operadores numéricos
            //cambio de signo
            int dato11 = 5;
            int dato12 = -dato11;
            int dato13 = +dato12;
            int dato14 = -dato13;
            Console.WriteLine("dato11: {0}, dato12: {1}, dato13: {2}, dsto14: {3}", dato11, dato12, dato13, dato14);
            int dato15 = 5 + 3; //suma
            int dato16 = dato15 - 2; //resta
            int dato17 = 25 * 3; // producto
            float dato18 = (float) 5 / 3;//división
            Console.WriteLine("Suma: {0}, Resta: {1}, producto: {2}, división: {3}", dato15, dato16, dato17, dato18);
        }
    }
}
