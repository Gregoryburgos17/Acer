using System;

namespace Proyecto_final_XXX
{
    class Program
    {
        static string contacto;
        static int eventos;
        static int utilidaes;
        static void Main(string[] args)
        {

            string[] contacto = new string[100];


            Console.WriteLine("INSERTAR CONTACTO");



            int x = 0;
            Console.WriteLine("NOMBRE");
            Console.ReadLine();
            Console.WriteLine("APELLIDO");
            Console.ReadLine();
            Console.WriteLine("TELEFONO");
            Console.ReadLine();
            Console.WriteLine("CORREO");
            Console.ReadLine();
            Console.WriteLine("DIRECION");
            for (int i=0; i>contacto.Length; i++)
            {
                
            }
            Console.ReadLine();

                

          
        }

        static void  CONTACTOS()
        {
            

            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("[1]GESTIÓN DE CONTACTOS");
            Console.WriteLine("[2]GESTIÓN DE EVENTOS");
            Console.WriteLine("[3]UTILITARIOS");
            Console.WriteLine("[4]SALIR");










        }
        static void EVENTOS()
        {
            int usuario = 0;
            Console.WriteLine("actividad");
            Console.WriteLine("fecha");
            Console.WriteLine("hora");
            Console.WriteLine("lugar");
        }
        static void UTILITARIOS()
        {
            Console.WriteLine("[1]CONVERSIÓN DE UNIDADES");
            Console.WriteLine("[2]CONVERSIÓN DE MONEDAS ");

        }

    }
}
