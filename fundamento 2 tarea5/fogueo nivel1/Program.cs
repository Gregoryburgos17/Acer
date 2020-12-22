using System;

namespace fogueo_nivel1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] variable;
            variable = new string[5];
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("ingrese variable");
                string valores;
                valores = Console.ReadLine();
                variable[i] = Convert.ToString(valores);
                Console.WriteLine(variable[i]);

            }
            Console.ReadLine();

        }
    }
}
