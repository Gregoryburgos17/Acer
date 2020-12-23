using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeGato
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] tablero = new char[3, 3];
            inicializartablero(ref tablero);
            Console.WriteLine("BIENVENIDO WAWAWA\n");
            Console.WriteLine("\n----------------------\n" +
                "\nATENCION TRAMPOSO:\n");
            Console.WriteLine("*[EL JUGADOR 1:TIENE EL PRIMER TURNO]\n" +
                "*[eljuego es simple gana quien tenga tres letras en fila o vertical ect.]" +
                "\n*[no hay empates o ganas o pierdes]" +
                "\n///att:el terror*-*!!\n");

            Console.ReadKey();

            string nombre1="";
            string nombre2="";
           
            while (nombre1.Length < 2)
            {
                Console.Clear();
                
                Console.WriteLine(" \nJUGADOR 1: tu seras representado por la X: \n");
                Console.Write("Jugador 1: introduzca su nombre:");
                nombre1 = Console.ReadLine();
                if (nombre1.Length < 2)
                {
                    Console.Clear();
                    Console.WriteLine("intenta con un nombre mas largo");
                    Console.ReadKey();

                }
            }
            while (nombre2.Length < 2)
            {
                Console.Clear();
                Console.WriteLine(" \nJUGADOR 2: tu seras representado por la Y:\n ");
                Console.Write("JUGADOR 2: introduzca su nombre:");
                nombre2 = Console.ReadLine();
                if (nombre2.Length < 2)
                {
                    Console.Clear();
                    Console.WriteLine("intenta con un nombre mas largo");
                    Console.ReadKey();

                }
            }
            bool esturno = true;
            while (!hayGanador(tablero))
            {
                Console.Clear();
                Console.WriteLine("BIENVENIDO WAWAWA");
                Console.WriteLine("----------------------");
                Console.WriteLine();
                Console.WriteLine(tablerovisual(tablero));
                Console.WriteLine();
                string nombredejugador = "";
                if (esturno)
                {
                    nombredejugador = nombre1;

                }
                else
                {
                    nombredejugador = nombre2;
                }

                string coordenadas = "";
                while (!coordenadavalidad(coordenadas) || EstaYaOcupado(tablero, coordenadas))
                {
                    Console.WriteLine($"{nombredejugador} :introduce la coordenada donde quieres jugar");
                    Console.Write("\nej..A1 en la columna 1 fila A : ");
                    coordenadas = Console.ReadLine().ToUpper();
                    if (!coordenadavalidad(coordenadas))
                    {
                        Console.WriteLine("la coordenada no es validad ");
                    }
                    if (EstaYaOcupado(tablero, coordenadas))
                    {
                        Console.WriteLine("la coordenada ya esta ocupada ");
                    }

                }
                char caracterUsado = ' ';
                if (esturno)
                {
                    caracterUsado = 'X';

                }
                else
                {
                    caracterUsado = 'O';
                }
                ponercoordenadas(ref tablero, coordenadas, caracterUsado);
                esturno = !esturno;
                if (hayGanador(tablero))
                {
                    break;
                }
                if (Estalleno(tablero))
                {
                    break;
                }
                Console.ReadKey();
            }
            

          
            if (hayGanador(tablero))
            {
                Console.Clear();
                Console.WriteLine("BIENVENIDO WAWAWA");
                Console.WriteLine("----------------------");
                Console.WriteLine();
                Console.WriteLine(tablerovisual(tablero));
                Console.WriteLine();
                Console.WriteLine("GAME OVER PP...");
                if (Ganador(tablero) == 'X')
                {
                    Console.WriteLine($"{nombre1} WINN!!!");

                }
                else
                {
                    Console.WriteLine($"{nombre2} WINN!!!");
                }

            }
            if (Estalleno(tablero))
            {
                Console.Clear();
                Console.WriteLine("BIENVENIDO WAWAWA");
                Console.WriteLine("----------------------");
                Console.WriteLine();
                Console.WriteLine(tablerovisual(tablero));
                Console.WriteLine("EMPATE???");
                Console.WriteLine("GAME OVER PP...");
                Console.WriteLine("NO HAY GANADOR...");
            }


                Console.ReadKey();
           
        }
        static void inicializartablero(ref char[,] tablero)
        {
            for (int contador1 = 0; contador1 < 3; contador1++)
            {
                for (int contador2 = 0; contador2 < 3; contador2++)
                {
                    tablero[contador1, contador2] = ' ';
                }
            }
        }
        static string tablerovisual(char[,] tablero)
        {
            string tv = "" + Environment.NewLine;
            tv = "  1    2    3 " + Environment.NewLine;
            tv += " ┌───┬───┬───┐" + Environment.NewLine;
            tv += $"A│ {tablero[0, 0]} │ {tablero[0, 1]} │ {tablero[0, 2]} │" + Environment.NewLine;
            tv += " ├───┼───┼───┤" + Environment.NewLine;
            tv += $"B│ {tablero[1, 0]} │ {tablero[1, 1]} │ {tablero[1, 2]} │" + Environment.NewLine;
            tv += " ├───┼───┼───┤" + Environment.NewLine;
            tv += $"C│ {tablero[2, 0]} │ {tablero[2, 1]} │ {tablero[2, 2]} │" + Environment.NewLine;
            tv += " └───┴───┴───┘" + Environment.NewLine;
            return tv;
        }
        static char Ganador(char[,] tablero)
        {
            //filas
            if (tablero[0, 0] == tablero[0, 1] && tablero[0, 1] == tablero[0, 2] && tablero[0, 0] != ' ')
            {
                return tablero[0, 0];
            }
            if (tablero[1, 0] == tablero[1, 1] && tablero[1, 1] == tablero[1, 2] && tablero[1, 1] != ' ')
            {
                return tablero[1, 0];
            }
            if (tablero[2, 0] == tablero[2, 1] && tablero[2, 1] == tablero[2, 2] && tablero[2, 0] != ' ')
            {
                return tablero[2, 0];
            }
            //columnas
            if (tablero[0, 0] == tablero[1, 0] && tablero[1, 0] == tablero[2, 0] && tablero[0, 0] != ' ')
            {
                return tablero[0, 0];
            }
            if (tablero[0, 1] == tablero[1, 1] && tablero[1, 1] == tablero[2, 1] && tablero[0, 1] != ' ')
            {
                return tablero[0, 1];
            }
            if (tablero[0, 2] == tablero[1, 2] && tablero[1, 2] == tablero[2, 2] && tablero[0, 2] != ' ')
            {
                return tablero[0, 2];
            }
            //diagonales
            if (tablero[0, 0] == tablero[1, 1] && tablero[1, 1] == tablero[2, 2] && tablero[0, 0] != ' ')
            {
                return tablero[0, 0];
            }
            if (tablero[2, 0] == tablero[1, 1] && tablero[1, 1] == tablero[0, 2] && tablero[0, 2] != ' ')
            {
                return tablero[0, 2];
            }
            return ' ';
        }
        static bool hayGanador(char[,] tablero)
        {
            return Ganador(tablero) != ' ';
        }
        static bool Estaocupada(char[,] tablero, int x, int y)
        {
            if (x < 0 || x > 2)
            {
                throw new ArgumentException("el valor de x debe ser 0, 1 o 2", "x");
            }
            if (y < 0 || y > 2)
            {
                throw new ArgumentException("el valor de y debe ser 0, 1 o 2", "y");
            }

            return tablero[x, y] != ' ';
        }
        static bool EstaYaOcupado(char[,]tablero,string coordenadas)
        {
            coordenadas = coordenadas.ToUpper();
            switch (coordenadas)
            {
                case "A1":
                    return Estaocupada(tablero, 0, 0);
                case "A2":
                    return Estaocupada(tablero, 0, 1);
                case "A3":
                    return Estaocupada(tablero, 0, 2);
                case "B1":
                    return Estaocupada(tablero, 1, 0);
                case "B2":
                    return Estaocupada(tablero, 1, 1);
                case "B3":
                    return Estaocupada(tablero, 1, 2);
                case "C1":
                    return Estaocupada(tablero, 2, 0);
                case "C2":
                    return Estaocupada(tablero, 2, 1);
                case "C3":
                    return Estaocupada(tablero, 2, 2);
            }
            return false;
        }   
        static void ponercoordenadas(ref char[,] tablero,string coordenadas,char letra)
        {
            coordenadas = coordenadas.ToUpper();
            switch (coordenadas)
            {
                case "A1":
                    tablero[0, 0] = letra;
                    return;
                case "A2":
                    tablero[0, 1] = letra;
                    return;
                case "A3":
                    tablero[0, 2] = letra;
                    return;
                case "B1":
                    tablero[1, 0] = letra;
                    return;
                case "B2":
                    tablero[1, 1] = letra;
                    return;
                case "B3":
                    tablero[1, 2] = letra;
                    return;
                case "C1":
                    tablero[2, 0] = letra;
                    return;
                case "C2":
                    tablero[2, 1] = letra;
                    return;
                case "C3":
                    tablero[2, 2] = letra;
                    return;
               

            }
        }
        static bool coordenadavalidad(string coordenadas)
        {
          
            switch (coordenadas)
            {
                case "A1":
                    
                case "A2":
                    
                case "A3":
                   
                case "B1":
                    
                case "B2":
                    
                case "B3":
                    
                case "C1":
                   
                case "C2":
                   
                case "C3":
                    return true;
                default:
                    return false;
            }
            
        }
        static bool Estalleno(char[,]tablero)
        {
            if(tablero[0,0]!=' '&& tablero[0,1]!=' ' && tablero[0,2]!=' ' &&
                tablero[1, 0] != ' ' && tablero[1, 1] != ' ' && tablero[1, 2] != ' '&&
                tablero[2, 0] != ' ' && tablero[2, 1] != ' ' && tablero[2, 2] != ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
