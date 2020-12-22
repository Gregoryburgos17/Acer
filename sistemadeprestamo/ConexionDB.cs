using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace sistemadeprestamo
{

    class ConexionDB
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
       public ConexionDB()
       {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=prueba1;Integrated Security=True");
                cn.Open();
                MessageBox.Show("conexion abierta");
            }
            catch (Exception ex)
            {

                MessageBox.Show("error de conexion" + ex.ToString());
            }
       }
        public string insertar(int id,string nombre,string apellido)
        {
            string salida = "guardado";
            try
            {//para los  string o nvarchar en tu tabla colocas esta sqcrist tabla1(estos son los campos) values (los datos deben de ir en el mismo orden que los campos)
                //para los string ultizaras'"nombre de la variable"'en caso de que sea un  numero ultilizaras solo "" recuerda asi como esta mi sentencia lo debes de hacer
                cmd = new SqlCommand("Insert into Tabla1(nombre,apellido) values('"+nombre+"','"+apellido+"')",cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                salida = "ERROR"+ex.ToString();
            }
            return salida;
        }
        public int registrado(int id)
        {
            int contenedor=0;
            try
            {
                cmd = new SqlCommand("select * from Tabla1 where id="+id+"", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contenedor++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se encuentra"+ex.ToString());
               
            }
            return contenedor; 
        }
        public void CargarRegistro(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from Tabla1",cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se encuentra persona"+ex.ToString());
                
            }
        }
        public void Consulta( int id,TextBox txtnombre,TextBox txtapellido)
        {
            try
            {
                cmd = new SqlCommand("select* from Tabla1 where id="+id+"",cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtnombre.Text = dr["nombre"].ToString();
                    txtapellido.Text = dr["apellido"].ToString();
                }
                dr.Close();
            }
            catch (Exception EX)
            {

                MessageBox.Show("error 101" + EX.ToString());
            }
        }
    }
}
