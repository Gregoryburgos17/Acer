using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string beca = "";
            Alumno a = new Alumno();
            a.Alumnos = "Pedro";
            a.Calificacion = 8;

            Alumno b = new Alumno();
            b.Alumnos = "Jose";
            b.Calificacion = 5;

            Alumno c = new Alumno();
            c.Alumnos = "Andres";
            c.Calificacion = 7;

            Alumno d = new Alumno();
            d.Alumnos = "Maria";
            d.Calificacion = 9;


            List<Alumno> list = new List<Alumno>
            {
                a,
                b,
                c,
                d
            };
            list = list.OrderByDescending(alumno => alumno.Calificacion).ToList();

            foreach (var item in list)
            {
                if (item.Calificacion >= 8)
                {
                    beca = "Con derecho a beca";
                }
                else
                {
                    beca = "Sin derecho a beca";
                }
                Console.WriteLine("\nAlumno: " + item.Alumnos + "\nCalificacion: " + item.Calificacion + " " + beca);
            }
            Console.ReadKey();


        }

    }
    public class Alumno
    {
        public string Alumnos { get; set; }
        public int Calificacion { get; set; }

    }
}
