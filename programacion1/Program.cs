using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bienbenido a la cafeteria la pampara");
      
            
            Console.WriteLine("\nintrodusca su saldo: ");
            Console.ReadKey();
            int funda = 0;
                funda =int.Parse(Console.ReadLine());
            if (funda > 100)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("menu" + "\n[1]multiplicar" +
                    "\n[2]jugos" + "\n[3]hamburguesas" + "\n[4]empanadas" + "\n su saldo: " + funda);
                    int opicion = int.Parse(Console.ReadLine());
                    switch (opicion)
                    {
                        case 1:
                            int num = 12;
                            Console.Clear();
                            Console.Write("introdusca su numero es:");

                            num = int.Parse(Console.ReadLine());
                            int total = num * num;

                            Console.Write("el resultado es:" + total);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("JUGOS:\n[1]pamparalimon=[30$]\n[2]pamparabanana=[30$]\n[3]pamparamango=[30$]\n[4]pamaparanaranja=[30$]");
                            Console.Write("introduca su orden es:");
                            num = int.Parse(Console.ReadLine());
                            switch (num)
                            {
                                case 1: funda = funda - 30; break;
                                case 2: funda = funda - 30; break;
                                case 3: funda = funda - 30; break;
                                case 4: funda = funda - 30; break;
                                default: break;
                            }
                            Console.Write("su nuevo saldo es " + funda);
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("[1]hamburguesas queso=[40$]\n [2]pampara predia=[500$]\n");

                            Console.Write("introduca su orden es:");
                            num = int.Parse(Console.ReadLine());
                            switch (num)
                            {
                                case 1: funda = funda - 40; break;
                                case 2: funda = funda - 500; break;
                                default: break;
                            }

                            break;
                        case 4:
                            Console.Clear();
                            Console.Write("[1]empanadas de ñema=[30]\n[2]empanadas para rata=[30$]\n[3]dame too\n[4]empanada de tu estilo=[30$]");
                            Console.Write("\nintroduca su orden es:");
                            num = int.Parse(Console.ReadLine());
                            switch (num)
                            {
                                case 1: funda = funda - 30; break;
                                case 2: funda = funda - 30; break;
                                case 3: funda = funda - 30; break;
                                case 4: funda = funda - 30; break;
                                default: break;
                            }
                            break;
                        default: break;
                    }

                } while (funda != 0);
                Console.Write("vayase de hay arrancoo!!");
                Console.ReadKey();

            }
            else Console.WriteLine("NO TIENES SUCIFICIENTES FONDOS ");
            Console.ReadKey();

        }
    }
}
