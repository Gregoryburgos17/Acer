using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea9p4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 0;
            b = 1;
            c = 2;
            int[] num = {0,1,1,2,3,5,8,13,21,34 };
            
                Console.WriteLine("Cargar un vector de 10 posiciones con los 10 primeros elementos de la serie de Fibonacci ");
                
                Console.Write("\nel valor 1 del numero es "+a);
                Console.Write("\nel valor  2 del numero es "+ b);
                Console.Write("\nel valor  3 del numero es "+ c);
            for (int i = 4; i < num.Length; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.WriteLine("\nel valor es: " + i + "es igual a: " + c);
            }

            Console.ReadKey();
        }

    }
    

}
