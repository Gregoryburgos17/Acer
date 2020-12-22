using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matricula20186730tarea9C
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0; int op2 = 0;
         Inicio:
            do
            {
                Console.Clear();
                WL("BIENVENIDO al los ejercios del libro de la logica cap9 \b\nSeleccione el ejercio que  desee: \b\n\b\n[1] ejercio 2  \b\n[2] Ejercio 4 " +
                    "\b\n[3] ejercio 6 \b\n[4] ejercio 8 \b\n[5] ejercio 10 " +
                    "\b\n[6] ejercio 12 \b\n[7] ejercio 14  \b\n[8] ejercio 16  \b\n[9] ejercio 18" +
                    "\b\n[10] ejercio 20 \b\n[11] ejercio 22  \b\n[12] ejercio 24\b\n[13] ejercio 26" +
                    "\b\n[14] ejercio 28 \b\n[15] ejercio 30" +
                    " \b\n[16]ejercio 32 \b\n[17] ejercio 34" +
                    "\b\n[18] ejercio 36 \b\n[19] ejercio 38 \b\n[20] ejercio 40" +
                    "\b\n[21] ejercio 42 \b\n[22]ejercio 44" +
                    "\b\n[23]ejercio 46  \b\n[24]ejercio 48 \b\n[25]ejercio 50 wii" +
                    "\b\n[26] acerca\n[27]salir");
                Write("\b\nOpcion: ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Ejercicio2();
                        Console.Clear();
                        WL("Determinar en que posicion esta el mayor numero par leido");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 1;
                        }
                        break;
                    case 2:
                        Ejercicio4();
                        Console.Clear();
                        WL("10 primeros numeros de la Serie Fibonacci");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 2;
                        }
                        break;
                    case 3:
                        Ejercicio6();
                        Console.Clear();
                        WL("10 primeros numeros primos comprendidos entre el menor y el mayor ");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 3;
                        }
                        break;
                    case 4:
                        Ejercicio8();
                        Console.Clear();
                        WL("Posiciones de numeros terminados en 4");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 4;
                        }
                        break;
                    case 5:
                        Ejercicio10();
                        Console.Clear();
                        WL("Posiciones de numeros con mas de 3 digitos");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 5;
                        }
                        break;
                    case 6:
                        Ejercicio12();
                        Console.Clear();
                        WL(" Promedio de 10 numeros enteros ");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 6;
                        }
                        break;
                    case 7:
                        Ejercicio14();
                        Console.Clear();
                        WL("Determinar cuantas veces se repite el promedio entero");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 7;
                        }
                        break;
                    case 8:
                        Ejercicio16();
                        Console.Clear();
                        WL("Determinar multiplos de 3");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 8;
                        }
                        break;
                    case 9:
                        Ejercicio18();
                        Console.Clear();
                        WL(" Posiciones de numeros positivos");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 9;
                        }
                        break;
                    case 10:
                        Ejercicio20();
                        Console.Clear();
                        WL("Determinar la posicion del menor numero primo ");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 10;
                        }
                        break;
                    case 11:
                        Ejercicio22();
                        Console.Clear();
                        WL("Determinar numeros multiplos de 5 y sus posiciones");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 11;
                        }
                        break;
                    case 12:
                        Ejercicio24();
                        Console.Clear();
                        WL("Determinar el numero con mas digitos");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 12;
                        }
                        break;
                    case 13:
                        Ejercicio26();
                        Console.Clear();
                        WL("Calcular Factorial");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 13;
                        }
                        break;
                    case 14:
                        Ejercicio28();
                        Console.Clear();
                        WL("Enteros comprendidos entre 1 y cada numero leido ");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 14;
                        }
                        break;
                    case 15:
                        Ejercicio30();
                        Console.Clear();
                        WL("Determinar si un numero entero se encuentra entre los 10 anteriores");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 15;
                        }
                        break;
                    case 16:
                        Ejercicio32();
                        Console.Clear();
                        WL("Determinar cuántos números de los 10 anteriores terminan en el mismo dígito que el último valor leido");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 16;
                        }
                        break;
                    case 17:
                        Ejercicio34();
                        Console.Clear();
                        WL("Determinar cuantas veces se encuentra el digito 2");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 17;
                        }
                        break;
                    case 18:
                        Ejercicio36();
                        Console.Clear();
                        WL("Determinar cuantos digitos primos hay");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 18;
                        }
                        break;
                    case 19:
                        Ejercicio38();
                        Console.Clear();
                        WL("Determinar si la semisuma entre el valor mayor y el valor menor es primo ");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 19;
                        }
                        break;
                    case 20:
                        Ejercicio40();
                        Console.Clear();
                        WL("Determinar cuantos numeros terminan en 15");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 20;
                        }
                        break;
                    case 21:
                        Ejercicio42();
                        Console.Clear();
                        WL("Determinar cuantos numeros con cantidad par de digitos pares hay");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 21;
                        }
                        break;
                    case 22:
                        Ejercicio44();
                        Console.Clear();
                        WL(" Determinar si los numeros ingresados pertenecen a los 100 primeros elementos de la Serie de Fibonacci");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 22;
                        }
                        break;
                    case 23:
                        Ejercicio46();
                        Console.Clear();
                        WL("Determinar cuantos numeros son primos y comienzan por 5");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 23;
                        }
                        break;
                    case 24:
                        Ejercicio48();
                        Console.Clear();
                        WL("Determinar en que posicion se encuentra el numero primo con mayor cantidad de digitos pares");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 24;
                        }
                        break;
                    case 25:
                        Ejercicio50();
                        Console.Clear();
                        WL("Determinar cuantos numeros comienzan con digito primo");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 25;
                        }
                        break;
                    case 26:Console.WriteLine("aqui para junte todos los programas para no tener que mandar muchos programas por separados bueno  en caso de que no se pueda me los mando individual"); 
                        break;
                    case 27:
                        break;
                    default:
                        Console.Clear();
                        WL("Error, ingrese una opcion valida...");
                        Console.ReadKey();
                        goto Inicio;
                }

            } while (op != 26);
        }
        static void Write(string str)
        {
            Console.Write(str);
        }
        //igual que el metodo leer funciona igual lo unico que los simplifica el console.writeline
        static void WL(string str)
        {
            Console.WriteLine(str);
        }
        static void Ejercicio2()
        {
            int[] arr = new int[10];
            int m = 0;
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 2 == 0 && arr[i] > m)
                {
                    m = arr[i];
                }
            }
            Console.Clear();
            WL("El numero mayor par leido es: " + m);
            Console.ReadKey();
        }
        static void Ejercicio4()
        {
            int[] arr = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            WL("Sucesion de Fibonacci\b\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
        static void Ejercicio6()
        {
            int[] arr = new int[10];
            int[] arr2 = new int[10];
            int[] primo = new int[10];
            int num1, num2; int pos = 0; int pow1 = 10; int pow2 = 10; int cont = 0; int contp = 0;
            Console.Write("Ingrese su primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            string str1 = Convert.ToString(num1);
            string str2 = Convert.ToString(num2);

            for (int i = 0; i < str1.Length; i++) //Primer numero
            {
                arr[i] = ((num1 % pow1) / (pow2 / 10));
                for (int u = 1; u < (arr[i] + 1); u++)
                {
                    if (arr[i] % u == 0)
                    {
                        if (arr[i] > arr[pos])
                        {
                            pos = i;
                        }
                        contp++;
                    }
                }
                if (contp == 2)
                {
                    if (cont < 10)
                    {
                        primo[cont] = arr[i];
                        cont++;
                    }
                }
                contp = 0;
                pow1 *= 10;
                pow2 *= 10;
            }
            pow1 = 10; pow2 = 10;
            for (int i = 0; i < str2.Length; i++) //Segundo numero
            {
                arr2[i] = ((num1 % pow1) / (pow2 / 10));
                for (int u = 1; u < (arr[i] + 1); u++)
                {
                    if (arr2[i] % u == 0)
                    {
                        if (arr2[i] > arr2[pos])
                        {
                            pos = i;
                        }
                        contp++;
                    }
                }
                if (contp == 2)
                {
                    if (cont < 10)
                    {
                        primo[cont] = arr[i];
                        cont++;
                    }
                }
                contp = 0;
                pow1 *= 10;
                pow2 *= 10;
            }
            Array.Sort(primo);
            Console.Clear();
            WL("Numeros primos: ");
            for (int i = 0; i < primo.Length; i++)
            {
                Console.WriteLine(primo[i]);
            }
            Console.ReadKey();
        }
        static void Ejercicio8()
        {
            int[] arr = new int[10];
            int[] arr2 = new int[10];
            int m = 0;
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 10 == 4)
                {
                    arr2[m] = i;
                    m++;
                }
            }
            Array.Resize(ref arr2, m);
            Console.Clear();
            WL("Posiciones de numeros terminados en 4: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.ReadKey();
        }
        static void Ejercicio10()
        {
            string[] arr = new string[10];
            int[] arr2 = new int[10];
            int m = 0;
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = Console.ReadLine();
                if (arr[i].Length >= 3)
                {
                    arr2[m] = i;
                    m++;
                }
            }
            Array.Resize(ref arr2, m);
            Console.Clear();
            WL("Posiciones de Numeros con mas de 3 digitos leidos: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.ReadKey();
        }
        static void Ejercicio12()
        {
            int[] arr = new int[10];
            int m = 0;
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                m += arr[i];
            }
            m = m / arr.Length;
            Console.Clear();
            WL("El promedio entero: " + m);
            Console.ReadKey();
        }
        static void Ejercicio14()
        {
            int[] arr = new int[10];
            int m = 0;
            int p = 0;
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                m += arr[i];
            }
            m = m / arr.Length;
            Console.Clear();
            WL("El promedio entero es: " + m);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == m)
                {
                    p++;
                }
            }

            WL("El promedio entero se repite " + p + " veces");
            Console.ReadKey();
        }
        static void Ejercicio16()
        {
            int[] arr = new int[10];
            int[] arr2 = new int[10];
            int m = 0;
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 3 == 0)
                {
                    arr2[m] = arr[i];
                    m++;
                }
            }
            Array.Resize(ref arr2, m);
            Console.Clear();
            WL("Numeros multiplos de 3: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.ReadKey();
        }
        static void Ejercicio18()
        {
            int[] arr = new int[10];
            int[] arr2 = new int[10];
            int m = 0;
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > 0)
                {
                    arr2[m] = i;
                    m++;
                }
            }
            Array.Resize(ref arr2, m);
            Console.Clear();
            WL("Posiciones de numeros positivos: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.ReadKey();
        }
        static void Ejercicio20()
        {
            int[] arr = new int[10];
            int pos = 0; int contp = 0; int m = 0;

            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
                for (int u = 1; u < (arr[i] + 1); u++)
                {
                    if (arr[i] % u == 0)
                    {
                        if (arr[i] > arr[pos])
                        {
                            pos = i;
                        }
                        contp++;
                    }
                }
                if (contp == 2)
                {
                    if (arr[i] < arr[m])
                    {
                        m = i;
                    }
                }
                contp = 0;
            }
            Console.Clear();
            WL("El numero primo menor esta en la posicion: " + m);
            Console.ReadKey();
        }
        static void Ejercicio22()
        {
            int[] arr = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            int m = 0;
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 5 == 0)
                {
                    arr2[m] = arr[i];
                    arr3[m] = i;
                    m++;
                }
            }
            Array.Resize(ref arr2, m);
            Array.Resize(ref arr3, m);
            Console.Clear();
            WL("Numeros multiplos de 5 y su posicion: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine("Numero " + arr2[i] + "  Posicion: " + arr3[i]);
            }
            Console.ReadKey();
        }
        static void Ejercicio24()
        {
            string[] arr = new string[10];
            int m = 0;
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = Console.ReadLine();
                if (arr[i].Length > arr[m].Length)
                {
                    m = i;
                }
            }
            Console.Clear();
            WL("El numero mayor esta en la posicion: " + m);
            Console.ReadKey();
        }
        static void Ejercicio26()
        {
            Int64[] arr = new Int64[10];
            Int64[] arr2 = new Int64[10];
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = Convert.ToInt64(Console.ReadLine());
                arr2[i] = arr[i];
                for (Int64 u = (arr[i] - 1); u > 0; u--)
                {
                    arr2[i] = arr2[i] * u;
                }
            }
            Console.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("El factorial de " + arr[i] + " es " + arr2[i]);
            }
            Console.ReadKey();
        }
        static void Ejercicio28()
        {
            int[] arr = new int[10];
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Numeros comprendidos entre el 1 y " + arr[i] + ": ");
                for (int u = 1; u <= arr[i]; u++)
                {
                    Console.WriteLine(u);
                }
            }
            Console.ReadKey();
        }
        static void Ejercicio30()
        {
            int[] arr = new int[10];
            int m = 0; bool bnum = false;
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Write("Ingrese un numero para saber si esta entre los 10 anteriores: \b\n");
            m = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == m)
                {
                    bnum = true;
                }
            }
            if (bnum == true)
            {
                WL("El numero " + m + " se encuentra entre los 10 anteriores!");
            }
            else
            {
                WL("El numero " + m + " no se encuentra entre los 10 anteriores! :(");
            }
            Console.ReadKey();
        }
        static void Ejercicio32()
        {
            int[] arr = new int[10];
            int m = 0; int dig1 = 0; int dig2 = 0; int cont = 0;
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Write("Ingrese otro numero: ");
            m = int.Parse(Console.ReadLine());
            dig1 = (m % 10);
            for (int i = 0; i < arr.Length; i++)
            {
                dig2 = (arr[i] % 10);
                if (dig1 == dig2)
                {
                    cont++;
                }
            }
            Console.Clear();
            Console.WriteLine(cont + " numeros terminan en el mismo digito que " + m);
            Console.ReadKey();
        }
        static void Ejercicio34()
        {
            int[] arr = new int[10];
            int cont = 0; string m; int pow1 = 10; int pow2 = 10; int dig = 0;
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
                m = Convert.ToString(arr[i]);
                for (int u = 0; u < m.Length; u++)
                {
                    dig = (arr[i] % pow1) / (pow2 / 10);
                    if (dig == 2)
                    {
                        cont++;
                    }
                    pow1 *= 10;
                    pow2 *= 10;
                }
                pow1 = 10;
                pow2 = 10;
            }

            Console.Clear();
            Console.WriteLine("El digito 2 se encuentra " + cont + " veces");
            Console.ReadKey();
        }
        static void Ejercicio36()
        {
            int[] arr = new int[10];
            int cont = 0; string m; int pow1 = 10; int pow2 = 10; int dig = 0; int contp = 0;
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
                m = Convert.ToString(arr[i]);
                for (int u = 0; u < m.Length; u++)
                {
                    dig = (arr[i] % pow1) / (pow2 / 10);
                    for (int w = 1; w < (arr[i] + 1); w++)
                    {
                        if (arr[i] % w == 0)
                        {
                            contp++;
                        }
                    }
                    if (contp == 2)
                    {
                        cont++;
                    }
                    contp = 0;
                    pow1 *= 10;
                    pow2 *= 10;
                }
                pow1 = 10;
                pow2 = 10;
            }

            Console.Clear();
            Console.WriteLine("El digito primo se encuentra " + cont + " veces");
            Console.ReadKey();
        }
        static void Ejercicio38()
        {
            int[] arr = new int[10];
            int semi = 0; int contp = 0;
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            semi = (arr[0] + arr[9]) / 2;
            for (int i = 1; i <= semi; i++)
            {
                if (semi % i == 0)
                {
                    contp++;
                }
            }
            Console.Clear();
            if (contp == 2)
            {
                Console.WriteLine("La semisuma entre el mayor y el menor es primo: " + semi);
            }
            else
            {
                Console.WriteLine("La semisuma entre el mayor y el menor NO es primo: " + semi);
            }
            Console.ReadKey();
        }
        static void Ejercicio40()
        {
            int[] arr = new int[10];
            int cont = 0; int dig = 0; int dig2 = 0;
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
                dig = (arr[i] % 10) / (10 / 10);
                dig2 = (arr[i] % 100) / (100 / 10);
                if (dig == 5 && dig2 == 1)
                {
                    cont++;
                }
            }

            Console.Clear();
            Console.WriteLine("El numero 15 se repite " + cont + " veces");
            Console.ReadKey();
        }
        static void Ejercicio42()
        {
            int[] arr = new int[10];
            string str; int pow = 10; int dig = 0; int contpares = 0; int pares = 0;

            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
                str = Convert.ToString(arr[i]);
                for (int w = 0; w < str.Length; w++)
                {
                    dig = (arr[i] % pow) / (pow / 10);
                    if (dig % 2 == 0)
                    {
                        contpares++;
                    }
                    pow = pow * 10;
                }
                if (contpares % 2 == 0 && contpares != 0)
                {
                    pares++;
                }
                contpares = 0;
                pow = 10;
            }
            Console.Clear();
            Console.WriteLine("Hay " + pares + " numeros con cantidad par de digitos pares");
            Console.ReadKey();
        }
        static void Ejercicio44()
        {
            int[] arr = new int[10];
            int[] arr2 = new int[99];
            int[] fibo = new int[99];
            fibo[0] = 0; fibo[1] = 1;
            int m = 0;
            for (int i = 2; i < fibo.Length; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }
            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
                for (int u = 0; u < fibo.Length; u++)
                {
                    if (arr[i] == fibo[u])
                    {
                        arr2[m] = arr[i];
                        m++;
                    }
                }
            }
            Array.Resize(ref arr2, m);
            Console.Clear();
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i] + " Pertenece a la serie fibonacci");
            }
            Console.ReadKey();
        }
        static void Ejercicio46()
        {
            int[] arr = new int[10];
            int contp = 0; int m = 0; string str; int pow = 10; int dig = 0;

            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
                str = Convert.ToString(arr[i]);
                for (int u = 1; u < (arr[i] + 1); u++)
                {
                    if (arr[i] % u == 0)
                    {
                        contp++;
                    }
                }
                if (contp == 2)
                {
                    for (int w = 1; w < str.Length; w++)
                    {
                        pow *= 10;
                    }
                    dig = (arr[i] % pow) / (pow / 10);
                    if (dig == 5)
                    {
                        m++;
                    }
                }
                pow = 10;
                contp = 0;
            }
            Console.Clear();
            WL(m + " numeros primos leidos comienzan por 5");
            Console.ReadKey();
        }
        static void Ejercicio48()
        {
            int[] arr = new int[10];
            int contp = 0; string str; int pow = 10; int dig = 0; int pos = 0; int contpares = 0; int pares = 0;

            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
                str = Convert.ToString(arr[i]);
                for (int u = 1; u < (arr[i] + 1); u++)
                {
                    if (arr[i] % u == 0)
                    {
                        contp++;
                    }
                }
                if (contp == 2)
                {
                    for (int w = 0; w < str.Length; w++)
                    {
                        dig = (arr[i] % pow) / (pow / 10);
                        if (dig % 2 == 0)
                        {
                            contpares++;
                        }
                        pow *= 10;
                    }
                    if (contpares > pares)
                    {
                        pares = contpares;
                        pos = i;
                    }
                    contpares = 0;
                }
                pow = 10;
                contp = 0;
            }
            Console.Clear();
            WL("El número primo con mayor cantidad de dígitos pares esta en la posicion: " + pos);
            Console.ReadKey();
        }
        static void Ejercicio50()
        {
            int[] arr = new int[10];
            int contp = 0; int m = 0; string str; int pow = 10; int dig = 0;

            WL("Ingrese 10 numeros enteros:");
            for (int i = 0; i < arr.Length; i++)
            {
                WL("Numero " + (i + 1) + ":");
                arr[i] = int.Parse(Console.ReadLine());
                str = Convert.ToString(arr[i]);
                for (int w = 1; w < str.Length; w++)
                {
                    pow *= 10;
                }
                dig = (arr[i] % pow) / (pow / 10);
                for (int u = 1; u < (dig + 1); u++)
                {
                    if (dig % u == 0)
                    {
                        contp++;
                    }
                }
                if (contp == 2)
                {
                    m++;
                }
                pow = 10;
                contp = 0;
            }
            Console.Clear();
            WL(m + " numeros que comienzan con digito primo");
            Console.ReadKey();
        }
    }
}
