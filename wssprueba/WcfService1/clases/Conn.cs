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
            SqlConnection conexion = new SqlConnection("Data Source=(local);Initial Catalog=VFM;Integrated Security=True");
            switch (System.Environment.MachineName.ToLower())
            {
                case "agu-ntbk":
                    conexion = new SqlConnection("Data Source=(local);Initial Catalog=VFM;Integrated Security=True");
                    conexion.Open();

                    return conexion;
                    break;

                case "napo-nb":
                    conexion = new SqlConnection("Data Source=(local);Initial Catalog=Administracion_sys;Integrated Security=True");
                    conexion.Open();

                    return conexion;
                    break;

                case "vcore1":
                    conexion = new SqlConnection("Data Source=VCORE1\\SQLEXPRESS;Initial Catalog=VFM;Integrated Security=True");
                    conexion.Open();

                    return conexion;
                    break;

                case "web":
                    conexion = new SqlConnection("Data Source=WEB\\SQLEXPRESS;Initial Catalog=VFM;Integrated Security=True");
                    conexion.Open();

                    return conexion;
                    break;
                default:
                    string file;
                    System.IO.StreamReader sr = new
                    System.IO.StreamReader("C:\\gitHub\\VFM\\wssprueba\\WcfService1\\clases\\sqlCon.txt");

                    file = sr.ReadLine();
                    sr.Close();
                    conexion.Open();

                    return conexion;
                    break;
            }
        }
    }
}