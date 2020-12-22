using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        Condominio dominio = new Condominio();
        private string id = null;
        private bool editar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cursoDataSet.Condominio' Puede moverla o quitarla según sea necesario.
            this.condominioTableAdapter.Fill(this.cursoDataSet.Condominio);


        }
        private void mostrarhabitante()
        {
            Condominio domini = new Condominio();
            dataGridView1.DataSource = domini.mostrar();
            dataGridView1.Visible = true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // insertar
            if (editar == false)
            {
                try
                {
                    dominio.InsertHab(txtcedula.Text, txtnombre.Text, txtapt.Text, txtmanzana.Text, txtedificio.Text);
                    MessageBox.Show(" El registro fue existoso...");
                    mostrarhabitante();
                    limpiar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(" error..." + ex);
                }
            }
            //editar
            if (editar == true)
            {
                try
                {
                    dominio.Edit(txtcedula.Text, txtnombre.Text, txtapt.Text, txtmanzana.Text, txtedificio.Text,id);
                    MessageBox.Show(" Los Cambios fueron hechos...");
                    mostrarhabitante();
                    limpiar();
                    editar = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(" error..." + ex);
                }
            }
            
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                txtcedula.Text = dataGridView1.CurrentRow.Cells["cedula"].Value.ToString();
                txtnombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                txtapt.Text = dataGridView1.CurrentRow.Cells["apartamento"].Value.ToString();
                txtmanzana.Text = dataGridView1.CurrentRow.Cells["manzana"].Value.ToString();
                txtedificio.Text = dataGridView1.CurrentRow.Cells["edificio"].Value.ToString();
                id = dataGridView1.CurrentRow.Cells["Id_habitante"].Value.ToString();
            }
            else
                MessageBox.Show("elija habitante a editar!!!!!....");
        }
        private void limpiar()
        {
            txtcedula.Clear();
            txtnombre.Clear();
            txtapt.Clear();
            txtmanzana.Clear();
            txtedificio.Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                
                id= dataGridView1.CurrentRow.Cells["Id_habitante"].Value.ToString();
                dominio.borrar(id);
                MessageBox.Show("habitante  hacido eliminado!!!!!....");
                mostrarhabitante();
               
            }
            else
                MessageBox.Show("elija habitante a editar!!!!!....");
        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mostrarhabitante();
        }

        

        private void cbfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = "EXEC FiltrarManzan " + cbfiltro.Text+"";
            updateGridview(valor, "Condominio");

        }
        public void updateGridview(string valor,string tbl)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(valor, new SqlConnection(Properties.Settings.Default.conexion));
            DataSet dad = new DataSet();
            adapter.Fill(dad, tbl);
            dataGridView1.DataSource = dad;
            dataGridView1.DataMember = tbl;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = "EXEC FiltrarEdificio '" + comboBox1.Text + "'";
            updateGridview(valor, "Condominio");
        }
    }

}

