using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace votacion_2020
{
    [Serializable]
    class Program
    {

        static void Main(string[] args)
        {
            int opciones;
            Console.WriteLine("aplicacion para votar por el lider 2020");
            Console.WriteLine("1.votar por candidato\n2.agregar candidato\n3.salir");
            opciones = int.Parse(Console.ReadLine());
            switch (opciones)
            {
                case 1:cadidatos(); break;
                case 2: nuevocandidato(); break;
                case 3:patido(); break;
               


            }
        }
        static void cadidatos()
        {
            int opcion;
            
            Console.WriteLine("partido a selecionar\n1.PLD\n2.PRM\n3.LFP\n4.PNVC");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:Console.WriteLine("Gonzalo Castillo");
                    break;
                case 2: Console.WriteLine("Luis Abinader");
                    break;
                case 3: Console.WriteLine("Leonel Fernández");
                    break;
                case 4: Console.WriteLine("Ramfis Domínguez-Trujillo");
                    break;

            }
        }
        //aqui cuenta los votos 
        static void patido()
        {
            int v1=0, v2=0, v3=0, v4=0,voto,max;
            double total, ov1, ova2, ova3,va4;
            string ganador;
            Console.WriteLine("(1)Gonzalo Castillo\n(2)Luis Abinader\n(3)Leonel Fernández\n(4)Ramfis Domínguez-Trujillo\n(5)ninguno");
            do
            {
                Console.Write("ingrese candidato a votar : ");
                voto = int.Parse(Console.ReadLine());
                if (voto == 1)
                {
                    v1 = v1 + 1;
                }
                else if (voto == 2)
                {
                    v2 = v2 + 1;
                }
                else if (voto == 3)
                {
                    v3 = v3 + 1;
                }
                else if (voto == 4)
                {
                    v4 = v4 + 1;
                }

            } while (voto != 5);
            total = v1 + v2 + v3 + v4;
            ov1 = (v1 / total) * 100;
            ova2 = (v2 / total) * 100;
            ova3 = (v3 / total) * 100;
            va4 = (v4 / total) * 100;
            Console.WriteLine("GONZALO TIENE :{0}",ov1);
            Console.WriteLine("LUIS TIENE :{0}", ova2);
            Console.WriteLine("LEONEL TIENE :{0}", ova3);
            Console.WriteLine("RANFIS TIENE :{0}", va4);
            max = v1;
            ganador = "GONZALO";
            if (v2 > max)
            {
                ganador="luis";
            }
            if (v3 > max)
            {
                ganador = "leonel";
            }
            if (v4 > max)
            {
                ganador = "ranfis";
            }
            Console.WriteLine("EL GANADOR ES:{0}", ganador);
        }
         static void nuevocandidato()
        {
            Console.WriteLine(" aplicacion para registrar candidatos para las elecciones del 2020.");
            string nombre, cargo, partido;
            int cedula;
            Console.WriteLine("elija el partido por el que va votar");
            partido = Console.ReadLine();
            Console.WriteLine(" el tipo de candidatura (senador, diputado, regidor).  ");
            cargo = Console.ReadLine();
            Console.WriteLine("nombre de su candidato.");
            nombre = Console.ReadLine();
            Console.WriteLine("introdusca su cedula.  ");
            cedula = int.Parse(Console.ReadLine());
            Console.WriteLine("el partido y el tipo de candidatura (senador, diputado, regidor). ");
            string ruta = "C:\\FCKGW";
            if (Directory.Exists(ruta) == false)
            {
                Directory.CreateDirectory(ruta);
            }

            string contenido = "<html>" +
           "<head>" +
          "</head>" +
           "<body style=background:" + ">" +
          "<center>" +
          "<table border='1'> " +
          " <tr><th>nombre</th><td>" + nombre +
          " <tr><th>cedula</th><td>" + cedula +
          "<tr><th>tu link fav. esta aqui </th><td>" + "<a href= " + "  title=”Esto es un tool.tip”>Ir a la red</a>."
          + "<tr><th>registro completo</th><td>" +
           "<a href= " + "  title=”Esto es un tool.tip”>Ir a la red</a>." + "<img src=" + ">" +
          " </center>"
          + "</td></tr></table></boby>" +
            "</html>";
            //retorno
            File.WriteAllText("C:\\FCKGW\\" + cedula + ".html", contenido);


            Console.WriteLine("desea continuar ingresando datos S/N");
            Console.ReadLine();
        }

    }
}
