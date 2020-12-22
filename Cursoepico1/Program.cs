using System;

namespace Cursoepico1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();

            int num = numero.Next(0, 100);

            int stop = 101;

            int intentetos = 0;
            Console.WriteLine("INTRODUCE UN N° DE 0 A 100");
            do
            {
                intentetos++;
                try
                {
                    stop = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {

                    Console.WriteLine("no has intoducido un numero");

                }catch(OverflowException ex)
                {
                    Console.WriteLine("has intoducido un numero muy alto");
                }


                if (stop > intentetos) Console.WriteLine("el N° es muy bajo");
                if (stop < intentetos) Console.WriteLine("el N° es muy alto");

            } while (num != stop);
            Console.WriteLine($"correcto  has necesitados {intentetos} intentos");





        }

    }
}
