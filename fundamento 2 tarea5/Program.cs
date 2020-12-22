using System;

namespace fundamento_2_tarea5
{
    class Program
    {
        static void Main(string[] args)
        {
            int F = 0;
            int C = 0;
            int N = 0;
            int SUMP = 0;
            int SUMS = 0;
            string linea;
            // INGRESO DE DATOS 
            Console.Write("TAMAÑO DE LA MATRIZ:");
            linea = Console.ReadLine();
            N = int.Parse(linea);
            int[,] MAT = new int[N + 1, N + 1];
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    Console.SetCursorPosition(C * 4, F + 1);
                    linea = Console.ReadLine();
                    MAT[F, C] = int.Parse(linea);
                   
                }
                
            }
            //DIAGONAL PRINCIPAL
            SUMP = 0;
            for (F = 1; F <= N; F++)
            {
                SUMP = SUMP + MAT[F, F];
            }
            // DIAGONAL SECUNDARIA
            SUMS = 0;
            C = N;
            for (F = 1; F <= N; F++)
            {
                SUMS = SUMS + MAT[F, C];
                C = C - 1;
            }
            // SALIDA
            Console.WriteLine();
            Console.WriteLine("SUMA DIAGONAL PRINCIPAL ES :" + SUMP);
            Console.WriteLine("SUMA DIAGONAL SECUNDARIA ES:" + SUMS);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();






            




        }

    }         
}
