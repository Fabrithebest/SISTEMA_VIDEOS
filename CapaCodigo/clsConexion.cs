using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaCodigo
{
    public abstract class clsConexion
    {
        protected SqlConnection Conexion()
        {
            SqlConnection cnx = new SqlConnection("Data Source = SQL5028.site4now.net; User ID = DB_A3CDDC_SISTEMAVideos_admin; Password = Fa8R12i0;"); 
                 cnx.Open();
                return cnx;
                             
        }


    }
}
