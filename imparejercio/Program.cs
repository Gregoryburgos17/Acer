using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imparejercio
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            Console.WriteLine("\b\nOpcion: ");
            op = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (op)
            {
                case 9:
                    int[] arr2 = new int[10];
                    int m2 = 0;
                    Console.WriteLine("Ingrese 10 numeros enteros:");
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        Console.WriteLine("Numero " + (i + 1) + ":");
                        arr2[i] = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        m2 += arr2[i];
                    }
                    m2 = m2 / arr2.Length;
                    Console.Clear();
                    Console.WriteLine("El con mas de 3 digitos es : " + m2);
                    Console.ReadKey();


                    break;
                case 11:
                    int[] arr = new int[10];
                    int m = 0;
                    int p = 0;
                    Console.WriteLine("Ingrese 10 numeros enteros:");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine("Numero " + (i + 1) + ":");
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < arr.Length; i++)
                    {
                        m += arr[i];
                    }
                    m = m / arr.Length;
                    Console.Clear();
                    Console.WriteLine("El promedio entero es: " + m);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == m)
                        {
                            p++;
                        }
                    }
                    break;
                case 13:
                    string[] arr3 = new string[10];
                    int[] arr4 = new int[10];
                    int m1= 0;
                    Console.WriteLine("Ingrese 10 numeros enteros:");
                    for (int i = 0; i < arr3.Length; i++)
                    {
                        Console.WriteLine("Numero " + (i + 1) + ":");
                        arr3[i] = Console.ReadLine();
                        if (arr3[i].Length >= 3)
                        {
                            arr4[m1] = i;
                            m1++;
                        }
                    }
                    Array.Resize(ref arr4, m1);
                    Console.Clear();
                    Console.WriteLine("Posiciones de Numeros con mas de 3 digitos leidos: ");
                    for (int i = 0; i < arr4.Length; i++)
                    {
                        Console.WriteLine(arr4[i]);
                    }
                    Console.ReadKey();
                    break;
                case 15:
                    int[] arr5 = new int[10];
                    int[] arr6 = new int[10];
                    int m3 = 0;
                    Console.WriteLine("Ingrese 10 numeros enteros:");
                    for (int i = 0; i < arr5.Length; i++)
                    {
                        Console.WriteLine("Numero " + (i + 1) + ":");
                        arr5[i] = int.Parse(Console.ReadLine());
                        if (arr5[i] % 3 == 0)
                        {
                            arr6[m3] = arr5[i];
                            m3++;
                        }
                    }
                    Array.Resize(ref arr6, m3);
                    Console.Clear();
                    Console.WriteLine("Numeros multiplos de 3: ");
                    for (int i = 0; i < arr6.Length; i++)
                    {
                        Console.WriteLine(arr6[i]);
                    }
                    Console.ReadKey();
                    break;
                case 17:
                    int[] arr7 = new int[10];
                    int[] arr8 = new int[10];
                    int m4 = 0;
                    Console.WriteLine("Ingrese 10 numeros enteros:");
                    for (int i = 0; i < arr7.Length; i++)
                    {
                        Console.WriteLine("Numero " + (i + 1) + ":");
                        arr7[i] = int.Parse(Console.ReadLine());
                        if (arr7[i] > 0)
                        {
                            arr8[m4] = i;
                            m4++;
                        }
                    }
                    Array.Resize(ref arr8, m4);
                    Console.Clear();
                    Console.WriteLine("Posiciones de numeros positivos: ");
                    for (int i = 0; i < arr8.Length; i++)
                    {
                        Console.WriteLine(arr8[i]);
                    }
                    Console.ReadKey();
            

                       break;
                case 19:
                    int[] arr9 = new int[10];
                    int pos = 0; int contp = 0; int n= 0;

                    Console.WriteLine("Ingrese 10 numeros enteros:");
                    for (int i = 0; i < arr9.Length; i++)
                    {
                        Console.WriteLine("Numero " + (i + 1) + ":");
                        arr9[i] = int.Parse(Console.ReadLine());
                        for (int u = 1; u < (arr9[i] + 1); u++)
                        {
                            if (arr9[i] % u == 0)
                            {
                                if (arr9[i] > arr9[pos])
                                {
                                    pos = i;
                                }
                                contp++;
                            }
                        }
                        if (contp == 2)
                        {
                            if (arr9[i] < arr9[n])
                            {
                                n = i;
                            }
                        }
                        contp = 0;
                    }
                    Console.Clear();
                    Console.WriteLine("El numero primo menor esta en la posicion: " + n);
                    Console.ReadKey();
                    break;




                    //17. Leer 10 números enteros, almacenarlos en un vector y determinar cuántos números negativos hay. 
                    //19. Leer 10 números enteros, almacenarlos en un vector y determinar cuál es el número menor. 

            }
        }
    }
                  
}
