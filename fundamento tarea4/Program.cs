using System;

namespace fundamento_tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cateto1=0;
            int cateto2=0;
            
            Console.WriteLine("introduce cateto");
            Console.WriteLine("cateto 1");
            cateto1 = int.Parse(Console.ReadLine());
            Console.WriteLine("cateto 2");
            cateto2 = int.Parse(Console.ReadLine());
            double hipotenusa = Math.Sqrt((cateto1*cateto1) +( cateto2*cateto2));
            Console.WriteLine("la hipotenusa es  "+ hipotenusa);
            Console.ReadKey();
        }
    }
}
