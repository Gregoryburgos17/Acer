using System;
using System.Collections.Generic;

namespace ultimo_proyecto
{
    class Program
    {
        static string contacto;
        static string eventos;
        static string utilitarios;
        static int respardo;

        static string[] nombres = new string[500];
        static string[] telefono = new string[500];
        static string[] email = new string[500];
        static string[] direccion = new string[500];
        static string[] actividad = new string[500];
        static string[] fecha = new string[500];
        static string[] hora = new string[500];
        static string[] lugar = new string[500];
        static int x = -1;
        static void Main(string[] args)
        {


            int opciones = 0;
            do
            {
            Inicio:
                Console.WriteLine("Introduzca el valor del menú en el que desea ingresar: " +
                    "" + "\n" + "[1] Contactos" + "\n" + "[2] Eventos" + "\n" + "[3] Utilitarios" + "\n" + "[4]salir");


                opciones = int.Parse(Console.ReadLine());

                switch (opciones)
                {
                    case 1:
                        Contacto();

                        break;

                    case 2:
                        Eventos();
                        break;

                    case 3:
                        Utilitarios();
                        break;

                    case 4: break;
                    default:
                        Console.Clear();
                        Console.WriteLine("error 404 opcion incorrecta.... tu no me va  a volver loco a mi no:");
                        Console.ReadLine();
                        Console.Clear();
                        goto Inicio;

                }

                Console.ReadKey();

            } while (opciones != 4);
        }
        static void Contacto()
        {
            int opciones = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca el valor del menú en el que desea ingresar: " +
              "" + "\n" + "[1] Agregar" + "\n" + "[2] Actualizar" + "\n" + "[3] Borrar" + "\n" + "[4] Buscar" + "\n" + "[5]atras");


                opciones = int.Parse(Console.ReadLine());

                switch (opciones)
                {
                    case 1:

                        x++;
                        Console.Clear();
                        Console.Write("Introduzca el nombre: ");
                        nombres[x] = Console.ReadLine();
                        Console.Write("Introduzca el telefono: ");
                        telefono[x] = Console.ReadLine();
                        Console.Write("Introduzca el email: ");
                        email[x] = Console.ReadLine();
                        Console.Write("Introduzca la dirección: ");
                        direccion[x] = Console.ReadLine();

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("CONTACTO DE NOMBRE");
                        string busqueda2 = Console.ReadLine();

                        Console.Clear();

                        for (int i = 0; i < nombres.Length; i++)
                        {
                             if (nombres[i] == busqueda2 || email[i] == busqueda2)
                            {
                                Console.WriteLine("ACTUALIZA CONTACTO" + "\b\n" + nombres[i]);
                                nombres[i] = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("NUEVO CORREO" + "\b\n" + email[i]);
                                email[i] = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("NUEVO NUMERO" + "\b\n" + telefono[i]);
                                telefono[i] = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("NUEVA DIRECION" + "\b\n" + direccion[i]);
                                direccion[i] = Convert.ToString(Console.ReadLine());
                            }
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("CONTACTO NOMBRE O CORREO");
                        string busqueda3 = Console.ReadLine();

                        Console.Clear();

                        for (int i = 0; i < nombres.Length; i++)
                        {
                            if (nombres[i] == busqueda3)
                            {
                                nombres[i] = null;
                            }
                        }
                        for (int i = 0; i < email.Length; i++)
                        {
                            if (email[i] == busqueda3)
                            {
                                email[i] = null;
                            }
                        }
                        Console.ReadKey();

                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("CONTACTO NOMBRE O CORREO");
                        string busqueda = Console.ReadLine();

                        Console.Clear();

                        for (int i = 0; i < nombres.Length; i++)
                        {
                            if (nombres[i] == busqueda)
                            {
                                Console.WriteLine("contacto " + i + "\b\ncontacto encontrado" + "\b\n" + nombres[i]);
                                Console.WriteLine("correo" + "\b\n" + email[i]);
                                Console.WriteLine("numero" + "\b\n" + telefono[i]);
                                Console.WriteLine("lugar" + "\b\n" + direccion[i]);
                            }
                        }
                        for (int i = 0; i < email.Length; i++)
                        {
                            if (email[i] == busqueda)
                            {
                                Console.WriteLine("contacto " + i + "\b\ncontacto encontrado" + "\b\n" + nombres[i]);
                                Console.WriteLine("correo" + "\b\n" + email[i]);
                                Console.WriteLine("numero" + "\b\n" + telefono[i]);
                                Console.WriteLine("lugar" + "\b\n" + direccion[i]);
                            }
                        }
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear(); break;
                }

            } while (opciones != 5);
        }
        static void Respardo()
        {


            for (int x = 0; x < nombres.Length; x++)
            {
                Console.Clear();
                Console.Write("Introduzca el nombre: ");
                nombres[x] = Console.ReadLine();
                Console.Write("Introduzca el telefono: ");
                telefono[x] = Console.ReadLine();
                Console.Write("Introduzca el email: ");
                email[x] = Console.ReadLine();
                Console.Write("Introduzca la dirección: ");
                direccion[x] = Console.ReadLine();



            }

        }



        static void Eventos()
        {
            int opciones = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca el valor del menú en el que desea ingresar: " +
              "" + "\n" + "[1] Agregar" + "\n" + "[2] Actualizar" + "\n" + "[3] Borrar" + "\n" + "[4] Buscar" + "\n" + "[5]atras");


                opciones = int.Parse(Console.ReadLine());

                switch (opciones)
                {
                    case 1:

                        x++;
                        Console.Clear();
                        Console.Write("Introduzca el nombre de la actividad: ");

                        actividad[x] = Console.ReadLine();

                        Console.Write("Introduzca la fecha: ");
                        fecha[x] = Convert.ToString(Console.ReadLine());
                        Console.Write("Introduzca la hora: ");
                        hora[x] = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("introduce lugar");
                        lugar[x] = Convert.ToString(Console.ReadLine());


                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("actualizar evento");
                        string busqueda2 = Console.ReadLine();

                        Console.Clear();

                        for (int x = 0; x < nombres.Length; x++)

                            if (fecha[x] == busqueda2)
                            {
                                Console.WriteLine("ACTUALIZA FECHA" + "\b\n" + fecha[x]);
                                actividad[x] = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("NUEVO  FECHA" + "\b\n" + actividad[x]);
                                fecha[x] = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("NUEVO NUMERO" + "\b\n" + hora[x]);
                                hora[x] = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("NUEVA LUGAR" + "\b\n" + lugar[x]);
                                lugar[x] = Convert.ToString(Console.ReadLine());
                            }

                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("BORRAR EVENTO");
                        string busqueda3 = Console.ReadLine();

                        Console.Clear();

                        for (int x = 0; x < fecha.Length; x++)
                        {
                            if (fecha[x] == busqueda3)
                            {
                                fecha[x] = null;
                            }
                        }
                        Console.ReadKey();

                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("FECHA MARCADA");
                        string busqueda = Console.ReadLine();

                        Console.Clear();

                        for (int x = 0; x < fecha.Length; x++)
                        {
                            if (fecha[x] == busqueda)
                            {
                                Console.WriteLine(" proximo evento" + x + "\b\nfecha encotrada" + "\b\n" + fecha[x]);
                                Console.WriteLine("dia de evento" + "\b\n" + actividad[x]);
                                Console.WriteLine("tiempo de evento" + "\b\n" + hora[x]);
                                Console.WriteLine("lugar de evento" + "\b\n" + lugar[x]);
                            }
                        }
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear(); break;
                }

            } while (opciones != 5);






        }


        static void Utilitarios()
        {
            int opcion;
            do
            {
            Inicio:
                Console.Clear();
                Console.WriteLine("Elija una opcion: \b\n [1] Conversor de RD$ a USD$ \b\n [2] Conversor de USD$ a RD$ \b\n [3] Conversor de Grados Fahrenheit a Celsius \b\n [4] Conversor de Grados Celsius a Fahrenheit \b\n [5] Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        RdToUs();
                        break;
                    case 2:
                        UsToRd();
                        break;
                    case 3:
                        FtoC();
                        break;
                    case 4:
                        CtoF();
                        break;
                    case 5:
                        Salir();
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta, intentelo denuevo...");
                        goto Inicio;
                }

            } while (opcion != 5);
        }
        static void RdToUs()
        {
            Console.Clear();
            double usd = 51; double conv;
            Console.Write("Ingrese una cantidad en peso dominicano: ");
            double num = Convert.ToDouble(Console.ReadLine());
            conv = num / usd;
            Console.Clear();
            Console.WriteLine(num + " pesos dominicanos equivale a " + conv + " dolares");
            Console.ReadKey();
        }
        static void UsToRd()
        {
            Console.Clear();
            double usd = 51; double conv;
            Console.Write("Ingrese una cantidad en dolares: ");
            double num = Convert.ToDouble(Console.ReadLine());
            conv = num * usd;
            Console.Clear();
            Console.WriteLine(num + " dolares equivale a " + conv + " pesos dominicanos");
            Console.ReadKey();
        }
        static void FtoC()
        {
            Console.Clear();
            double fah;
            Console.Write("Grado Celsius: ");
            double num = Convert.ToDouble(Console.ReadLine());
            fah = (num * 9 / 5) + 32;
            Console.Clear();
            Console.WriteLine("Grado Fahrenheit: " + fah);
            Console.ReadKey();
        }
        static void CtoF()
        {
            Console.Clear();
            double cel;
            Console.Write("Grado Fahrenheit: ");
            double num = Convert.ToDouble(Console.ReadLine());
            cel = (num - 32) * 5 / 9;
            Console.Clear();
            Console.WriteLine("Grado Celsius: " + cel);
            Console.ReadKey();
        }
        static void Salir()
        {
            Console.Clear();
            Console.WriteLine("Saliendo...");
            Console.ReadKey();
            Console.Clear();
        } 
        
    


     






    }
}

