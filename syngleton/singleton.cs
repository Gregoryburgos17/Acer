using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syngleton
{
   
    
        public sealed class Singleton
        {
            private static int counter = 0;
            private static Singleton instance = null;
            public static Singleton GetInstance
            {
                get
                {
                    if (instance == null)
                        instance = new Singleton();
                    return instance;
                }
            }

            private Singleton()
            {
                counter++;
                Console.WriteLine("Counter Value " + counter.ToString());
            }
            public void PrintDetails(string message)
            {
                Console.WriteLine(message);
            }
        }

    public sealed class Calculate
    {
        private Calculate()
        {
        }
        private static Calculate instance = null;
        public static Calculate Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculate();
                }
                return instance;
            }
        }
        public double ValueOne { get; set; }
        public double ValueTwo { get; set; }
        public double Addition()
        {
            return ValueOne + ValueTwo;
        }
        public double Subtraction()
        {
            return ValueOne - ValueTwo;
        }
        public double Multiplication()
        {
            return ValueOne * ValueTwo;
        }
        public double Division()
        {
            return ValueOne / ValueTwo;
        }
    }

}
