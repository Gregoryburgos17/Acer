using System;

namespace Fundamento_2_tarea
{
    class Program
    {    
        static void Estilo(string nombe)
        {
            char java;
         for(int i=0; i<nombe.Length; i++)
         {
                java =nombe[i];
                switch (java.ToString().ToLower())
                {
                    case "a": Console.WriteLine("\nAAAA\nA  A\nAAAA\nA  A\nA  A\n\n"); break;
                    case "b": Console.WriteLine("\nb\nbbbb\nb    b\nbbbb\n"); break;
                    case "c": Console.WriteLine("\nccccc\nc\nc\nccccc"); break;
                    case "d": Console.WriteLine("\n   d\n   d\ndddd\nd  d\ndddd"); break;
                    case "e": Console.WriteLine("\neeeee\ne\neeee\ne\neeee"); break;
                    case "g": Console.WriteLine("\ngggg\ng\ng gg\ng  g\ngggg"); break;
                    case "h": Console.WriteLine("\nh  h\nh  h\nhhhh\nh  h\nh  h"); break;
                    case "j": Console.WriteLine("\njjjjj\n  j\n  j\nj j\n j"); break;
                    case "k": Console.WriteLine("\nk\nk  k\nk k\nkk\nk k\nk  k"); break;
                    case "l": Console.WriteLine("\nl\nl\nl\nl\nlll"); break;
                    case "p": Console.WriteLine("\npppp\np  p\npppp\np\np"); break;
                    case "o": Console.WriteLine("\n ooo \no   o\no   o\no   o\n ooo"); break;
                    case "i": Console.WriteLine("\ni\n \ni\ni\ni"); break;
                    case "r": Console.WriteLine("\nrrrrr\nr    r\nr    r\nr   r\nrrrr\nr  r\nr   r"); break;
                    case "t": Console.WriteLine("\n  t\nttttt\n  t\n  t\n  t"); break;
                    case "q": Console.WriteLine("\n qqqq\nq   q\nq   q\nq   q\n qqqq\n    q\n    q"); break;
                    case "s": Console.WriteLine("\n  s\ns   s\ns   \n  s\n   s\ns   s\n  s"); break;
                    case "x": Console.WriteLine("\n x      x\n  x   x\n    x\n  x   x\n x      x"); break;
                    case "z": Console.WriteLine("zzzzz\n    z\n   z\n z\nz\nzzzzz"); break;
                    case "v": Console.WriteLine("\nv       v\n v     v\n  v   v\n    v"); break;
                    case "m": Console.WriteLine("\n m m m \nm  m  m\nm  m  m"); break;
                    case "n": Console.WriteLine("\nNN  N\nN N N\nN  NN"); break;
                    case "w": Console.WriteLine("\n w    w    w\n    w   w\n   w     w"); break;
                    case "y": Console.WriteLine("\ny    y\n y  y\n  y\n  y\n  y"); break;
                    case "u": Console.WriteLine("\nu    u\nu    u\nu    u\nuuuuuu"); break;

                }


         }
            Console.ReadKey();



        }
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine(" Programa de estilo de letra");
            Console.WriteLine("introduce tu nombre ");
            nombre = Console.ReadLine();
            Estilo(nombre);

            Console.ReadKey();





        }
    }
}
