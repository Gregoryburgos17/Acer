using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pruebadeforo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);


        private void Form1_Load(object sender, EventArgs e)
        {

            SqlCommand sql = new SqlCommand("select * from prueba1", db);

            DataTable tabla = new DataTable();

            db.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql);

            da.Fill(tabla);

            db.Close();

            for (int x = 0; x < tabla.Rows.Count; x++)

            {

                comboBox1.Items.Add(tabla.Rows[x].ItemArray[2].ToString());

            }


        }
    }
}
