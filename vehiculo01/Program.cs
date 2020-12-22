using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculo01
{
   
    class Mostrar_Vehiculo
    {
        class Vehiculo
        {
            public string Modelo;
            public string marca;

            public static void Vervehiculo(string m , string n)
            {
                
                Console.Clear();
                
                 Vehiculo carro1 = new Vehiculo();
                carro1.marca = m;
                Console.WriteLine($"El vehículo es:{carro1.marca} ");
                carro1.Modelo = n;
                Console.WriteLine($" marca:{carro1.marca}");
                Console.WriteLine($" modelo: {carro1.Modelo}");
                Vehiculo carro = new Vehiculo();
                carro1.marca = m;
                carro1.Modelo = n;
                Console.WriteLine($"El vehículo es:{carro.marca} ");
                Console.WriteLine($" marca:{carro.marca}");
                Console.WriteLine($" modelo: {carro.Modelo }");
               
                
            }
            public static void Setvehiculo(string marca1, string modelo1)
            {
                string cambiar;
                Vehiculo carro = new Vehiculo();
                Vehiculo carro1 = new Vehiculo();
                carro.marca = "";
                carro.Modelo = "";
                carro1.marca = "";
                carro1.Modelo = "";
                Console.WriteLine($"VEHICULO\nMarca {carro.marca} \nModelo {carro.Modelo}");
                Console.WriteLine("cambiar vehiculo?");
                cambiar = Console.ReadLine();
                if (cambiar == "si")
                {

                    Console.WriteLine("cambiar marca?");
                    marca1 = Console.ReadLine();
                    Console.WriteLine("cambiar modelo?");
                    modelo1 = Console.ReadLine();
                    carro.marca = marca1;
                    carro.Modelo = modelo1;
                    Console.WriteLine($"VEHICULO\nMarca {marca1} \nModelo {modelo1}");
                    Console.Clear();
                    carro1.marca = marca1;
                    carro1.Modelo = modelo1;
                    Console.WriteLine("cambiar marca?");
                    marca1 = Console.ReadLine();
                    Console.WriteLine("cambiar modelo?");
                    modelo1 = Console.ReadLine();
                    carro.marca = marca1;
                    carro.Modelo = modelo1;
                    Console.WriteLine($"VEHICULO\nMarca {marca1} \nModelo {modelo1}");
                }
                Console.ReadKey();

            }
        }

        static void Main(string[] args)
        {
            string modelo , marca ;
            Vehiculo carro1 = new Vehiculo();
            Console.WriteLine("vehiculo");
            Console.WriteLine(" introduce marca:");
            carro1.marca= marca = Console.ReadLine();
            Console.WriteLine("introduce modelo:");
            carro1.Modelo = modelo = Console.ReadLine();
            Console.WriteLine($"VEHICULO\nMarca {carro1.marca} \nModelo {carro1.Modelo}");
            Console.ReadKey();
            Console.Clear();
            Vehiculo carro = new Vehiculo();
            Console.WriteLine("vehiculo2");
            Console.WriteLine(" introduce marca:");
            carro.marca = marca =Console.ReadLine();
            Console.WriteLine("introduce modelo:");
            carro.Modelo = modelo= Console.ReadLine();
            Console.WriteLine($"VEHICULO\nMarca {carro.marca} \nModelo {carro.Modelo}");
            Vehiculo.Vervehiculo(marca,modelo);
            Vehiculo.Setvehiculo(marca, modelo);
            
            Console.ReadKey();
        }
    }
    
}
