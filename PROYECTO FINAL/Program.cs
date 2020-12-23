using System;

namespace PROYECTO_FINAL
{
    class Program
    {
        static int cuadrado = 0;
        static int usuario;
        static int cubo = 0;
        static void Main(string[] args) 
        {

            Console.WriteLine("ingresa numero");
            usuario = int.Parse(Console.ReadLine());
            Console.Clear();
            Cubo();
            Console.Clear();
            Cuadrado();
            Console.Clear();
            Resul();
        }
        static void Cubo()
        {
            int cubo = (usuario * usuario * usuario);
            Console.WriteLine(cubo);
            Console.ReadKey();
        }
        static void Cuadrado()
        {
            int cuadrado = (usuario * usuario);
            Console.WriteLine(cuadrado);
            Console.ReadKey();
        }
        static void Resul()
        {
            Console.WriteLine(usuario);
        }
    }
}