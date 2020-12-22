using System;

namespace ejercios_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string
                nombre;

            Console.WriteLine("INGRESA TU NOMBRE ");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("INGRESA TU  EDAD ");
            int edad = int.Parse(Console.ReadLine());
            if (edad>18)
            {
                for (int num = edad; num != 0; num--)
                {
                    Console.WriteLine("Estudia Software en ITLA");
                }
            }
            else
            {
                for (int error = 0; error != 5; error++)
                {
                    Console.WriteLine("Estudia Software en ITLA");
                }
            }
            Console.ReadKey();

        }
    }
}
