using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace systema017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparah, int lparam);

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (menu1.Width == 121)
            {
                menu1.Width = 80;
            }
            else menu1.Width = 121;

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
                
        }

        private void Espandir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            restaurar.Visible = true;
            espandir.Visible = false;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            espandir.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);

        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
