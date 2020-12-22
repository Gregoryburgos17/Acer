using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduce 10  numeros y muestra cual mayor");
            int[]numeros=new int[10];
            int pocision=0,mayor=0;
            
            for (int i=0; i<numeros.Length; i++)
            {
                numeros[i] = 0;
                Console.Write("introduce  numero:N{0}: ",i);
                int.TryParse(Console.ReadLine(), out numeros[i]);
                
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i]>mayor)
                {
                    mayor = numeros[i];
                    pocision = i;
                }
       
            }
            Console.WriteLine("EL mayor numero es :{0} y posicion: {1}", mayor, pocision);

            Console.ReadKey();

        }
    }
}
