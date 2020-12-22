using System;

namespace ConsoleApp1
{
    class Program
    {
        private static int resultado;

        static void Main(string[] args)
        {

            int num1, num2, num3 = 0;

            Console.Write("ingrese valor 1:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingrese valor 2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingrese valor 3:");
            num3 = Convert.ToInt32(Console.ReadLine());

            resultado = (num1 + num2 + num3) / 2;
            Console.WriteLine("Resoltado es:" + " "+ +resultado );
            Console.ReadKey();









        }
    }
}
