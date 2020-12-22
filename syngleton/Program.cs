using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syngleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Singleton fromTeachaer = Singleton.GetInstance;
            fromTeachaer.PrintDetails("from  Teacher");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("from  Student");
            Console.ReadLine();

            //
            Calculate.Instance.ValueOne = 10.5;
            Calculate.Instance.ValueTwo = 5.5;
            Console.WriteLine("Addition : " + Calculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
            Console.WriteLine("Division : " + Calculate.Instance.Division());
            Console.WriteLine("\n----------------------\n");
            Calculate.Instance.ValueTwo = 10.5;
            Console.WriteLine("Addition : " + Calculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
            Console.WriteLine("Division : " + Calculate.Instance.Division());
            Console.ReadLine();
        }
    }
}
