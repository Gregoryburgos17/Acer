using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea09p6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer dos números enteros y almacenar en un vector los 10 primeros números primos comprendidos entre el menor y el mayor.
            float[] num = new float[10];
            float mayor = 0, menor = 0;
            int flag = 0;
            
            for (int x = 0; x < 10; x++)
            {
                    Console.Write("Ingrese {0}º número:", x + 1);
                    num[x] = float.Parse(Console.ReadLine());

                    if (flag == 0)
                    {
                        mayor = num[x];
                        menor = num[x];
                        flag = 1;
                    }
                    else
                    {
                        if (num[x] > mayor)
                            mayor = num[x];
                        if (num[x] < menor)
                            menor = num[x];
                    }

            }
                if (mayor == menor)
                    Console.Write("\nLos números son todos iguales\n");
                else
                    Console.Write("\nEl menor de los 10 números es el {0} y el mayor es el {1}", menor, mayor);

                Console.Read();
            

            
           
           
            
            
               

        }
    }
}
