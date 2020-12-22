using System;
using System.MEDIA


namespace calculo_elemental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA QUE HACE LOS 4 CALCULADOS");
            int num1 = 0, num2 = 0, resul, x;
            num1 = leernumero("ingresa primer digito");
            num2 = leernumero("ingresa primer digito");
            Console.Clear();
            Console.WriteLine("INGRESE LA OPERACION A REALIZAR\n1.suma:\n2.resta:\n3.multiplicacion:\n4.division:");
            x = int.Parse(Console.ReadLine());
            switch (x)
            {

                case 1:
                    Console.WriteLine("SUMAR");
                    resul = num1 + num2;
                    Console.WriteLine("LA SUMA ES {0}: ", resul); break;
                case 2:
                    Console.WriteLine("RESTAR");
                    resul = num1 - num2;
                    Console.WriteLine("LA RESTA ES: {0} - {1} = {2} ", num1, num2, resul); break;
                case 3:
                    Console.WriteLine("MULTIPLICAR");
                    resul = num1 * num2;
                    Console.WriteLine("LA MULTIPLICACIÓN ES: " + resul); break;
                case 4:
                    Console.WriteLine("DIVIDIR");
                    resul = num1 / num2;
                    Console.WriteLine("LA DIVISIÓN ES: " + resul); break;

            }

        }
        public static int leernumero(string msg)
        {
            var numero = 0;
            Console.WriteLine(msg);
            try
            {
                numero = int.Parse(Console.ReadLine());
            }

            catch (Exception e)
            {
                numero = leernumero(msg);

            }

            return numero;
        }
        static void hablar(string audio)
        {
            var Myplayer = new SoundPlayer();

        }

    }
}