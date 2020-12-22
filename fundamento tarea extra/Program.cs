using System;
using System.Net;


namespace fundamento_tarea_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int img = default, p = default, div = default;
            Console.WriteLine("introduce UrL");
            string URL = Console.ReadLine();
            string bot = new WebClient().DownloadString(URL);
            string[] tokens = bot.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string token in tokens)
            {
                if(token.Contains("<div"))
                {
                    div++;
                }
                if (token.Contains("<img"))
                {
                    img++;
                }
                if (token.Contains("<p"))
                {
                    p++;
                }
            }
            
            Console.WriteLine(img + " cantidad de imagenes");
            Console.WriteLine(p+ " cantidad de parrafo");
            Console.WriteLine(div+ "  cantidad de div");

            Console.ReadKey();
        }
    }
}

        
    

