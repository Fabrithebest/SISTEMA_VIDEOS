using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaCodigo;
using CapaDao;
using CapaEntidades;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
namespace SISTEMA_VIDEOS
{
    public partial class frmEmpleado : Form
    {
        clsEmpleadoEntity oEmpleEntity = new clsEmpleadoEntity();
        clsEmpleadosDao oDaoEmpleado = new clsEmpleadosDao();
        public frmEmpleado()
        {
            InitializeComponent();
        }
        
        private void frmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") || txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Falta de llenar un campo");
            }
            else
            {
                oEmpleEntity.nombre = txtNombre.Text;
                oEmpleEntity.apellido = txtApellido.Text;
                oEmpleEntity.email = txtEmail.Text;
                oEmpleEntity.ususario =txtUsuario.Text;
                oEmpleEntity.clave =txtClave.Text;
                oEmpleEntity.telefono =txtTelefono.Text;
                oDaoEmpleado.InsertarEmpleado(oEmpleEntity, pcbFoto);             
                MessageBox.Show("Empelado insertado");
            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName.Equals("") == false)
                {
                    pcbFoto.Load(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo cargar la imagen" + ex.ToString());
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lblCodEmpelado.Text.Equals(""))
            {
                MessageBox.Show("No selecciono ningun empleado");
            }
            else
            {

                oEmpleEntity.idEmpleado = Convert.ToInt32(lblCodEmpelado.Text);
                oDaoEmpleado.EliminarEmpleado(oEmpleEntity);


                MessageBox.Show("Empelado eliminado");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") || txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Falta de llenar un campo");
            }
            else
            {
                oEmpleEntity.idEmpleado = Convert.ToInt32(lblCodEmpelado);
                oEmpleEntity.nombre = txtNombre.Text;
                oEmpleEntity.apellido = txtApellido.Text;
                oEmpleEntity.email = txtEmail.Text;
                oEmpleEntity.ususario = txtUsuario.Text;
                oEmpleEntity.clave = txtClave.Text;
                oEmpleEntity.telefono = txtTelefono.Text;
                oDaoEmpleado.ModificarEmpleado(oEmpleEntity, pcbFoto);
                MessageBox.Show("Empelado modificado");
            }
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodEmpelado.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtUsuario.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            txtClave.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
            txtTelefono.Text = dgvEmpleados.CurrentRow.Cells[7].Value.ToString();
            Byte[] img = (Byte[])dgvEmpleados.CurrentRow.Cells[8].Value;
            MemoryStream ms = new MemoryStream(img);
            pcbFoto.Image = Image.FromStream(ms);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DataTable dt = new DataTable();
                oEmpleEntity.nombre = txtNombre.Text;
                dt = oDaoEmpleado.BuscarxNombre(oEmpleEntity);
                dgvEmpleados.DataSource = dt;
            }
        }
    }
}
