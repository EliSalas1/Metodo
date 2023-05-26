using POO_METODOOOS.Clases;
using System;

namespace POO_METODOOOS
{
    internal class Program
    {

       
        static void Main(string[] args)
        {
            Funciones funciones = new Funciones();  // Aqui manda a llamar 
            Console.WriteLine("Dame un primer numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame un segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame un tercer numero");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame un cuarto numero");
            int num4 = int.Parse(Console.ReadLine());

            int resultado = funciones.Suma(num1, num2, num3, num4);
            Console.WriteLine(resultado);

            //Console.WriteLine(funciones.Suma(10, 5, 8, 7));

            funciones.Resta();

        }
    }
}
