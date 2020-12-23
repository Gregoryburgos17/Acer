using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoAJeno
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public void AgregarNombre(string nombre)
        {
            Nombre = nombre;
        }
        public void ProductoDisponible()
        {
            Console.WriteLine("Producto: " + Nombre + "\nDescripcion: " + Descripcion + "\n");
        }
    }
    public class VerProducto
    {
        public void Main()
        {
            Producto producto1 = new Producto();
            Producto producto2 = new Producto();


            Console.Write("Ingrese el nombre de su primer producto: ");
            producto1.AgregarNombre(Console.ReadLine());
            Console.Write("Ingrese la descripcion de su primer producto: ");
            producto1.Descripcion = Console.ReadLine();

            Console.Write("Ingrese el nombre de su segundo producto: ");
            producto2.AgregarNombre(Console.ReadLine());
            Console.Write("Ingrese la descripcion de su segundo producto: ");
            producto2.Descripcion = Console.ReadLine();

            Console.Clear();
            producto1.ProductoDisponible();
            producto2.ProductoDisponible();
            Console.ReadKey();
        }
    }
}
