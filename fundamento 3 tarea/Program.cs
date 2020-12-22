using System;
using System.net;

struct SystemChar{};
namespace fundamento_3_tarea
{
    class Program
    {

        private string Leer(string txt)
        {
            Console.WriteLine(txt);
            string val= Console.ReadLine();
            return val;
        }
        private void program()
        {
         Console.Clear();
         Console.WriteLine("Programa para capturar datos");
            nombre=Leer("ingrese su nombre");
            apellido=Leer("ingrese su apellido");
            direcion=Leer("ingrese su direcion");
            tsangre=Leer("ingrese su tipo de sangre");
            genero=Leer("ingrese su genero");
            estudio=Leer("ingrese su nombre");
            trabajo=Leer("ingrese su nombre");
            correo=Leer("ingrese su nombre");
            obvida=Leer("ingrese su nombre");

        }
        static void Main(string[] args)
        {
            string nombre, apellido,direcion,tsangre,correo,genero,estudio,trabajo,obvida,red;
            
            int telefono,fechadenacimiento;
            Console.WriteLine("digite el nombre ");
            nombre=(Console.ReadLine());


            Console.WriteLine("digite  su apellido ");
            apellido=(Console.ReadLine());
            Console.WriteLine("digite  su direcion ");
            direccion=(Console.ReadLine());
            Console.WriteLine("digite el tipo de sangre ");
            tsangre=(Console.ReadLine());
            Console.WriteLine("digite su correo ");
            correo=(Console.ReadLine());
            Console.WriteLine("digite su genero ");
            genero=(Console.ReadLine());
            Console.WriteLine("digite sus estudios realizados ");
            estudio=(Console.ReadLine());
            Console.WriteLine("digite trabajos realizados ");
            trabajo=(Console.ReadLine());
            Console.WriteLine("objetivo de vida ");
            obvida=(Console.ReadLine());
            Console.WriteLine("link de su red social favorita ");
            red=(Console.ReadLine());
            Console.WriteLine("digite su cedula ");
            int cedula=Convert.ToInt32(Console.ReadLine)();
            Console.WriteLine("digite el telefeno ");
            telefono=(Console.ReadLine());
            Console.WriteLine("digite su fecha de nacimiento");
            int fechadenacimiento=Covert.ToInt32(Console.ReadLine());
           
            string ruta="C:\\FCKGW\\";
            if (Directory.Exists(ruta)==false)
            {
              Directory.CreateDirectory(ruta);  
            }                   
            string color=(genero.ToLower()=="f")?"pink":"#cccccc";
            string contenido="<html>"+
             "<head>"+
             "</head>"+
             "<body style='background:"+color+"'>"+
             "<table border='1'> <tr><th>Nombre</th><td>"+nombre+
            "<table> <tr><th>Direcion</th><td>"+direcion+
            "<table> <tr><th>genero</th><td>"+genero+
            "<table> <tr><th>telefono</th><td>"+telefono+
            "<table> <tr><th>cedula</th><td>"+cedula+
            "<table> <tr><th>t.sangre</th><td>"+tsangre+
            "<table> <tr><th>correo</th><td>"+correo+
            "<table> <tr><th>fecha de nacimiento</th><td>"+fechadenacimiento+
            "<table> <tr><th>estudios realizados</th><td>"+estudio+
            "<table> <tr><th>trabajos realizados</th><td>"+trabajo+
            "<table> <tr><th>objetivos de vida</th><td>"+obvida+
            "<table> <tr><th>link de red social favorita</th><td>"+red+
            "<table> <tr><th>registro completo</th><td>"+"</td></tr></table></boby>"+
            "</html>";




        }







    }
}
