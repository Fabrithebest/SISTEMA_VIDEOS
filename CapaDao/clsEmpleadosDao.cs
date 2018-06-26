using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace CapaCodigo
{
    public class clsEmpleadosDao :clsConexion
    {

        public Boolean VerificarUsuario(clsEmpleadoEntity em)
        {

            SqlCommand cmd = new SqlCommand("SP_ACCESO_USUARIO", Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USU", em.ususario);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean VerificarContra(clsEmpleadoEntity em)
        {

            SqlCommand cmd = new SqlCommand("SP_ACCESO_CONTRA", Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CONTRA", em.clave);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void InsertarEmpleado(clsEmpleadoEntity vX,PictureBox foto)
        {

            SqlCommand cmd = new SqlCommand("SP_EMPLEADO_INSERTAR", Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMBRE ", vX.nombre);
            cmd.Parameters.AddWithValue("@APELLIDO ", vX.apellido);
            cmd.Parameters.AddWithValue("@EMAIL ", vX.email);
            cmd.Parameters.AddWithValue("@USUARIO ", vX.ususario);
            cmd.Parameters.AddWithValue("@CLAVE ", vX.clave);
            cmd.Parameters.AddWithValue("@TELEFONO ", vX.telefono);
            cmd.Parameters.AddWithValue("@FOTO", SqlDbType.Image);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@FOTO"].Value = ms.GetBuffer();
            cmd.ExecuteNonQuery();
        }
        public void ModificarEmpleado(clsEmpleadoEntity vX, PictureBox foto)
        {

            SqlCommand cmd = new SqlCommand("SP_EMPLEADO_MODIFICAR", Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDEMPLEADO ", vX.idEmpleado);
            cmd.Parameters.AddWithValue("@NOMBRE ", vX.nombre);
            cmd.Parameters.AddWithValue("@APELLIDO ", vX.apellido);
            cmd.Parameters.AddWithValue("@EMAIL ", vX.email);
            cmd.Parameters.AddWithValue("@USUARIO ", vX.ususario);
            cmd.Parameters.AddWithValue("@CLAVE ", vX.clave);
            cmd.Parameters.AddWithValue("@TELEFONO ", vX.telefono);
            cmd.Parameters.AddWithValue("@FOTO", SqlDbType.Image);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@FOTO"].Value = ms.GetBuffer();
            cmd.ExecuteNonQuery();
        }
        public void EliminarEmpleado(clsEmpleadoEntity vX)
        {

            SqlCommand cmd = new SqlCommand("SP_EMPLEADO_ELIMINAR", Conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD", vX.idEmpleado);
            cmd.ExecuteNonQuery();
        }
        public DataTable BuscarxNombre(clsEmpleadoEntity vX)
        {
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_NOM_EMPLEADO", Conexion());
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cmd.Parameters.AddWithValue("@NOMBRE", vX.nombre);

            DataTable dt = new DataTable("empleado");
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
        public DataTable MostrarFoto()
        {
            SqlCommand cmd = new SqlCommand("Select * from EMPLEADO", Conexion());
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
    }
}
