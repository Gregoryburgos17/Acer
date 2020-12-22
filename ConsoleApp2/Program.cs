using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Friends");
            int edad = 0;
            

            for(int i = 0; i < 18;)
            {
                Console.WriteLine("registre su edad");
                edad  = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
