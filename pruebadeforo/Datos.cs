using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace pruebadeforo
{
    class Datos
    {//Escenario A
        SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        SqlCommand sql;


        //Escenario b
        private void Insertar(string matricula, string nombre, string carrera)

        {

             sql = new SqlCommand($"insert into prueba1 values({matricula},{nombre},{carrera})", db);

            db.Open();

            sql.ExecuteNonQuery();

            db.Close();

        }


    }
}
