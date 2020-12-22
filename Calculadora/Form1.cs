using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double p1;
        double p2;
        double total;
        string operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
                
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text+"1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            p1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            p1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            operacion = "x";
            p1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            operacion = "/";
            p1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnigu_Click(object sender, EventArgs e)
        {
            p2 = double.Parse(pantalla.Text);

            switch (operacion) {
                case "+": total = p1 + p2;
                    pantalla.Text = total.ToString();
                    break;
                case "-":  total = p1 - p2;
                    pantalla.Text = total.ToString();
                    break;
                case "x":total = p1 * p2;
                    pantalla.Text = total.ToString();
                    break;
                case "/": total = p1 / p2;
                    pantalla.Text = total.ToString();
                    break;



            }
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }
    }
}
