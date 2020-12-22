using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capitulo10logica
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
                WL("BIENVENIDO \b\nSeleccione la funcion que desee: \b\n\b\n[1] EJERCIO 2 \b\n[2] EJERCIO 4 " +
                    "\b\n[3]EJERCIO 6 \b\n[4]EJERCIO 8 \b\n[5]EJERCIO 10 " +
                    "\b\n[6]EJERCIO 12  \b\n[7]EJERCIO 14 \b\n[8]EJERCIO 16 \b\n[9]EJERCIO 18 " +
                    "\b\n[10]EJERCIO 20  \b\n[11]EJERCIO 22 " +
                    "\b\n[12]EJERCIO 24 \b\n[13] EJERCIO 26 " +
                    "\b\n[14]EJERCIO 28  \b\n[15]EJERCIO 30 " +
                    "\b\n[16]EJERCIO 32  \b\n[17]EJERCIO 34 " +
                    "\b\n[18]EJERCIO 36 \b\n[19]EJERCIO 38  " +
                    "\b\n[20]EJERCIO 40  " +
                    "\b\n[21]EJERCIO 42  \b\n[22] EJERCIO 44 " +
                    "\b\n[23] EJERCIO 46 " +
                    "\b\n[24]EJERCIO 48 " +
                    "\b\n[25]EJERCIO 50 " +
                    "\b\n[26] SALIR");
                Write("\b\nOpcion: ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Ejercicio2();
                        Console.Clear();
                        WL("[1] Determinar cuantas veces se repita en la matriz el número mayor ");
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
                        WL("[2] Determinar en que posiciones exactas se encuentran los números primos ");
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
                        WL("[3] Calcular el promedio de los numeros mayores de cada fila");
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
                        WL("[4] Determinar cuantos enteros terminados en 0 hay almacenados en la matriz  ");
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
                        WL("[5] Determinar en que fila esta el mayor número primo");
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
                        WL("[6]  Determinar en que fila esta el mayor número terminado en 6  ");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
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
                        WL("[7] Determinar cuantos numeros almacenados en ella tienen mas de 3 digitos");
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
                        WL("[8] Determinar cuantos numeros almacenados en ella tienen un solo digito   ");
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
                        WL("[9] Determinar en que posicion exacta se encuentra el mayor multiplo de 8 ");
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
                        WL("[10]Determinar si cada uno de los elementos de una de las matrices es igual a cada uno de los elementos de la otra matriz multiplicado por el entero leido ");
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
                        WL("[11] Determinar si el numero mayor almacenado en la primera esta en la segunda ");
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
                        WL("[12] Determinar si el mayor numero primo de una de las matrices tambien se encuentra en la otra matriz \b\n[13] Determinar si la cantidad de numeros pares almacenados en una matriz es igual a la cantidad de numeros pares almacenados en la otra matriz");
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
                        WL("[13] Determinar si la cantidad de numeros pares almacenados en una matriz es igual a la cantidad de numeros pares almacenados en la otra matriz ");
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
                        WL("[14] Determinar en que posiciones se encuentran los numeros cuyo penultimo dígito sea el 5");
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
                        WL("[15] Determinar cuantas veces esta en ella el numero menor ");
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
                        WL("[16] Determinar en que posiciones estan los menores primos por fila  ");
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
                        WL("[17] Determinar cuantos de los numeros almacenados en ella pertenecen a los 100 primeros elementos de la serie de Fibonacci ");
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
                        WL("[18] Determinar si el mayor numero almacenado en una de ellas que pertenezca a la Serie de Fibonacci es igual al mayor número almacenado en la otra matriz que pertenezca a la Serie de Fibonacci");
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
                        WL("[19] Determinar si el mayor numero primo de una matriz esta repetido en la otra matriz");
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
                        WL("[20] Determinar si el promedio entero de los elementos de la diagonal de una matriz es igual al promedio de los elementos de la diagonal de la otra matriz");
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
                        WL("[21] Determinar si el promedio entero de los numeros primos de una matriz se encuentra almacenado en la otra matriz ");
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
                        WL("[23] Determinar si el promedio entero de los numeros menores cada fila de una matriz corresponde a alguno de los datos almacenados en las esquinas de la otra matriz");
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
                        WL("[23] Determinar si el promedio entero de los numeros menores cada fila de una matriz corresponde a alguno de los datos almacenados en las esquinas de la otra matriz ");
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
                        WL("[24] Determinar si el promedio de los mayores elementos que pertenecen a la serie de Fibonacci de cada fila de una matriz es igual al promedio de los mayores elementos que pertenecen a la serie de Fibonacci de cada fila de la otra matriz  ");
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
                        WL("[25] Determinar si el promedio de los elementos que se encuentran en su diagonal esta almacenado en ella");
                        WL("Desea repetir el ejercicio o continuar?\n[1] Repetir\n[2] Continuar");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Console.Clear();
                            goto case 25;
                        }
                        break;
                    case 26: //Salida
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
        static void WL(string str)
        {
            Console.WriteLine(str);
        }
        static void Ejercicio2()
        {
            int pos1 = 0; int pos2 = 0;
            int cont = 0;
            int[,] arr = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int u = 0; u < 4; u++)
                {
                    Write("Ingrese un numero: ");
                    arr[i, u] = int.Parse(Console.ReadLine());
                    if (arr[i, u] > arr[pos1, pos2])
                    {
                        pos1 = i;
                        pos1 = u;
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int u = 0; u < 4; u++)
                {
                    if (arr[pos1, pos2] == arr[i, u])
                    {
                        cont++;
                    }
                }
            }
            Console.Clear();
            WL("El numero mayor " + arr[pos1, pos2] + " se repite " + cont + " veces");
            Console.ReadKey();
        }
        static void Ejercicio4()
        {
            int cont = 0; int primo = 0;
            int[,] arr = new int[3, 4];
            int[] pos1 = new int[12];
            int[] pos2 = new int[12];
            for (int i = 0; i < 3; i++)
            {
                for (int u = 0; u < 4; u++)
                {
                    Write("Ingrese un numero: ");
                    arr[i, u] = int.Parse(Console.ReadLine());
                    for (int w = 1; w <= arr[i, u]; w++)
                    {
                        if (arr[i, u] % w == 0)
                        {
                            cont++;
                        }
                    }
                    if (cont == 2)
                    {
                        pos1[primo] = i;
                        pos2[primo] = u;
                        primo++;
                    }
                    cont = 0;
                }
            }
            Console.Clear();
            Array.Resize(ref pos1, primo);
            Array.Resize(ref pos2, primo);
            if (primo != 0)
            {
                for (int u = 0; u < primo; u++)
                {
                    WL("El numero primo " + arr[pos1[u], pos2[u]] + " se encuentra en las posiciones: " + pos1[u] + "," + pos2[u]);
                }
            }
            else
            {
                WL("No hay numeros primos");
            }
            Console.ReadKey();
        }
        static void Ejercicio6()
        {
            int[] prom = new int[4];
            int[,] arr = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int u = 0; u < 4; u++)
                {
                    Write("Ingrese un numero: ");
                    arr[i, u] = int.Parse(Console.ReadLine());

                }
                prom[i] = (arr[i, 0] + arr[i, 1] + arr[i, 2] + arr[i, 3]) / 4;
            }
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                WL("El promedio de la fila " + i + " es: " + prom[i]);
            }
            Console.ReadKey();
        }
        static void Ejercicio8()
        {
            int cont = 0;
            int[,] arr = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int u = 0; u < 4; u++)
                {
                    Write("Ingrese un numero: ");
                    arr[i, u] = int.Parse(Console.ReadLine());
                    if (arr[i, u] % 10 == 0)
                    {
                        cont++;
                    }
                }
            }
            Console.Clear();
            WL("Hay " + cont + " numeros terminados en 0");
            Console.ReadKey();
        }
        static void Ejercicio10()
        {
            int cont = 0; int fila = -1; int primo = 0;
            int[,] arr = new int[5, 3];
            for (int i = 0; i < 5; i++)
            {
                for (int u = 0; u < 3; u++)
                {
                    Write("Ingrese un numero: ");
                    arr[i, u] = int.Parse(Console.ReadLine());
                    for (int w = 1; w <= arr[i, u]; w++)
                    {
                        if (arr[i, u] % w == 0)
                        {
                            cont++;
                        }
                    }
                    if (cont == 2)
                    {
                        if (arr[i, u] > primo)
                        {
                            primo = arr[i, u];
                            fila = i;
                        }
                    }
                    cont = 0;
                }
            }
            Console.Clear();
            if (fila >= 0)
            {
                WL("El numero mayor primo se encuentra en la fila " + fila);
            }
            else
            {
                WL("No hay numeros primos");
            }
            Console.ReadKey();
        }
        static void Ejercicio12()
        {
            int fila = -1; int mayor = 0;
            int[,] arr = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int u = 0; u < 5; u++)
                {
                    Write("Ingrese un numero: ");
                    arr[i, u] = int.Parse(Console.ReadLine());
                    if (arr[i, u] % 10 == 6)
                    {
                        if (arr[i, u] > mayor)
                        {
                            mayor = arr[i, u];
                            fila = i;
                        }
                    }
                }
            }
            Console.Clear();
            WL("El mayor numero terminado en 6 se encuentra en la fila " + fila);
            Console.ReadKey();
        }
        static void Ejercicio14()
        {
            string str = "";
            int cont = 0;
            int[,] arr = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int u = 0; u < 5; u++)
                {
                    Write("Ingrese un numero: ");
                    arr[i, u] = int.Parse(Console.ReadLine());
                    str = Convert.ToString(arr[i, u]);
                    if (str.Length >= 3)
                    {
                        cont++;
                    }
                }
            }
            Console.Clear();
            if (cont > 0)
            {
                WL("Hay " + cont + " numeros con mas de 3 digitos");
            }
            else
            {
                WL("No hay numeros con mas de 3 digitos");
            }
            Console.ReadKey();
        }
        static void Ejercicio16()
        {
            string str = "";
            int cont = 0;
            int[,] arr = new int[5, 4];
            for (int i = 0; i < 5; i++)
            {
                for (int u = 0; u < 4; u++)
                {
                    Write("Ingrese un numero: ");
                    arr[i, u] = int.Parse(Console.ReadLine());
                    str = Convert.ToString(arr[i, u]);
                    if (str.Length == 1)
                    {
                        cont++;
                    }
                }
            }
            Console.Clear();
            if (cont > 0)
            {
                WL("Hay " + cont + " numeros con 1 digito");
            }
            else
            {
                WL("No hay numeros con 1 digito");
            }
            Console.ReadKey();
        }
        static void Ejercicio18()
        {
            string pos = ""; int mayor = 0;
            int[,] arr = new int[5, 4];
            for (int i = 0; i < 5; i++)
            {
                for (int u = 0; u < 4; u++)
                {
                    Write("Ingrese un numero: ");
                    arr[i, u] = int.Parse(Console.ReadLine());
                    if (arr[i, u] % 8 == 0)
                    {
                        if (arr[i, u] > mayor)
                        {
                            mayor = arr[i, u];
                            pos = (i + "," + u);
                        }
                    }
                }
            }
            Console.Clear();
            if (mayor > 0)
            {
                WL("El numero mayor multiplo de 8 se encuentra en la posicion: " + pos);
            }
            else
            {
                WL("No hay numeros multiplos de 8");
            }
            Console.ReadKey();
        }
        static void Ejercicio20()
        {
            int num = 0; int cont = 0;
            int[,] arr = new int[4, 5];
            int[,] arr2 = new int[4, 5];
            for (int w = 0; w < 2; w++)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int u = 0; u < 5; u++)
                    {
                        if (w == 0)
                        {
                            Write("Matriz " + (w + 1) + ", Ingrese un numero: ");
                            arr[i, u] = int.Parse(Console.ReadLine());
                        }
                        if (w == 1)
                        {
                            Write("Matriz " + (w + 1) + ", Ingrese un numero: ");
                            arr2[i, u] = int.Parse(Console.ReadLine());
                        }
                    }
                }
            }
            Console.Clear();
            Write("Ingrese un nuevo numero entero: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                for (int u = 0; u < 5; u++)
                {
                    if ((arr[i, u] * num) == arr2[i, u])
                    {
                        cont++;
                    }
                }
            }
            Console.Clear();
            if (cont > 0)
            {
                WL("Hay numeros en la matriz que multiplicado por el ultimo valor ingresado es igual a algun numero de otra matriz");
            }
            else
            {
                WL("NO hay numeros en la matriz que multiplicado por el ultimo valor ingresado es igual a algun numero de otra matriz...");
            }
            Console.ReadKey();
        }
        static void Ejercicio22()
        {
            int mayor = 0; bool f = false;
            int[,] arr = new int[4, 5];
            int[,] arr2 = new int[4, 5];
            for (int w = 0; w < 2; w++)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int u = 0; u < 5; u++)
                    {
                        if (w == 0)
                        {
                            Write("Matriz " + (w + 1) + ", Ingrese un numero: ");
                            arr[i, u] = int.Parse(Console.ReadLine());
                            if (arr[i, u] > mayor)
                            {
                                mayor = arr[i, u];
                            }
                        }
                        if (w == 1)
                        {
                            Write("Matriz " + (w + 1) + ", Ingrese un numero: ");
                            arr2[i, u] = int.Parse(Console.ReadLine());
                        }
                    }
                }
            }
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int u = 0; u < 5; u++)
                {
                    if (mayor == arr2[i, u])
                    {
                        f = true;
                    }
                }
            }
            if (f == true)
            {
                WL("El numero mayor de matriz 1 esta en la matriz 2");
            }
            else
            {
                WL("El numero mayor de matriz 1 no esta en la matriz 2");
            }
            Console.ReadKey();
        }
        static void Ejercicio24()
        {
            int mayor = 0; bool f = false; int cont = 0;
            int[,] arr = new int[4, 5];
            int[,] arr2 = new int[4, 5];
            for (int w = 0; w < 2; w++)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int u = 0; u < 5; u++)
                    {
                        if (w == 0)
                        {
                            Write("Matriz " + (w + 1) + ", Ingrese un numero: ");
                            arr[i, u] = int.Parse(Console.ReadLine());
                            for (int m = 1; m <= arr[i, u]; m++)
                            {
                                if (arr[i, u] % m == 0)
                                {
                                    cont++;
                                }
                            }
                            if (cont == 2)
                            {
                                if (arr[i, u] > mayor)
                                {
                                    mayor = arr[i, u];
                                }
                            }
                            cont = 0;
                        }
                        if (w == 1)
                        {
                            Write("Matriz " + (w + 1) + ", Ingrese un numero: ");
                            arr2[i, u] = int.Parse(Console.ReadLine());
                        }
                    }
                }
            }
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int u = 0; u < 5; u++)
                {
                    if (mayor == arr2[i, u])
                    {
                        f = true;
                    }
                }
            }
            if (f == true)
            {
                WL("El numero mayor primo de matriz 1 esta en la matriz 2");
            }
            else
            {
                WL("El numero mayor primo de matriz 1 no esta en la matriz 2");
            }
            Console.ReadKey();
        }
        static void Ejercicio26()
        {
            int par1 = 0; int par2 = 0;
            int[,] arr = new int[4, 5];
            int[,] arr2 = new int[4, 5];
            for (int w = 0; w < 2; w++)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int u = 0; u < 5; u++)
                    {
                        if (w == 0)
                        {
                            Write("Matriz " + (w + 1) + ", Ingrese un numero: ");
                            arr[i, u] = int.Parse(Console.ReadLine());
                            if (arr[i, u] % 2 == 0 && arr[i, u] != 0)
                            {
                                par1++;
                            }
                        }
                        if (w == 1)
                        {
                            Write("Matriz " + (w + 1) + ", Ingrese un numero: ");
                            arr2[i, u] = int.Parse(Console.ReadLine());
                            if (arr2[i, u] % 2 == 0 && arr2[i, u] != 0)
                            {
                                par2++;
                            }
                        }
                    }
                }
            }
            Console.Clear();

            if (par1 == par2)
            {
                WL("Ambas matrices tienen la misma cantidad de numeros pares");
            }
            else
            {
                WL("Ambas matrices NO tienen la misma cantidad de numeros pares");
            }
            Console.ReadKey();
        }
        static void Ejercicio28()
        {
            int cont = 0;
            int[] pos1 = new int[24];
            int[] pos2 = new int[24];
            int[,] arr = new int[4, 6];
            for (int i = 0; i < 4; i++)
            {
                for (int u = 0; u < 6; u++)
                {
                    Write("Ingrese un numero: ");
                    arr[i, u] = int.Parse(Console.ReadLine());
                    if ((arr[i, u] % 100) / 10 == 5)
                    {
                        pos1[cont] = i;
                        pos2[cont] = u;
                        cont++;
                    }
                }
            }
            Array.Resize(ref pos1, cont);
            Array.Resize(ref pos2, cont);
            Console.Clear();
            if (cont != 0)
            {
                for (int u = 0; u < cont; u++)
                {
                    WL("El numero " + arr[pos1[u], pos2[u]] + " cuyo penultimo digito es 5 se encuentra en las posiciones: " + pos1[u] + "," + pos2[u]);
                }
            }
            else
            {
                WL("No hay numeros cuyo penultimo digito sea 5");
            }
            Console.ReadKey();
        }
        static void Ejercicio30()
        {
            int pos1 = 0; int pos2 = 0;
            int cont = 0;
            int[,] arr = new int[4, 6];
            for (int i = 0; i < 4; i++)
            {
                for (int u = 0; u < 6; u++)
                {
                    Write("Ingrese un numero: ");
                    arr[i, u] = int.Parse(Console.ReadLine());
                    if (arr[i, u] < arr[pos1, pos2])
                    {
                        pos1 = i;
                        pos1 = u;
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int u = 0; u < 4; u++)
                {
                    if (arr[pos1, pos2] == arr[i, u])
                    {
                        cont++;
                    }
                }
            }
            Console.Clear();
            WL("El numero menor " + arr[pos1, pos2] + " se repite " + cont + " veces");
            Console.ReadKey();
        }
        static void Ejercicio32()
        {
            int cont = 0; int primo = 0;
            int[] menores = { 999999, 999999, 999999, 999999 };
            int[,] arr = new int[4, 6];
            int[] pos1 = new int[4];
            int[] pos2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                for (int u = 0; u < 6; u++)
                {
                    Write("Ingrese un numero: ");
                    arr[i, u] = int.Parse(Console.ReadLine());
                    for (int w = 1; w <= arr[i, u]; w++)
                    {
                        if (arr[i, u] % w == 0)
                        {
                            cont++;
                        }
                    }
                    if (cont == 2)
                    {

                        if (arr[i, u] < menores[i])
                        {
                            menores[i] = arr[i, u];
                            pos1[i] = i;
                            pos2[i] = u;
                            primo++;
                        }
                    }
                    cont = 0;
                }
            }
            Console.Clear();
            if (primo != 0)
            {
                for (int u = 0; u < 4; u++)
                {
                    WL("El numero primo menor de la fila " + u + ": " + menores[u] + ", se encuentra en la posicion " + pos1[u] + "," + pos2[u]);
                }
            }
            else
            {
                WL("No hay numeros primos");
            }
            Console.ReadKey();
        }
        static void Ejercicio34()
        {
            int cont = 0;
            int[] fibo = new int[100];
            fibo[0] = 0; fibo[1] = 1;
            int[,] arr = new int[4, 6];
            for (int i = 2; i < 100; i++)
            {
                fibo[i] = fibo[i - 2] + fibo[i - 1];
            }
            for (int i = 0; i < 4; i++)
            {
                for (int u = 0; u < 6; u++)
                {
                    Write("Ingrese un numero: ");
                    arr[i, u] = int.Parse(Console.ReadLine());
                    if (fibo.Contains<int>(arr[i, u]) == true)
                    {
                        cont++;
                    }
                }
            }
            Console.Clear();
            if (cont != 0)
            {
                WL(cont + " numeros leidos pertenecen a los 100 primeros numeros de la serie Fibonacci");
            }
            else
            {
                WL("Ningun numero coincide con los 100 primeros numeros de la serie Fibonacci");
            }
            Console.ReadKey();
        }
        static void Ejercicio36()
        {
            int mayor1 = 0; int mayor2 = 0; int pos1 = 0; int pos2 = 0;
            int[] fibo = new int[100];
            fibo[0] = 0; fibo[1] = 1;
            int[,] arr = new int[4, 6];
            int[,] arr2 = new int[4, 6];
            for (int i = 2; i < 100; i++)
            {
                fibo[i] = fibo[i - 2] + fibo[i - 1];
            }
            for (int w = 1; w < 3; w++)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int u = 0; u < 6; u++)
                    {
                        if (w == 1)
                        {
                            Write("Matriz " + w + ", Ingrese un numero: ");
                            arr[i, u] = int.Parse(Console.ReadLine());
                            if (fibo.Contains<int>(arr[i, u]) == true)
                            {
                                if (arr[i, u] > arr[pos1, pos2])
                                {
                                    mayor1 = arr[i, u];
                                }
                            }
                        }
                        if (w == 2)
                        {
                            Write("Matriz " + w + ", Ingrese un numero: ");
                            arr2[i, u] = int.Parse(Console.ReadLine());
                            if (fibo.Contains<int>(arr2[i, u]) == true)
                            {
                                if (arr2[i, u] > arr2[pos1, pos2])
                                {
                                    mayor2 = arr2[i, u];
                                }
                            }
                        }
                    }
                }
            }
            Console.Clear();
            if (mayor1 == mayor2)
            {
                WL("Los numeros mayores que pertenecen a la Serie Fibonacci de ambas matrices son iguales");
            }
            else
            {
                WL("Los numeros mayores que pertenecen a la Serie Fibonacci de ambas matrices NO son iguales");
            }
            Console.ReadKey();
        }
        static void Ejercicio38()
        {
            int mayor = 0; bool f = false; int cont = 0; int contm = 0;
            int[,] arr = new int[4, 6];
            int[,] arr2 = new int[4, 6];
            for (int w = 0; w < 2; w++)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int u = 0; u < 6; u++)
                    {
                        if (w == 0)
                        {
                            Write("Matriz " + (w + 1) + ", Ingrese un numero: ");
                            arr[i, u] = int.Parse(Console.ReadLine());
                            for (int m = 1; m <= arr[i, u]; m++)
                            {
                                if (arr[i, u] % m == 0)
                                {
                                    cont++;
                                }
                            }
                            if (cont == 2)
                            {
                                if (arr[i, u] > mayor)
                                {
                                    mayor = arr[i, u];
                                }
                            }
                            cont = 0;
                        }
                        if (w == 1)
                        {
                            Write("Matriz " + (w + 1) + ", Ingrese un numero: ");
                            arr2[i, u] = int.Parse(Console.ReadLine());
                        }
                    }
                }
            }
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int u = 0; u < 6; u++)
                {
                    if (mayor == arr2[i, u])
                    {
                        f = true;
                        contm++;
                    }
                }
            }
            if (f == true)
            {
                WL("El numero mayor primo de matriz 1 se repite " + contm + " veces en la matriz 2");
            }
            else
            {
                WL("El numero mayor primo de matriz 1 no esta en la matriz 2");
            }
            Console.ReadKey();
        }
        static void Ejercicio40()
        {
            int prom1 = 0; int prom2 = 0;
            int[,] arr = new int[5, 5];
            int[,] arr2 = new int[5, 5];
            for (int w = 1; w < 3; w++)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int u = 0; u < 5; u++)
                    {
                        if (w == 1)
                        {
                            Write("Matriz " + w + ", Ingrese un numero: ");
                            arr[i, u] = int.Parse(Console.ReadLine());
                        }
                        if (w == 2)
                        {
                            Write("Matriz " + w + ", Ingrese un numero: ");
                            arr2[i, u] = int.Parse(Console.ReadLine());
                        }
                    }
                }
                Console.Clear();
            }
            for (int w = 1; w < 3; w++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (w == 1)
                    {
                        prom1 += arr[i, (4 - i)];
                    }
                    if (w == 2)
                    {
                        prom2 += arr2[i, (4 - i)];
                    }
                }
            }
            prom1 = prom1 / 5;
            prom2 = prom2 / 5;
            Console.Clear();
            if (prom1 == prom2)
            {
                WL("El promedio diagonal " + prom1 + " es igual en ambas matricecs");
            }
            else
            {
                WL("Los promedios diagonales no son iguales");
            }
            Console.ReadKey();
        }
        static void Ejercicio42()
        {
            int prom1 = 0; int cont = 0; int primo1 = 0; bool b = false;
            int[,] arr = new int[5, 5];
            int[,] arr2 = new int[5, 5];
            for (int w = 1; w < 3; w++)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int u = 0; u < 5; u++)
                    {
                        if (w == 1)
                        {
                            Write("Matriz " + w + ", Ingrese un numero: ");
                            arr[i, u] = int.Parse(Console.ReadLine());
                            for (int m = 1; m <= arr[i, u]; m++)
                            {
                                if (arr[i, u] % w == 0)
                                {
                                    cont++;
                                }
                            }
                            if (cont == 2)
                            {
                                prom1 += arr[i, u];
                                primo1++;
                            }
                            cont = 0;
                        }
                        if (w == 2)
                        {
                            Write("Matriz " + w + ", Ingrese un numero: ");
                            arr2[i, u] = int.Parse(Console.ReadLine());
                        }
                    }
                }
                Console.Clear();
            }
            prom1 = prom1 / primo1;
            for (int i = 0; i < 5; i++)
            {
                for (int u = 0; u < 5; u++)
                {
                    if (prom1 == arr2[i, u])
                    {
                        b = true;
                    }
                }
            }
            Console.Clear();
            if (b == true)
            {
                WL("El promedio primo " + prom1 + " de la matriz 1 se encuentra en la matriz 2");
            }
            else
            {
                WL("El promedio primo de la matriz 1 no esta en la matriz 2");
            }
            Console.ReadKey();
        }
        static void Ejercicio44()
        {
            int prom1 = 0; int cont = 0; int cont2 = 0;
            string str = "";
            int[,] arr = new int[5, 5];
            int[,] arr2 = new int[5, 5];
            for (int w = 1; w < 3; w++)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int u = 0; u < 5; u++)
                    {
                        if (w == 1)
                        {
                            Write("Matriz " + w + ", Ingrese un numero: ");
                            arr[i, u] = int.Parse(Console.ReadLine());
                            str = Convert.ToString(arr[i, u]);
                            if (str.Last() == 4)
                            {
                                prom1 += arr[i, u];
                                cont2++;
                            }
                        }
                        if (w == 2)
                        {
                            Write("Matriz " + w + ", Ingrese un numero: ");
                            arr2[i, u] = int.Parse(Console.ReadLine());
                        }
                    }
                }
                Console.Clear();
            }
            if (cont2 != 0)
            {
                prom1 = prom1 / cont2;
                for (int i = 0; i < 5; i++)
                {
                    for (int u = 0; u < 5; u++)
                    {
                        if (prom1 == arr2[i, u])
                        {
                            cont++;
                        }
                    }
                }
            }
            Console.Clear();
            if (cont >= 3)
            {
                WL("El promedio " + prom1 + " de la matriz 1 se encuentra al menos 3 veces en la matriz 2");
            }
            else
            {
                WL("El promedio de la matriz 1 no esta en la matriz 2");
            }
            Console.ReadKey();
        }
        static void Ejercicio46()
        {
            int prom1 = 0; int pos = 0; bool b = false;
            int[] menores = new int[4];
            int[,] arr = new int[5, 5];
            int[,] arr2 = new int[5, 5];
            for (int w = 1; w < 3; w++)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int u = 0; u < 5; u++)
                    {
                        if (w == 1)
                        {
                            Write("Matriz " + w + ", Ingrese un numero: ");
                            arr[i, u] = int.Parse(Console.ReadLine());
                            if (arr[i, u] < arr[i, pos])
                            {
                                menores[i] = arr[i, u];
                                pos = u;
                            }
                        }
                        if (w == 2)
                        {
                            Write("Matriz " + w + ", Ingrese un numero: ");
                            arr2[i, u] = int.Parse(Console.ReadLine());
                        }
                    }
                    pos = 0;
                }
                Console.Clear();
            }
            for (int i = 0; i < 5; i++)
            {
                if (menores[i] == arr[0, 0] || menores[i] == arr[0, 4] || menores[i] == arr[4, 0] || menores[i] == arr[4, 4])
                {
                    b = true;
                }
            }
            Console.Clear();
            if (b == true)
            {
                WL("El promedio " + prom1 + " entero de los números menores cada fila de una matriz se encuentra en al menos una de las esquinas de la matriz 2");
            }
            else
            {
                WL("El promedio de los numeros menores de la matriz 1 NO esta en la matriz 2");
            }
            Console.ReadKey();
        }
        static void Ejercicio48()
        {
            int prom1 = 0; int prom2 = 0; int pos1 = 0; int pos2 = 0;
            int[,] mayores = new int[2, 5];
            int[] fibo = new int[100];
            fibo[0] = 0; fibo[1] = 1;
            int[,] arr = new int[5, 5];
            int[,] arr2 = new int[5, 5];
            for (int i = 2; i < 100; i++)
            {
                fibo[i] = fibo[i - 2] + fibo[i - 1];
            }
            for (int w = 1; w < 3; w++)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int u = 0; u < 5; u++)
                    {
                        if (w == 1)
                        {
                            Write("Matriz " + w + ", Ingrese un numero: ");
                            arr[i, u] = int.Parse(Console.ReadLine());
                            if (fibo.Contains<int>(arr[i, u]) == true)
                            {
                                if (arr[i, u] > arr[i, pos1])
                                {
                                    mayores[(w - 1), i] = arr[i, u];
                                    pos1 = u;
                                }
                            }
                        }
                        if (w == 2)
                        {
                            Write("Matriz " + w + ", Ingrese un numero: ");
                            arr2[i, u] = int.Parse(Console.ReadLine());
                            if (fibo.Contains<int>(arr2[i, u]) == true)
                            {
                                if (arr2[i, u] > arr2[i, pos1])
                                {
                                    mayores[(w - 1), i] = arr2[i, u];
                                    pos2 = u;
                                }
                            }
                        }
                    }
                    pos1 = 0;
                    pos2 = 0;
                }
                Console.Clear();
            }
            for (int w = 0; w < 2; w++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (w == 0)
                    {
                        prom1 += mayores[w, i];
                    }
                    if (w == 1)
                    {
                        prom2 += mayores[w, i];
                    }
                }
            }
            prom1 = prom1 / 5;
            prom2 = prom2 / 5;
            Console.Clear();
            if (prom1 == prom2)
            {
                WL("Los promedios de los mayores elementos que pertenecen a la serie de Fibonacci de cada fila de una matriz son iguales");
            }
            else
            {
                WL("Los promedios de los mayores elementos que pertenecen a la serie de Fibonacci de cada fila de una matriz NO son iguales...");
            }
            Console.ReadKey();
        }
        static void Ejercicio50()
        {
            int prom1 = 0; int pos1 = 0; int pos2 = 0;
            bool b = false;
            int[,] arr = new int[5, 5];
            int[,] arr2 = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int u = 0; u < 5; u++)
                {
                    Write("Matriz 1, Ingrese un numero: ");
                    arr[i, u] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 5; i++)
            {
                prom1 += arr[i, (4 - i)];
            }
            prom1 = prom1 / 5;
            for (int i = 0; i < 5; i++)
            {
                for (int u = 0; u < 5; u++)
                {
                    if (prom1 == arr[i, u])
                    {
                        b = true;
                        pos1 = i;
                        pos2 = u;
                    }
                }
            }
            Console.Clear();
            if (b == true)
            {
                WL("El promedio diagonal " + prom1 + " esta dentro de la matriz, se encuentra en la posicion: " + pos1 + "," + pos2);
            }
            else
            {
                WL("Los promedios diagonales no coinciden con algun numero de la matriz");
            }
            Console.ReadKey();
        }
    }
}
