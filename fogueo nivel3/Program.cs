using System;
using System.Linq;

namespace fogueo_nivel3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digito = new int[10];
            int V, max = digito[0], min = digito[0];
            int suma;
            suma = 0;
            for (int f=0; f<10; f++)
            {
                Console.Write("ingrese digitos:");
                string linea = Console.ReadLine();
                V = int.Parse(linea);
                digito[f] = V;
            }
            Console.WriteLine("la sumatoria es:" + suma);
            int n = 0;
            
            Console.Write("\n\n  El mayor numero es: " + digito.Max());
            Console.Write("\n\n El menor numero es: " + digito.Min());


            Console.ReadKey();

        }
    }
}
