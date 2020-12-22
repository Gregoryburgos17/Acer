using System;

namespace estudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese numero: ");
            num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("Error");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Numero correcto, la secuencia es: ");
                for (int i=1; i <= num; i++)
                {
                    Console.WriteLine(i);
                   
                }
            }




       
        }
    }
}
