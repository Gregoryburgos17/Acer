using System;

namespace fundamento_5tarea_5p2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double pesos, dolar, colombiano;
            Console.WriteLine("programa que convierte el peso dolar y peso colombiano\n");
            Console.WriteLine("digite a cantidad de peso a convertir");
            pesos = Convert.ToDouble(Console.ReadLine());
            dolar = (pesos * 0.019);
            colombiano = (pesos * 65.16);
            Console.WriteLine("el monto de dolares que tiene es {0}", dolar);
            Console.WriteLine("el monto de pesos colombiano que tiene es {0}", colombiano);
            Console.ReadKey();
        }
    }
}
