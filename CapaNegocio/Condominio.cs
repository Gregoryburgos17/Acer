using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;


namespace CapaNegocio
{
    public class Condominio
    {
        private Consulta consulta = new Consulta();
        public DataTable mostrar()
        {
            DataTable table = new DataTable();
            table = consulta.mostrar();
            return table;
        }
        public void InsertHab (string cedula, string nombre, string apartamento, string manzana, string edificio)
        {
            consulta.Insertar(Convert.ToInt32(cedula),nombre,apartamento, Convert.ToInt32(manzana),  Convert.ToInt32( edificio));
        }
        public void Edit(string cedula, string nombre, string apartamento, string manzana, string edificio,string id)
        {
            consulta.editar(Convert.ToInt32(cedula), nombre, apartamento, Convert.ToInt32(manzana), Convert.ToInt32(edificio), Convert.ToInt32(id));
        }
        public void borrar(string id)
        {
            consulta.Eliminar(Convert.ToInt32(id));

        }
        

    }
}
