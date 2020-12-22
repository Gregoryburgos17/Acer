using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamento_tarea_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2 , formula, rcomplejo;
            Console.WriteLine("encuentre a X1 y X2 usando la formula general");
            
            Console.WriteLine("intoduce valor de A");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("intoduce valor de B");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("intoduce valor de C");
            c = double.Parse(Console.ReadLine());

            formula = b * b - (4 * a * c);
            if (formula == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("raiz con doble final encontrada" + x1);
            }else if (formula >0)
            {
                formula = Math.Sqrt(formula);
                x1 = (-b + formula) / (2 * a);
                x2 = (-b - formula) / (2 * a);
                Console.WriteLine("los dos finales posibles son" + x1 +""+x2);

            }
            else
            {
                x1 = -b / (2 * a);
                rcomplejo = Math.Sqrt((-formula / (2 * a)));
                Console.WriteLine("este dato es imaginario " + x1 + "" + rcomplejo + "i" + x1 + "+" + rcomplejo + "i");
            }
            Console.ReadKey();
        }
    }
}
