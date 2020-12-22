using System;

namespace fundamento_2_tarea3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escriba una palabra ");
            string p = Console.ReadLine();

            string l2 = Convert.ToString(p[p.Length - 1]);

            if ((l2 == "n") || (l2 == "s") || (l2 == "a") || (l2 == "e") || (l2 == "i") || (l2 == "o") || (l2 == "u"))
            {
                Console.Write(p+" Esta palabra es aguda...");
            }

            else if ((l2 != "n") || (l2 != "s") || (l2 != "a") || (l2 != "e") || (l2 != "i") || (l2 != "o") || (l2 != "u"))
            {
                Console.Write(p+" Esta palabra es grave o llana...");
            }








            Console.ReadKey();
        }
    }
}
