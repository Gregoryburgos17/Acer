using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareita
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre, APELLIDO, PROVINCIA;
            int Edad = 0,Num1, Num2,Dia = 0,NUM1 = 30, NUM2 = 40,NUM3 = 60, RESUL = 0;
            string caso = "";
            do
            {
                Console.Clear();
                Console.WriteLine("lige tus ejercios del \n[1]ejercio 1\n[2]ejercio 2\n[3]ejercio 3\n[4]ejercio. 4\n[5]sumadora.\nsalir[6]");
                Console.Write("digite su opcion:");

                caso = (Console.ReadLine());
                switch (caso)
                {
                    case "1":

                       


                        Console.WriteLine("Insertar su nombre");
                        Nombre = Console.ReadLine();
                        Console.WriteLine("Insertar su edad");
                        Edad = int.Parse(Console.ReadLine());
                        Console.WriteLine(" hola " + Nombre + " tines " + Edad + " años ");

                        if (Edad < 18)
                        {
                            Console.WriteLine("eres menor de edad no puedes entrar");
                        }

                        else
                        {
                            Console.WriteLine("Como eres mayor de edad puedes entrar a la aplicacion");
                        }

                        Console.ReadKey(); break;
                    case "2":
                        
                        Console.WriteLine("insertar nombre");
                        Nombre = Console.ReadLine();
                        Console.WriteLine("insertar apellido");
                        APELLIDO = Console.ReadLine();
                        Console.WriteLine("insertar su provincia");
                        PROVINCIA = Console.ReadLine();
                        Console.WriteLine($"Su nombre completo {Nombre} {APELLIDO}  y provincia son {PROVINCIA }");

                        Console.ReadKey(); break;
                    case "3":
                        
                        Console.WriteLine("insertar primer numero");
                        Num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insertar segundo numero");
                        Num2 = int.Parse(Console.ReadLine());

                        if (Num1 > Num2)
                        {
                            Console.WriteLine(Num1 + " Es mayor " + Num2 + " Es menor ");
                        }

                        else
                        {
                            Console.WriteLine(Num2 + " Es mayor " + Num1 + " ES menor ");

                        }
                        Console.ReadKey();
                        break;
                    case "4":
                       
                        Console.WriteLine("digite el numero de su dia");
                        Dia = int.Parse(Console.ReadLine());

                        if (Dia > 7)
                            Console.WriteLine("ERROR DIGITE UN NUMERO DEL 1 AL 7");

                        switch (Dia)
                        {
                            case 1:
                                Console.WriteLine("hoy es lunes\n" + "dia de semana");
                                break;
                            case 2:
                                Console.WriteLine("hoy es martes\n" + "dia de semana");
                                break;
                            case 3:
                                Console.WriteLine("hoy es miercoles\n" + "dia de semana");
                                break;
                            case 4:
                                Console.WriteLine("hoy es jueves\n" + "dia de semana");
                                break;
                            case 5:
                                Console.WriteLine("hoy es viernes\n" + "dia de semana");
                                break;
                            case 6:
                                Console.WriteLine("hoy es sabado\n" + "Fin de semana");

                                break;
                            case 7:
                                Console.WriteLine("hoy es domingo\n" + "Fin de semana");

                                break;
                        }
                        Console.ReadKey();

                        break;
                    case "5":
                        
                        RESUL = NUM1 + NUM2 + NUM3;
                        Console.Write("La suma de las variables es " + RESUL);
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("SALIENDO..."); break;
                    default:
                        Console.Clear();
                        Console.WriteLine("no te entiendo");
                        Console.ReadKey();
                        break;
                }

            } while (caso != "6");

        }
    }
}
