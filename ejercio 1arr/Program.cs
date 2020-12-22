using System;

namespace ejercio_1arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
           

            for (int i=0; i<10; i++)
            {
                Console.WriteLine("inserte numero");
                Console.ReadLine();
            }
            foreach(int item in arr)
            {
                Console.WriteLine("numero 1");
                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
