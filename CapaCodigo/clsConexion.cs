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
        protected SqlConnection Conexion(int x)
        {
            string sql="";
            SqlConnection cnx = new SqlConnection(sql);
            switch (x)
            {
                case 1:
                    sql = "Data Source=.;Initial Catalog=SISTEMA_VIDEOS;Integrated Security=True";
                    cnx= new SqlConnection
                    break;
                case 2:
                    sql = "Data Source = SQL5028.site4now.net; User ID = DB_A3CDDC_SISTEMAVideos_admin; Password = Fa8R12i0;";
                    SqlConnection cnx = new SqlConnection(sql);
                    break;

            }
                 cnx.Open();
                return cnx;
                             
        }
        //protected SqlConnection ConecctWI()
        //{
        //    SqlConnection cnx = new SqlConnection("Data Source=SQL5028.site4now.net;User ID=DB_A3CDDC_SISTEMAVideos_admin;Password=Fa8R12i0;");
        //    cnx.Open();
        //    return cnx;
        //}



    }
}
