using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        int x = 0;
        clsEmpleadoEntity oEmpleado = new clsEmpleadoEntity();
        clsEmpleadosDao oEmpleadoDao = new clsEmpleadosDao();
        private void LoginUsu()
        {
            oEmpleado.ususario = this.txtUsu.Text;
            if (oEmpleadoDao.VerificarUsuario(oEmpleado,x) == true)
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
                rdbcon.Visible = false;
                rdbSin.Visible = false;
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
            rdbcon.Checked = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoginUsu();
            CheckedButtons();
            
        }
        private void CheckedButtons()
        {
            if (rdbcon.Checked)
            {
                x = 1;
            }
            else
            {
                x = 2;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            oEmpleado.clave = this.txtContra.Text;
            if (oEmpleadoDao.VerificarContra(oEmpleado,x) == true)
            {
                MessageBox.Show("BIENVENIDOS AL SISTEMA:... " + txtUsu.Text);
                //mostrar el formulario menú o dni(padre)
                Form2 menu = new Form2();
                menu.Show();
                //ocultar el login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta ");
                this.txtUsu.Clear();
                this.txtContra.Clear();
                this.txtUsu.Focus();
            }
        }
    }
}
