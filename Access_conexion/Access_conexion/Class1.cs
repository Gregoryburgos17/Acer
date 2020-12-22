using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Access_conexion
{
    public class Conexion
    {
        public static DataSet Ejecutar(string cmd)
        {

            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Acer\Documents\Politicos1.mdb");
            conn.Open();
            DataSet DS = new DataSet();
            OleDbDataAdapter DP = new OleDbDataAdapter(cmd, conn);
            DP.Fill(DS);
            conn.Close();
            return DS;
        }
    }
}
