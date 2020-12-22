using System;

namespace CURSO1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr= new int [3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("inserte valor");
                arr[i] = int.Parse(Console.ReadLine());
            }
            //para mas facil foreach (var item in arr ) { console.write line(item);} //
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[2]);

            Console.WriteLine();

            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr[0]);

        }
    }
}
