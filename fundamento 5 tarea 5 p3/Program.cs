using System;

namespace fundamento_5_tarea_5_p3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Programa que acepte una temperatura en grados Cercius, Muestrelos en grado Kelvin y fahrenheit\n");
            double kelvin, celcius, farehith;
            Console.WriteLine("ingresar grados cercius que desea convertir");
            celcius = Convert.ToDouble(Console.ReadLine());
            farehith = (celcius * 9 / 5) + 32;
            kelvin = (celcius + 273.15);

            Console.WriteLine("su conversion de celcius a kelvin " + kelvin);
            Console.WriteLine("su conversion de celcius a farehith " + farehith);

            Console.ReadKey();
        }
    }
}
