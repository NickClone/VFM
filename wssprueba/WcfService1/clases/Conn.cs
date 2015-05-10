using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WcfService1.clases
{
    internal class ConexionDA
    {
        private ConexionDA()
        {
        }

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Data Source=NAPO-NB;Initial Catalog=Administracion_Sys;Integrated Security=True"].ConnectionString);
            conexion.Open();

            return conexion;
        }
    }
}