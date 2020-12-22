using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicaciónMulticapas
{
    public partial class Form1 : Form
    {
        conexion1 conexion = new conexion1();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            Txtce.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text="";
            btnguadar.Text = "Guardar";
            btnborrar.Enabled = false;
            conexion.id = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            popDataGri();
        }

        private void btnguadar_Click(object sender, EventArgs e)
        {
            conexion.cedula = Txtce.Text.Trim();
            conexion.nombre = textBox2.Text.Trim();
            conexion.manzana = int.Parse(textBox3.Text.Trim());
            conexion.edificio = int.Parse(textBox4.Text.Trim());
            conexion.apartamento= textBox5.Text.Trim();
            using (DBEntities db=new DBEntities())
            {
                if (conexion.id == 0)//inserta los datos
                    db.conexion1.Add(conexion);
                else
                    db.Entry(conexion).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            popDataGri();
            MessageBox.Show("Guardado con exito..");
        }
        void popDataGri()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {//dataGridView1
                dataGridView1.DataSource = db.conexion1.ToList<conexion1>();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Index != -1)
            {
                conexion.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                using (DBEntities db = new DBEntities())
                {
                    conexion = db.conexion1.Where(x => x.id == conexion.id).FirstOrDefault();
                    Txtce.Text = conexion.cedula;
                    textBox2.Text = conexion.nombre;
                    textBox3.Text=conexion.manzana.ToString();
                    textBox4.Text = conexion.edificio.ToString();
                    textBox5.Text = conexion.apartamento;
                }
                btnguadar.Text = "actualizar";
                btnborrar.Enabled = true;
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("esta seguro","EF CRUD Operation",MessageBoxButtons.YesNo)== DialogResult.Yes) {
                using (DBEntities db = new DBEntities())
                {//dataGridView1
                    var entry = db.Entry(conexion);
                    if (entry.State == EntityState.Detached)
                        db.conexion1.Attach(conexion);
                    db.conexion1.Remove(conexion);
                    db.SaveChanges();
                    popDataGri();
                    Clear();
                    MessageBox.Show("Eliminado 45 segundos.");
                }
            }
        }
    }
}
