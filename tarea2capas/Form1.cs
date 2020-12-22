using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassNegocio;
using ClassEntidades;

namespace tarea2capas
{
    public partial class Form1 : Form
    {
        ClassEn estudi = new ClassEn();
        Classnegocio ejecutor = new Classnegocio ();
       // private string opcionFiltro;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = ejecutor.Read();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            try
            {
                estudi.cedula = int.Parse(textCE.Text);
                estudi.nombre = textnombre.Text;
                estudi.edificio = comboBox2.SelectedValue.ToString(); 
                estudi.manzana = comboman.SelectedValue.ToString();
                estudi.apartamento = int.Parse(textApt.Text);

                ejecutor.Create(estudi);
                MessageBox.Show("Valores ingresados!!");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ejecutor.Read();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                estudi.cedula = int.Parse(textCE.Text);
                estudi.nombre = textnombre.Text;
                estudi.edificio = comboBox2.SelectedValue.ToString();
                estudi.manzana = comboman.SelectedValue.ToString();
                estudi.apartamento = int.Parse(textCE.Text);

                ejecutor.modificar(estudi);
                MessageBox.Show("Valores ingresados!!");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            //dataGridView1.DataSource = ejecutor.Read();
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                estudi.cedula = int.Parse(textCE.Text);
                ejecutor.Delete(estudi);
                MessageBox.Show("Valores ingresados!!");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarMAN();
            CargarEDI();
            limpiar();
        }
        public void limpiar()
        {
            textCE.Clear();
            textnombre.Clear();
            textApt.Clear();
            comboBox2.Text = "";
            comboman.Text="";


        }

        public void CargarMAN()
        {
            comboman.DataSource = ejecutor.CargarManza();
            comboman.ValueMember = "Id_Manza";
            comboman.DisplayMember = "manzana";
            comboman.SelectedIndex = -1;
        }
        public void CargarEDI()
        {
            comboBox2.DataSource = ejecutor.CargarEdif();
            comboBox2.ValueMember = "Id_EDI";
            comboBox2.DisplayMember = "edificio";
            comboBox2.SelectedIndex = -1;
        }

        private void comboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textCE.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textnombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboman.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textApt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
