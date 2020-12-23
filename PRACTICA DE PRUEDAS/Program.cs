using System;

namespace PRACTICA_DE_PRUEDAS
{
    class Program
    {
         
       
        


        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("INTRODUSCA UN NUMERO DEL 1 A 20");
            n =int.Parse (Console.ReadLine());
            for (int i = n; i <= 20; i++)
            {

                int m = 0;
                Console.Clear();
                Console.WriteLine("cantidad de numero a introducir");
                m = int.Parse(Console.ReadLine());
                int[] numeros = new int[m];

                //Solicitamos al usuario los  valores 
                for (int p = 0; p < m; p++)
                {
                    Console.WriteLine("Ingrese un número:");
                    numeros[p] = int.Parse(Console.ReadLine());
                }

                //Ordenamos la lista e imprimimos los valores.
                Array.Sort(numeros);

                Console.WriteLine("\nLos números ordenados son:");

                for (int l = 0; l < m; l++)
                {
                    Console.WriteLine(numeros[l]);
                }
                Array.Reverse(numeros);

                Console.WriteLine("\nLos números ordenados son:");

                for (int k = 0; k < m; k++)
                {
                    Console.WriteLine(numeros[k]);
                }
                //Para mantener la consola abierta
                
                Console.ReadKey();





            }

        }

      
    }
}
