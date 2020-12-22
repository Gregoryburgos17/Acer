using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int secion = 40;
            Aula aula = new Aula();
            aula.butacas = 30;
            aula.cantidad_de_alumnos = 30;
            aula.color = "amarillo";
            Aula.Maximacapacidad(secion);
            Console.WriteLine($"{aula.butacas},\n {aula.cantidad_de_alumnos},\n {aula.color}");
            Console.ReadKey();
        }

    }
    class Aula
    {
        public int butacas;
        public int ventanas;
        public string color;
        public int cantidad_de_alumnos;
        public static int Maximacapacidad(int max)
        {
            if (max < 30)
            {
                Console.WriteLine("esta  clase es suya");
                Console.ReadKey();
            }
            else Console.WriteLine("ESTA LLENA");
            Console.ReadKey();

            return max;

        }
    }
}
