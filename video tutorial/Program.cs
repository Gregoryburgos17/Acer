using System;

namespace video_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("introduce un numero del 1 a 20");
            n = int.Parse(Console.ReadLine());
            for (int i = 20; n < i; i++)
            {
                int m = 0;
                Console.WriteLine("introdusca la cantida de valores");
                m = int.Parse(Console.ReadLine());
                int[] numeros = new int[m];
                for(int p=0; p<m; p++)
                {
                    Console.WriteLine("ingrese valor numerico");
                    numeros[p] = int.Parse(Console.ReadLine());
                }
                Array.Sort(numeros);
                Console.WriteLine("\nlos numeros de mayor a menor son:");
                for(int l=0; l<m; l++)
                {
                    Console.WriteLine(numeros[l]);
                }
                Array.Reverse(numeros);
                Console.WriteLine("\nlos numeros de   menor a mayor son:");
                for (int l = 0; l < m; l++)
                {
                    Console.WriteLine(numeros[l]);
                }

                Console.ReadKey();




            }
        }
    }
}
