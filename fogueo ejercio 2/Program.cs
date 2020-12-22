using System;

namespace fogueo_ejercio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] variable;
            variable = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese variable");
                string valores;
                valores = Console.ReadLine();
                variable[i] = Convert.ToString(valores);
                Console.WriteLine("este es el 5:" + variable[4] + "\n este es 4:" + variable[3] +"\n este es el 3:");

            }
            Console.ReadLine();

        }
    }
}
