using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using WcfService1.clases.excepcions;

namespace WcfService1.clases
{
    public class ControllerExpensa
    {
        public Expensa exp { get; set; }

        public ControllerExpensa(Expensa _exp)
        {
            exp = _exp;   
        }

        public string loadExp(){
            string query;
            try
            {
                using (SqlConnection conexion = ConexionDA.ObtenerConexion())
                {
                   
                    query = "[dbo].[ABMexpensas]"+ exp.id_exp + ","+ exp.titulo + "," + exp.cod_edif + "," + exp.pdf + "," + "0";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.ExecuteNonQuery();

                    return "hola";
                }

            }
            catch (Exception ex)
            {
                throw new ExceptionGen("Se produjo un error al crear el usuario.", ex);
            }

            return null;

        }















    }
}