using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using CapaCodigo;

namespace SISTEMA_VIDEOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           inicio();
        }

        void inicio()
        {
            lblWrongUser.Visible = false;
            label4.Visible = false;
            label2.Visible = false;
            txtContra.Visible = false;
            button1.Visible = false;
        }
        clsEmpleadoEntity oEmpleado = new clsEmpleadoEntity();
        clsEmpleadosDao oEmpleadoDao = new clsEmpleadosDao();
        private void LoginUsu()
        {
            oEmpleado.ususario = this.txtUsu.Text;
            DataTable dt = new DataTable();
            dt = oEmpleadoDao.MostrarFoto();
            if (oEmpleadoDao.VerificarUsuario(oEmpleado) == true)
            {
                label4.Visible = true;

                //button2.Enabled = false;
                button2.Visible = false;

                txtUsu.Visible = false;
                label1.Visible = false;
                lblWrongUser.Visible = false;
                label4.Visible = true;
                label2.Visible = true;
                txtContra.Visible = true;
                button1.Visible = true;
                label4.Text = "Bienvenido Usuario De Correo :   " + txtUsu.Text;
                pictureBox1.Visible = true;
                Byte[] img = (Byte[])dt.Rows[0][8];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
            else
            {
                lblWrongUser.Visible = true;
                lblWrongUser.ForeColor = Color.Red;
                lblWrongUser.Text = "Usuario no encontrado ";
                this.txtUsu.Clear();
                this.txtUsu.Focus();
                //button3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inicio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoginUsu();
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            oEmpleado.clave = this.txtContra.Text;
            if (oEmpleadoDao.VerificarContra(oEmpleado) == true)
            {
                lblWrongUser.Visible = false;
                MessageBox.Show("BIENVENIDOS AL SISTEMA:... " + txtUsu.Text);
                //mostrar el formulario menú o dni(padre)
                Form2 menu = new Form2();
                menu.Show();
                //ocultar el login
                this.Hide();
            }
            else
            {
                lblWrongUser.Visible = true;
                lblWrongUser.Text = "Contraseña incorrecta";
                this.txtUsu.Clear();
                this.txtContra.Clear();
                this.txtUsu.Focus();
            }
        }
    }
}
