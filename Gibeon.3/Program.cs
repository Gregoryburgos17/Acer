using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Gibeon._3
{
    class Program
    {
        static dynamic datos = new List<Datos>();
        static int idx = 0;
        static string txt = "";
        static string[] cedula = new string[1];
        static string[] nombre = new string[1];
        static string[] apellido = new string[1];
        static string[] sexo = new string[1];
        static DateTime[] nacimiento = new DateTime[1];
        static string[] carrera = new string[1];
        static string[] tel = new string[1];
        static string[] cel = new string[1];
        static string[] correo = new string[1];

        static void Main(string[] args)
        {
            int op = 0;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string file = @"\clientes.txt";
            if (System.IO.File.Exists(@path + file)) //Verifica si de antemano existe el txt con los clientes
            {
                try //Lee los clientes y lo carga a la clase Datos
                {
                    TextReader sr;
                    sr = new StreamReader(@path + file);
                    txt = sr.ReadToEnd();
                    datos = JsonConvert.DeserializeObject<List<Datos>>(txt);
                    sr.Close();
                }
                catch
                {
                    Console.WriteLine("El archivo no se pudo leer...");
                    Console.ReadKey();
                }
            }
            do
            {
            Inicio:
                Console.Clear();
                Console.WriteLine("BIENVENIDO - Menu principal \b\n\b\n[1] Agregar cliente \b\n[2] Mostrar clientes \b\n[3] Salir");
                op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1: //Lee los datos del cliente a ingresar y lo guarda en un txt; los datos son serializados en json
                        Clientes();
                        System.IO.File.WriteAllText(@path + file, txt);
                        Console.Clear();
                        Console.WriteLine("Guardando en la ruta: " + Convert.ToString(path));
                        Console.ReadKey();
                        break;
                    case 2:
                        if (System.IO.File.Exists(@path + file)) // Verifica si el archivo existe
                        {
                            Mostrar(); // Muestra los datos del cliente
                        }
                        else
                        {
                            Console.WriteLine("No hay clientes registrados...");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        break;
                    default:
                        goto Inicio;
                }


            } while (op != 3);
        }
        static void WR(string w)
        {
            Console.Write(w);

        }
        static void Clientes()
        {
            WR("Ingrese los siguientes datos\b\nCedula: ");
            cedula[idx] = Console.ReadLine();
            WR("Nombre: ");
            nombre[idx] = Console.ReadLine();
            WR("Apellido: ");
            apellido[idx] = Console.ReadLine();
            WR("Sexo: ");
            sexo[idx] = Console.ReadLine();
            WR("Fecha de nacimiento: ");
            nacimiento[idx] = Convert.ToDateTime(Console.ReadLine());
            WR("Carrera: ");
            carrera[idx] = Console.ReadLine();
            WR("Telefono: ");
            tel[idx] = Console.ReadLine();
            WR("Celular: ");
            cel[idx] = Console.ReadLine();
            WR("Correo: ");
            correo[idx] = Console.ReadLine();
            Datos recolectar = new Datos
            {
                Cedula = cedula[idx],
                Nombre = nombre[idx],
                Apellido = apellido[idx],
                Sexo = sexo[idx],
                Date = nacimiento[idx],
                Carrera = carrera[idx],
                Telefono = tel[idx],
                Celular = cel[idx],
                Correo = correo[idx]
            };

            datos.Add(recolectar);
            txt = JsonConvert.SerializeObject(datos, Formatting.Indented);

            idx++;
            Array.Resize(ref cedula, idx + 1);
            Array.Resize(ref nombre, idx + 1);
            Array.Resize(ref apellido, idx + 1);
            Array.Resize(ref sexo, idx + 1);
            Array.Resize(ref nacimiento, idx + 1);
            Array.Resize(ref carrera, idx + 1);
            Array.Resize(ref tel, idx + 1);
            Array.Resize(ref cel, idx + 1);
            Array.Resize(ref correo, idx + 1);
        }
        static void Mostrar()
        {
            int x = datos.Count;
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Cliente " + (i + 1) + "\b\n\b\nCedula: '{0}'\b\nNombre: '{1}'\b\nApellido: '{2}'\b\nSexo: '{3}'\b\nFecha de Nacimiento: '{4}'\b\nCarrera: '{5}'\b\nTelefono: '{6}'\b\nCelular: '{7}'\b\nCorreo: '{8}'\b\n\b\n", datos[i].Cedula, datos[i].Nombre, datos[i].Apellido, datos[i].Sexo, datos[i].Date, datos[i].Carrera, datos[i].Telefono, datos[i].Celular, datos[i].Correo);
            }
        }
        public class Datos
        {
            public string Cedula { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Sexo { get; set; }
            public DateTime Date { get; set; }
            public string Carrera { get; set; }
            public string Telefono { get; set; }
            public string Celular { get; set; }
            public string Correo { get; set; }
        }

    }
}
