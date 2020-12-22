using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1deProgramacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string op = " ";

            do {
            
                Console.Clear();
                Console.WriteLine("ELIGE TU PILAR colaca los numeros:\n1# Pilar\n2# Pilar\n3# Pilar\n4# Pilar\n5# informacion\n6# salir");
                op = (Console.ReadLine());
                switch (op)
                {
                    case "1":
                        Abstracción Vehiculo = new Abstracción();
                        Vehiculo.color = "rojo";
                        Vehiculo.Marca = "toyota";
                        Console.WriteLine($"vehiculo: {Vehiculo.color}\nmarca: {Vehiculo.Marca}");
                        Console.ReadKey();

                        break;
                    case "2": Encapsulamiento vehiculo = new Encapsulamiento();

                        vehiculo.Acelerar();
                        vehiculo.Marca = "mbs";
                        Console.WriteLine(value: $"vehiculo: {vehiculo.Marca}velocida: {vehiculo.Velocida}");
                        Console.ReadKey();
                        break;
                    case "3":
                        Carro miCarro = new Carro();
                        miCarro.AñoSalidaAlMercado = 2018;
                        miCarro.Acelerar();
                        Console.WriteLine(miCarro.Velocidad);
                        miCarro.Reversa();
                        Console.WriteLine("-------");
                        Camión miCamion = new Camión();
                        miCamion.Acelerar();
                        miCamion.AñoSalidaAlMercado = 2012;
                        miCamion.Reversa();
                        Console.WriteLine($"carro Año:{miCarro.AñoSalidaAlMercado}\n camionAño{miCamion.AñoSalidaAlMercado} ");
                        Console.ReadKey();
                        break;
                    case "4":
                        Herencia mitaller = new Herencia();
                        Reparar(mitaller);
                        Console.ReadKey();
                        break;
                    case "5": Gregory();
                        Console.ReadKey();
                        break;
                    default: Console.WriteLine("bye....");
                        break;


                }

            } while (op != "6");
            Console.ReadKey();
        }
        public class Abstracción
        {

            public string Marca;
            public string color;
            public int AñoSalidaAlMercado { get; set; }

            public void Acelerar()
            {
            }
        }
        public class Encapsulamiento
        {

            public string Marca;

            public int AñoSalidaAlMercado { get; set; }

            private int Velocidad { get; set; }
            //encaso que quisiéramos que agentes externos
            //puedan ver el valor la propiedad Velocidad, pero que no puedan alterar libremente dicho valor,
            public int Velocida { get; private set; }
            public void Acelerar()
            {
                //Velocidad += 20;
                Velocida += 10;
            }

        }
        public class Herencia
        {

            public string Modelo;

            public int AñoSalidaAlMercado { get; set; }

            public int Velocidad { get; private set; }

            public void Acelerar()
            {
                Velocidad += 10;
            }

            public virtual void Reversa()
            {

                Console.WriteLine("Voy de reversa!");
            }
        }

        public class Carro : Herencia
        {

            public void EncenderRadio()

            {
                Console.WriteLine("Encendiendo la radio");
            }
        }

        public class Camión : Herencia
        {
            public override void Reversa()

            {
                base.Reversa();
                Console.WriteLine("BEEP BEEP BEEP!");
            }
        }
        static void Reparar(Herencia vehículo)

        {

            Console.WriteLine("Iniciando reparación");
            Console.WriteLine("Probando acelerador");
            Console.WriteLine($"Velocidad inicial {vehículo.Velocidad}");
            vehículo.Acelerar();
            Console.WriteLine($"Velocidad final {vehículo.Velocidad}");
            Console.WriteLine("Probando reversa");
            vehículo.Reversa();
            Console.WriteLine("Listo!");

        }
        public static void Gregory() 
        {
            string Nombre = "Gregory Yeriel Burgos de Paula.";
            int matricula = 20186730;
            Console.WriteLine($"{Nombre}\n{matricula}");
        }

    }
}
