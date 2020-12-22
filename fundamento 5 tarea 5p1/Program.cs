
using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace fundamento_5_tarea_5p1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Programa que acepte numeros separados por comas y que luego muestre separtados por guion de menor a mayor\n");

            Console.Write("cual es la cantidad de valores a introducir ");
            int vE = int.Parse(Console.ReadLine());
            int Ev2;
            string elemento;
            string[] arreglo;


            Console.Write("\nIntroduzca los valores: ");
            elemento = Console.ReadLine();
            arreglo = elemento.Split(',','.');
            int[] arregloentero = new int[arreglo.Length];


            ////Usamos el metodo de ordenamiento burbuja
            for (int m = 0; m < arreglo.Length; m++)
            {
                arregloentero[m] = int.Parse(arreglo[m]);
            }
            for (int i = 0; i < vE - 1; i++)
            {
                for (int k = 0; k < arregloentero.Length - 1; k++)
                {
                    if (arregloentero[k] < arregloentero[k + 1])
                    {
                        Ev2 = arregloentero[k];
                        arregloentero[k] = arregloentero[k + 1];
                        arregloentero[k + 1] = Ev2;
                    }
                }
            }
           
            Console.Write("Los ordenados de mayor a menor son: ");
           
            //esta es la parte que tenias que arreglar

            for (int N = 0; N < vE; N++)
            {
                Array.Sort(arreglo);
               
            }
            var all = String.Join("-", arreglo);
            Console.WriteLine(all);
            Console.ReadKey();


        }
        
        
        

    }
}
