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
            int num = 0;
            if (System.Environment.MachineName.ToLower() == "agu-ntbk")
            {
                num = 1;
            }
            if (System.Environment.MachineName.ToLower() == "napo-nb")
            {
                num = 2;
            }
            if (System.Environment.MachineName.ToLower() == "vcore1")
            {
                num = 3;
            }
            if (System.Environment.MachineName.ToLower() == "web")
            {
                num = 4;
            }

            SqlConnection conexion = new SqlConnection("Data Source=(local);Initial Catalog=VFM;Integrated Security=True");
            switch (num)
            {
                case 1:
                    conexion = new SqlConnection("Data Source=(local);Initial Catalog=VFM;Integrated Security=True");
                    conexion.Open();

                    return conexion;
                    break;

                case 2:
                    conexion = new SqlConnection("Data Source=(local);Initial Catalog=Administracion_sys;Integrated Security=True");
                    conexion.Open();

                    return conexion;
                    break;

                case 3:
                    conexion = new SqlConnection("Data Source=VCORE1\\SQLEXPRESS;Initial Catalog=VFM;Integrated Security=True");
                    conexion.Open();

                    return conexion;
                    break;

                case 4:
                    conexion = new SqlConnection("Data Source=WEB\\SQLEXPRESS;Initial Catalog=VFM;Integrated Security=True");
                    conexion.Open();

                    return conexion;
                    break;
                default:
                    conexion = new SqlConnection("Data Source=WEB\\SQLEXPRESS;Initial Catalog=VFM;Integrated Security=True");
                    conexion.Open();

                    return conexion;
                    break;
            }



        }

    }
}