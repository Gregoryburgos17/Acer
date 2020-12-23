using System;
using System.IO;

namespace Fundameto_p_3_tarea
{
   
    class Program
    {
        
         
            
            
            

            static void Main(string[] args)
            {
                string nombre, apellido, direcion, tsangre, correo, genero, estudio, trabajo, obvida, red;

                int telefono,edad;
                DateTime fechanacimiento;
                string mano;

                do
                {
                    Console.Clear();
                    Console.WriteLine("digite el nombre ");
                    nombre = (Console.ReadLine());
                    Console.WriteLine("digite  su apellido ");
                    apellido = (Console.ReadLine());
                    Console.WriteLine("digite  su direcion ");
                    direcion = (Console.ReadLine());
                    Console.WriteLine("digite el tipo de sangre ");
                    tsangre = (Console.ReadLine());
                    Console.WriteLine("digite su correo ");
                    correo = (Console.ReadLine());
                    Console.WriteLine("digite su genero F/M ");
                    genero = (Console.ReadLine());
                    Console.WriteLine("digite sus estudios realizados ");
                    estudio = (Console.ReadLine());
                    Console.WriteLine("digite trabajos realizados ");
                    trabajo = (Console.ReadLine());
                    Console.WriteLine("objetivo de vida ");
                    obvida = (Console.ReadLine());
                    Console.WriteLine("link de su red social favorita ");
                    red = (Console.ReadLine());
                    Console.WriteLine("digite su cedula ");
                    int cedula = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("digite el telefeno ");
                    telefono = int.Parse(Console.ReadLine());

                    Console.WriteLine("digite su fecha de nacimiento");
                    //parte para el zodiaco
                    fechanacimiento = DateTime.Parse(Console.ReadLine());
                    edad = DateTime.Today.AddTicks(-fechanacimiento.Ticks).Year - 1;
                  
                    
                    // string dato;

                    string url = "";
                    string img = "";
                    Console.WriteLine(url);
                    if (edad < 1 || edad == 7)
                    {

                        url = "https://horoscopo.abc.es/signos-zodiaco-aries.html";
                        img = "https://www.himgs.com/imagenes/hola-usa/horoscopo/aries.svg";

                    }
                    if (edad < 7 || edad == 14)
                    {
                        url = "https://horoscopo.abc.es/signos-zodiaco-tauro.html";
                        img = "https://www.himgs.com/imagenes/hola-usa/horoscopo/aries.svg";


                    }

                    if (edad != 14 || edad == 21)
                    {
                        url = "https://horoscopo.abc.es/signos-zodiaco-geminis.html";
                        img = "https://www.himgs.com/imagenes/hola-usa/horoscopo/aries.svg";

                    }
                    if (edad != 21 || edad == 28)
                    {
                        url = "https://horoscopo.abc.es/signos-zodiaco-cancer.html";
                        img = "https://www.himgs.com/imagenes/hola-usa/horoscopo/aries.svg";
                    }
                    if (edad > 28 || edad == 35)
                    {
                        url = "https://horoscopo.abc.es/signos-zodiaco-leo.html";
                        img = "https://www.himgs.com/imagenes/hola-usa/horoscopo/aries.svg";
                    }
                    if (edad > 35 || edad == 42)
                    {
                        url = "https://horoscopo.abc.es/signos-zodiaco-virgo.html";
                        img = "https://www.himgs.com/imagenes/hola-usa/horoscopo/aries.svg";

                    }
                    if (edad > 42 || edad == 49)
                    {

                        url = "https://horoscopo.abc.es/signos-zodiaco-libra.html";
                        img = "https://www.himgs.com/imagenes/hola-usa/horoscopo/aries.svg";
                    }
                    if (edad > 49 || edad == 56)
                    {

                        url = "https://horoscopo.abc.es/signos-zodiaco-escorpio.html";
                        img = "https://www.himgs.com/imagenes/hola-usa/horoscopo/.svg";
                    }
                    if (edad > 56 || edad == 63)
                    {
                        url = "https://horoscopo.abc.es/signos-zodiaco-sagitario.html";
                        img = "https://www.himgs.com/imagenes/hola-usa/horoscopo/sagitario.svg";

                    }
                    if (edad > 63 || edad == 70)
                    {

                        url = "https://horoscopo.abc.es/signos-zodiaco-capricornio.html";
                        img = "https://www.himgs.com/imagenes/hola-usa/horoscopo/aries.svg";
                    }
                    if (edad > 70 || edad == 77)
                    {

                        url = "https://horoscopo.abc.es/signos-zodiaco-capricornio.html";
                        img = "https://www.himgs.com/imagenes/hola-usa/horoscopo/capricornio.svg";
                    }
                    if (edad > 77 || edad == 84)
                    {

                        url = "https://horoscopo.abc.es/signos-zodiaco-piscis.html ";
                        img = "https://www.himgs.com/imagenes/hola-usa/horoscopo/piscis.svg";
                    }


                    //estructura html
                    Console.ReadKey();
                    string ruta = "C:\\FCKGW";
                    if (Directory.Exists(ruta) == false)
                    {
                        Directory.CreateDirectory(ruta);
                    }
                    string color = (genero.ToLower() == "f") ? "pink" : "#cccccc";
                    string contenido = "<html>" +
                   "<head>" +
                  "</head>" +
                   "<body style=background:" + color + ">" +
                  "<center>" +
                  "<table border='1'> " +
                  " <tr><th>nombre</th><td>" + nombre +
                  " <tr><th>apellido</th><td>" + apellido +
                  " <tr><th>Direcion</th><td>" + direcion +
                  " <tr><th>genero</th><td>" + genero +
                  " <tr><th>telefono</th><td>" + telefono +
                  " <tr><th>cedula</th><td>" + cedula +
                  " <tr><th>t.sangre</th><td>" + tsangre +
                  " <tr><th>correo</th><td>" + correo +
                  " <tr><th>tu edad es </th><td>" + edad +
                  " <tr><th>fecha de nacimiento</th><td>" + fechanacimiento +
                  " <tr><th>estudios realizados</th><td>" + estudio +
                  "<tr><th>trabajos realizados</th><td>" + trabajo +
                  " <tr><th>objetivos de vida</th><td>" + obvida +
                  "<tr><th>link de red social favorita</th><td>" + red +
                  "<tr><th>tu link fav. esta aqui </th><td>" + "<a href= " + red + "  title=”Esto es un tool.tip”>Ir a la red</a>."
                  + "<tr><th>registro completo</th><td>" +
                  "<tr><th>tu signo zodiacar esta aqui</th><td>" +
                   "<a href= " + url + "  title=”Esto es un tool.tip”>Ir a la red</a>." + "<img src=" + img + ">" +
                  " </center>"
                  + "</td></tr></table></boby>" +
                    "</html>";
                    //retorno
                    File.WriteAllText("C:\\FCKGW\\" + cedula + ".html", contenido);


                   Console.WriteLine("desea continuar ingresando datos S/N");
                   mano = Console.ReadLine();
                } while (mano == "S");
                Console.WriteLine("Adios...........BUENA SUERTE");


                Console.ReadKey();
            }
                

            
         
    }
}
