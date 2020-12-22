using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            Console.Clear();

            Console.WriteLine("Elija en programa a ejecutar:\b\n 1.-  En qué posición del vector está el mayor número leído. \b\n 2.- En qué posiciones se encuentran los números que comienzan en 4. \b\n 3.- Determinar cuántos números negativos hay\b\n 4.-  En qué posiciones están los números positivos. \b\n 5.- Cuál es el número menor.  \b\n 6.- Determinar si la semisuma entre el valor mayor y el valor menor es un número par \b\n 7.- Determinar si la semisuma entre el valor mayor y el valor menor es un número primo\b\n 8.- Cuántos números de los almacenados en dicho vector comienzan por 34. ");
            menu = int.Parse(Console.ReadLine());
            switch (menu)

            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Leer 10 enteros, almacenarlos en un vector y determinar en qué posición del vector está el mayor número leído");
                    int[] numero = new int[10];
                    for (int x = 0; x < numero.Length; x++)
                    {
                        numero[x] = 0;
                        Console.WriteLine("Digite un numero en la posicion{0}", x);
                        int.TryParse(Console.ReadLine(), out numero[x]);

                    }
                    int mayor = 0;
                    int posicion = 0;
                    for (int x = 0; x < numero.Length; x++)
                    {
                        if (numero[x] > mayor)
                        {
                            mayor = numero[x];
                            posicion = x;


                        }
                    }
                    Console.WriteLine("El mayor es{0} y esta en la posicion{1}", mayor, posicion);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Leer 10 números enteros, almacenarlos en un vector y determinar en qué posiciones se encuentran los números que comienzan en 4");
                    int[] num = new int[10];
                    for (int ll = 0; ll < num.Length; ll++)
                    {
                        num[ll] = 0;
                        Console.WriteLine("Digite un numero", ll);
                        int.TryParse(Console.ReadLine(), out num[ll]);




                    }
                    for (int ll = 0; ll < num.Length; ll++)
                    {
                        if (num[ll] / 10 == 4 || num[ll] / 1 == 4)
                        {
                            string t = num[ll].ToString();

                            Console.WriteLine("El {0}comienza en 4", t);
                        }


                    }
                    Console.Read();

                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Leer 10 números enteros, almacenarlos en un vector y determinar cuántos números negativos hay");
                    int[] nu = new int[10];
                    for (int a = 0; a < nu.Length; a++)
                    {
                        nu[a] = 0;
                        Console.WriteLine("Digite un numero", a);
                        int.TryParse(Console.ReadLine(), out nu[a]);




                    }
                    for (int a = 0; a < nu.Length; a++)
                    {
                        if (nu[a] < 0)
                        {
                            string t = nu[a].ToString();

                            Console.WriteLine("El {0} es negativo", t);
                        }


                    }
                    Console.Read();

                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Leer 10 números enteros, almacenarlos en un vector y determinar en qué posiciones están los números positivos");
                    int[] n = new int[10];
                    for (int m = 0; m < n.Length; m++)
                    {
                        n[m] = 0;
                        Console.WriteLine("Digite un numero", m);
                        int.TryParse(Console.ReadLine(), out n[m]);




                    }
                    for (int m = 0; m < n.Length; m++)
                    {
                        if (n[m] > 0)
                        {
                            string t = n[m].ToString();

                            Console.WriteLine("El {0}numero es positivo", t);
                        }



                    }
                    Console.ReadKey();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Leer 10 números enteros, almacenarlos en un vector y determinar cuál es el número menor");
                    int[] nm = new int[10];
                    for (int f = 0; f < nm.Length; f++)
                    {
                        nm[f] = 0;
                        Console.WriteLine("Digite un numero", f);
                        int.TryParse(Console.ReadLine(), out nm[f]);




                    }
                    for (int f = 0; f < nm.Length; f++)
                    {

                        if (nm[f] > 0)
                        {
                            string t = nm[f].ToString();

                            Console.WriteLine("El {0}numero es positivo", t);
                        }



                    }
                    Console.ReadKey();
                    break;
                case 6:
                    Console.Clear();

                    Console.WriteLine("Leer 10 números enteros, almacenarlos en un vector y determinar si la semisuma entre el valor mayor y el valor menor es un número par");
                    int i;
                    int[] n1 = new int[10];
                    int mayol = -1, indice = 0, semisuma = 0;


                    for (i = 0; i < n1.Length; i++)
                    {
                        Console.WriteLine("Digite un numero{0}", i);
                        int.TryParse(Console.ReadLine(), out n1[i]);
                    }
                    for (i = 0; i < n1.Length; i++)
                    {
                        Console.WriteLine(i + "  -  " + n1[i]);



                    }
                    for (i = 0; i < n1.Length; i++)
                    {
                        if (n1[i] > mayol)
                        {
                            mayol = n1[i];

                            indice = i;
                        }



                    }
                    Console.WriteLine("El mayor{0} y su posicion{1}", mayol, indice);
                    int j = 0;
                    int indice1 = 0;
                    int menor = n1[j];
                    for (j = 0; j < n1.Length; j++)
                    {
                        if (n1[j] < menor)
                        {
                            menor = n1[j];
                            indice1 = j;

                        }
                    }
                    Console.WriteLine("El menor{0} y su posicion{1}", menor, indice1);
                    semisuma = menor + mayol;
                    Console.WriteLine("La semisuma es:" + semisuma);
                    if (semisuma % 2 == 0)
                    {
                        Console.WriteLine("La semisuma es un nuemero par");
                    }
                    else
                    {
                        Console.WriteLine("La semisuma no es un nuemero par");
                    }


                    Console.ReadKey();


                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Leer 10 números enteros, almacenarlos en un vector y determinar si la semisuma entre el valor mayor y el valor menor es un número primo");
                    int l;
                    int[] n11 = new int[10];
                    int mayo = -1, indic = 0, semisum = 0;


                    for (l = 0; l < n11.Length; l++)
                    {
                        Console.WriteLine("Digite un numero{0}", l);
                        int.TryParse(Console.ReadLine(), out n11[l]);
                    }
                    for (l = 0; l < n11.Length; l++)
                    {
                        Console.WriteLine(l + "  -  " + n11[l]);



                    }
                    for (l = 0; l < n11.Length; l++)
                    {
                        if (n11[l] > mayo)
                        {
                            mayo = n11[l];

                            indic = l;
                        }



                    }
                    Console.WriteLine("El mayor{0} y su posicion{1}", mayo, indic);
                    int k = 0;
                    int indice2 = 0;
                    int meno = n11[k];
                    for (k = 0; k < n11.Length; k++)
                    {
                        if (n11[k] < meno)
                        {
                            meno = n11[k];
                            indice2 = k;

                        }
                    }
                    Console.WriteLine("El menor{0} y su posicion{1}", meno, indice2);
                    semisuma = meno + mayo;
                    Console.WriteLine("La semisuma es:" + semisum);
                    if (semisum % 1 == 0)
                    {
                        Console.WriteLine("La semisuma es un nuemero par");
                    }
                    else
                    {
                        Console.WriteLine("La semisuma no es un nuemero par");
                    }


                    Console.ReadKey();

                    break;

                case 8:
                    Console.Clear();
                    Console.Write("Leer 10 números enteros, almacenarlos en un vector y determinar cuántos números de los almacenados en dicho vector comienzan por 34");
                    int[] n2 = new int[10];
                    for (int lll = 0; lll < n2.Length; lll++)
                    {
                        n2[lll] = 0;
                        Console.WriteLine("Digite un numero", lll);
                        int.TryParse(Console.ReadLine(), out n2[lll]);




                    }
                    for (int lll = 0; lll < n2.Length; lll++)
                    {
                        if (n2[lll] / 10 == 34 || n2[lll] / 1 == 34)
                        {
                            string t = n2[lll].ToString();

                            Console.WriteLine("El {0}comienza en 34", t);
                        }


                    }
                    Console.Read();
                    break;




















            }
        }
    }
}
