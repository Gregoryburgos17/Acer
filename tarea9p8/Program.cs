using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea9p8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int contador=0, num=0;
            for (int i=0; i<numeros.Length; i++)
            {
                Console.WriteLine("Digite numero " + i);
                numeros[i] = Convert.ToInt32(Console.ReadLine());

            }


            foreach (int nums in numeros)
            {
                num=nums;
                while ( num> 10)
                {
                   num  =num  / 10;

                }
                if ( num== 4)
                {
                    contador++;
                }
            }
            Console.Write("EL NUMERO 4 SE REPITE{0}", contador);
        }
    }
}
