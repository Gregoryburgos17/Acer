using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoAJeno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Practica 2 - 2018-6970";
        Inicio:
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Pratica 02 - Programacion I\n\n[1] Ejercicio 1: Saludo\n[2] Ejericicio 2: Numeros 1-50 \n[3] Ejericicio 3: Loteria \n[4] Ejericicio 4: Vehiculo \n[5] Ejericicio 5: Producto \n[6] Salir");
                try
                {
                    op = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingrese una opcion valida...!");
                    Console.ReadKey();
                    goto Inicio;
                }
                Console.Clear();

                switch (op)
                {
                    case 1:
                        
                        string nombre;
                        Console.WriteLine($"Hola, estudiante { HolaEstudiante() } Bienvenido a Programacion I");
                        Console.ReadKey();
                        break;
                    case 2:
                        Numeros();
                        break;
                    case 3:
                        Loteria();
                        break;
                    case 4:
                        VerVehiculo();
                        break;
                    case 5:
                        VerProducto ver = new VerProducto();
                        Vehiculo mustang = new Vehiculo();
                        ver.Main();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida...!");
                        Console.ReadKey();
                        goto Inicio;
                }
            } while (op != 6);
        }
        static string HolaEstudiante()
        {
            string myname = "Jesus Mercado";
            return myname;
        }
        static void Numeros()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        static void Loteria()
        {
            dynamic loteria = new Random();
            loteria = loteria.Next(1, 100);
            int cont = 0, intento = 0;
            bool gameover = false;
            do
            {
            Loteria:
                if (cont == 6)
                {
                    gameover = true;
                    Console.WriteLine("Ya no te quedan intentos, hasta la proxima! :)");
                    goto Gameover;
                }
                Console.WriteLine("Intenta adivinar el numero de la loteria! (1-100) - Tienes " + (6 - cont) + " intentos restantes");
                try
                {
                    intento = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese un numero entero valido...");
                    Console.ReadKey();
                    goto Loteria;
                }
                Console.Clear();

                if (intento == loteria)
                {
                    Console.WriteLine("LOTERIA! Has adivinado correctamente el numero, gracias por su participacion!");
                    gameover = true;
                }
                else
                {
                    if (intento - loteria <= 5 && intento - loteria > 0 || intento - loteria >= -5 && intento - loteria < 0)
                    {
                        Console.WriteLine("CALIENTE! Casi casi lo consigues, sigue intentando... :D");
                    }
                    else
                    {
                        Console.WriteLine("Frio, sigue intendo...");
                    }
                }
            Gameover:
                Console.ReadKey();
                cont++;
            } while (gameover == false);
        }
        static void VerVehiculo()
        {
            Vehiculo vehiculo = new Vehiculo();
            int op = 0;
            do
            {
            Vehiculo:
                Console.Clear();
                Console.WriteLine("[1] Encender/Apagar Vehiculo \n[2] Ver datos del Vehiculo \n[3] Atras");
                op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        if (vehiculo.Estado == "Apagado")
                        {
                            vehiculo.Estado = "Encendido";
                            Console.WriteLine("Encendiendo vehiculo... Bruhmmm");
                            Console.ReadKey();
                        }
                        else if (vehiculo.Estado == "Encendido")
                        {
                            vehiculo.Estado = "Apagado";
                            Console.WriteLine("Apagando vehiculo...");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Vehiculo \n\nMarca: " + vehiculo.Marca +
                            "\nModelo: " + vehiculo.Modelo + "\nAño: " + vehiculo.Age +
                            "\nColor: " + vehiculo.Color + "\nEstado: " + vehiculo.Estado);
                        Console.ReadKey();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida...");
                        Console.ReadKey();
                        goto Vehiculo;
                }
            } while (op != 3);
        }
        static void Ejemplo()
        {
            Vehiculo carro = new Vehiculo();
        }
    }
    public class Vehiculo
    {
        public string Marca = "Mercedes-Benz";
        public string Modelo = "AMG GT S Coupe";
        public int Age = 2018;
        public string Color = "Verde";
        public string Estado { get; set; }
    }

}
