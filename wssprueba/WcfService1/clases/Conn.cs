﻿using System;
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
            SqlConnection conexion = new SqlConnection("Data Source=(local);Initial Catalog=Administracion_sys;Integrated Security=True");
            conexion.Open();

            return conexion;
        }
    }
}