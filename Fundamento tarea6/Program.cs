using System;

namespace Fundamento_tarea6
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0, promedio = 0;
            Console.WriteLine("medidor de indice academico");
            Console.WriteLine("Ingrese la primera nota");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la primera nota");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la primera nota");
            nota3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la primera nota");
            nota4 = float.Parse(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3 + nota4);
            promedio = (promedio / 4);
            Console.WriteLine("El promedio es" + promedio);
            if (promedio < 100 && promedio > 90)
            {
                Console.WriteLine("El promedio equivale a una A");
                float A = Convert.ToInt16(Console.ReadLine());
            }
            else if (promedio < 90 && promedio < 79)
            {
                Console.WriteLine("El promedio equivale a una B");
                float B = Convert.ToInt16(Console.ReadLine());
            }
            else if (promedio < 80 && promedio > 69)
            {
                Console.WriteLine("El promedio equivale a una c");
                float C = Convert.ToInt16(Console.ReadLine());

            }
            else if (promedio < 70 && promedio > 0)
            {
                Console.WriteLine("El promedio equivale a una c");
                float F = Convert.ToInt16(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
