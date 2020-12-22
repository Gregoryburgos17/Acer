using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class Consulta
    {
        private Conexion conex = new Conexion();
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        public DataTable mostrar()
        {
            cmd.Connection = conex.Abrirconex();
            cmd.CommandText = "CargarTodos";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            conex.Cerraconex();
            return dt;
        }
        public void Insertar(int cedula,string nombre,string apartamento,int manzana,int edificio)
        {
            cmd.Connection = conex.Abrirconex();
            cmd.CommandText = "crear";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", cedula);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apartamento", apartamento);
            cmd.Parameters.AddWithValue("@manzana", manzana);
            cmd.Parameters.AddWithValue("@edificio", edificio);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public void editar(int cedula, string nombre, string apartamento, int manzana, int edificio,int id)
        {
            cmd.Connection = conex.Abrirconex();
            cmd.CommandText = "editar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", cedula);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apartamento", apartamento);
            cmd.Parameters.AddWithValue("@manzana", manzana);
            cmd.Parameters.AddWithValue("@edificio", edificio);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public void Eliminar(int id)
        {
            cmd.Connection = conex.Abrirconex();
            cmd.CommandText = "eliminar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
             


        }
        
        

    }
}
