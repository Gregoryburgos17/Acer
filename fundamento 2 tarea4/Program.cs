using System;

namespace fundamento_2_tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            double prestamo = 0, mes = 0, total = 0;
            double interes = 0;
            Console.WriteLine(" introdusca  cantidad de dinero a tomar prestado");
            prestamo= int.Parse(Console.ReadLine());
            Console.WriteLine(" introduce el interes");
            interes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("periodo de meses ");
            mes = int.Parse(Console.ReadLine());
            interes = prestamo * (interes / 1200) * mes;
            total = interes;
            Console.WriteLine("TOTAL QUE DEBE PAGAR POR MES ES " + total);
            Console.ReadKey();



        }
    }
}
