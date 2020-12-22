using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemadeprestamo
{
    public partial class Form1 : Form
    {

        ConexionDB conexio = new ConexionDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
            ConexionDB conexion = new ConexionDB();
            conexion.CargarRegistro(dataGridView1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //esto es para el id en caso del que el usario tenga que poner su cedula
            /*if (conexio.registrado(Convert.ToInt32(txtId.Text)) == 0)
            {
                MessageBox.Show(conexio.insertar(Convert.ToInt32(txtId.Text), txtnombre.Text, txtapellido.Text));
            }*/
            MessageBox.Show(conexio.insertar(Convert.ToInt32(txtId.Text), txtnombre.Text, txtapellido.Text));
            conexio.CargarRegistro(dataGridView1);
            txtId.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             

        }
    }
}
