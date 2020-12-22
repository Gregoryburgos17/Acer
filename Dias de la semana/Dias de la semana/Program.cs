using System;

namespace Dias_de_la_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instrodusca un valor");
            int numero, final, resul = 0;
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("hasta donde quiere llegar");
            final = int.Parse(Console.ReadLine());



            for (int i = 1; i <= final; i++) 
            {
                resul = numero * i;
                Console.WriteLine(numero+"*" + i + "=" + resul); 
            }
             
            

        }
    }
}
