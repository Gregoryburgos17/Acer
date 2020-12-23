using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorWeb
{
    public partial class Form1 : Form
    {
        List<string> favoritos = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.do");
            txtdirecion.Text = "www.google.com.do";
        }

        private void btnir_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtdirecion.Text);
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnfavorito_Click(object sender, EventArgs e)
        {
            favoritos.Add(webBrowser1.Url.ToString());
            agregarF();
        }
        private void agregarF()
        {
            cmbfavorito.Items.Clear();
            foreach (string direcion in favoritos)
            {
                cmbfavorito.Items.Add(direcion);
            }
        }

        private void cmbfavorito_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cmbfavorito.SelectedItem.ToString());
        }
    }
}
