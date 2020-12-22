using System;

namespace fundamento_tareas3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ticket = 25;
            int usuario = 0;
            int total;
            Console.WriteLine("introduce el dinero");
            usuario = int.Parse(Console.ReadLine());
            if (usuario > ticket)
            {
                total = usuario / ticket;
                Console.WriteLine(" ticket comprados  " + total+"  gracias por su  compra ");
            }
            else if (usuario < ticket)
            {
                Console.WriteLine("dinero insuficiente por favor revise sus bosillos");
            }
            Console.ReadKey();


        }
    }
}
