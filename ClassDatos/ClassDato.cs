using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassEntidades;

namespace ClassDatos
{
    public class ClassDato
    {

        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand comando;
        Conexion con = new Conexion();


        public void Create(ClassEn estudi)
        {
             conex.Open();
            comando = new SqlCommand($"insert into Condominio(cedula,nombre,edificio,manzana,apartamento) values" +
                $" ({estudi.cedula},'{estudi.nombre}', '{estudi.edificio}', '{estudi.manzana}','{estudi.apartamento}')", conex);//Crear comando
            comando.ExecuteNonQuery();//Ejecutar comando
            conex.Close();//Cerrar conexion

        }
        public DataTable Read()
        {
            conex.Open();//Abrir Conexion
            comando = new SqlCommand("CargarTodos", conex);
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();//Ejecutar comando
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            conex.Close();//Cerrar conexion
            return tabla;
        }

        public void Update(ClassEn hab)
        {
            conex.Open();
            comando = new SqlCommand($"update Condominio set nombre = '{hab.nombre}', manzana = '{hab.manzana}', edificio = '{hab.edificio}', apartamento = '{hab.apartamento}' where cedula = '{hab.cedula}';", conex);
            comando.ExecuteNonQuery();
          

        }
        public void Delete(ClassEn estudi)
        {
            conex.Open();
            comando = new SqlCommand($"Delete from Condominio where cedula ={estudi.cedula}", conex);
            comando.ExecuteNonQuery();
            conex.Close();

        }
        public DataTable CargarMAN()
        {
            conex.Open();
            comando = new SqlCommand("select * from Manzana", conex);
            comando.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            conex.Close();
            return tabla;
        }
        public DataTable CargarEDI()
        {
            conex.Open();
            comando = new SqlCommand("select * from Edificio", conex);
            comando.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            conex.Close();
            return tabla;

        }
        public DataTable FiltrarManzana(string valor)
        {

            conex.Open();

            comando = new SqlCommand("FiltrarManzana", conex);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@valor", valor);

            comando.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            conex.Close();

            return tabla;

        }
        public DataTable FiltrarEdificio(string valor)
        {
            conex.Open();

            comando = new SqlCommand("FiltrarEdificio", conex);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@valor", valor);

            comando.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            conex.Close();

            return tabla;


        }
    }
    class Conexion
    {
        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public SqlConnection Abrirconex()
        {
            if (conex.State == ConnectionState.Closed)
                conex.Open();
            return conex;
        }
        public SqlConnection Cerraconex()
        {
            if (conex.State == ConnectionState.Open)
                conex.Close();
            return conex;
        }
    }
}
