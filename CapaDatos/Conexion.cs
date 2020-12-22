using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   
    
    class Conexion
    {
        private SqlConnection conex = new SqlConnection("Data Source =.; Initial Catalog = curso; Integrated Security = True");

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
