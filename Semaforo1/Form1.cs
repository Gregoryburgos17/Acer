using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo1
{
    public partial class Form1 : Form
    {
        int caso = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Semaforo1.Properties.Resources.apagado;
            btnapagar.Enabled = false;
            btndetener.Enabled = false;
        }

        private void btencender_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btencender.Enabled = false;
            btnapagar.Enabled = true;
            btndetener.Enabled = true;
            label1.Text = "SEMAFORO ON";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //crear un clase de sepappi donde resivira los datos de la app  y instancial 
            switch (caso)
            {
                case 0:
                    pictureBox1.Image = Semaforo1.Properties.Resources.verde;
                    timer1.Interval = 10000;
                    caso = 1;
                    break;
                case 1: pictureBox1.Image = Semaforo1.Properties.Resources.amarillo;
                    timer1.Interval = 5000;
                    caso = 2;
                    break;
                case 2: pictureBox1.Image = Semaforo1.Properties.Resources.rojo;
                    timer1.Interval = 5000;
                    caso = 0;
                    break;
            }
        }

        private void btndetener_Click(object sender, EventArgs e)
        {
            if (btndetener.Text == "DETENER")
            {
                timer1.Enabled = false;
                btndetener.Text = "REANUDAR";
                label1.Text = "SEMAFORO DETENIDO";
            }
            else
            if (btndetener.Text == "REANUDAR")
            {
                timer1.Enabled = true;
                btndetener.Text = "DETENER";
                label1.Text = "SEMAFORO ON";
            }
                
            
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btencender.Enabled = true;
            btnapagar.Enabled = false;
            btndetener.Enabled = false;
            pictureBox1.Image = Semaforo1.Properties.Resources.apagado;
            label1.Text = "SEMAFORO OFF";
        }
    }
}
