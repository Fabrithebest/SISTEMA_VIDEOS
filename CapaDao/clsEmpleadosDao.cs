using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;

namespace CapaCodigo
{
    public class clsEmpleadosDao :clsConexion
    {

        public Boolean VerificarUsuario(clsEmpleadoEntity em,int x)
        {

            SqlCommand cmd = new SqlCommand("SP_ACCESO_USUARIO", Conexion(x));
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
        public Boolean VerificarContra(clsEmpleadoEntity em,int x)
        {

            SqlCommand cmd = new SqlCommand("SP_ACCESO_CONTRA", Conexion(x));
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
    }
}
