using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using WcfService1.clases.excepcions;

namespace WcfService1.clases
{
    public class ControllerUsuario
    {
        public User usr { get; set; }
        public Login log;
        public SqlDataReader reader;
        string query;

        public ControllerUsuario(User per)
        {
            this.usr=per;
            query = "";
        }

        public ControllerUsuario(Login log)
        {
            this.log = log;
            query = "";
        }

        
      
                
        public int insupdata()
        {
            int usu_id=0;
            try
            {
                using (SqlConnection conexion = ConexionDA.ObtenerConexion())
                {
                    query = "insupdUser ";
                    query = query + "'" + usr.Account + "','" + usr.Password + "','";
                    query = query + usr.Nombre + "','" + usr.Apellido + "','" + usr.FechaNacimiento + "','";
                    query = query + usr.Tel + "','" + usr.Sexo + "',";
                    query = query + usr.Estado + ",'" + usr.FechaRegistracion + "','" + usr.FechaActualizacion + "'"; 

                    SqlCommand cmd = new SqlCommand(query,conexion);
                    reader = cmd.ExecuteReader();
                    usu_id = reader.GetInt32(0);
                    conexion.Close();
                }
                
            }
            catch (Exception ex)
            {
               throw new ExceptionGen("Se produjo un error al crear el usuario.", ex);
            }


            return usu_id;
  
        }

        public string UsuChk() {

            try
            {
                using (SqlConnection conexion = ConexionDA.ObtenerConexion())
                {

                    query = "select 1 from sys_usuarios where usu_acc = '" + log.usr + "' and usu_pass = '" + log.pass + "'";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    reader = cmd.ExecuteReader();
                    conexion.Close();

                }

            }
            catch {

                return "baad";
            
            };
            if (reader.GetInt32(0) == 1)
            {

                return "ok";

            }
            else
            {

                return "wrong pass";
            }

        }


    }


}