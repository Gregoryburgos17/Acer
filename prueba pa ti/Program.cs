using System;

namespace prueba_pa_ti
{
    class Program
    {
        static string nombre;
        static string saludar;
        static string despedir; 
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese su nombre");
             nombre = Convert.ToString(Console.ReadLine());
            Saludar();
            Despedir();
        }
        static void Saludar()
        {
            Console.WriteLine("hola " + nombre);
            Console.ReadLine();
        }
        static void Despedir()
        {
            Console.WriteLine("adios" + nombre);
            Console.ReadLine();
        }

    }
}
