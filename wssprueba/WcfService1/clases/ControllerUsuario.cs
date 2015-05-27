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
        public Login log { get; set; }
        public SqlDataReader reader;
        string query;

        public ControllerUsuario(User per)
        {
            this.usr = per;
            query = "";
        }

        public ControllerUsuario(Login log)
        {
            this.log = log;
            query = "";
        }


        public int insupdata()
        {
            int usu_id = 0;
            try
            {
                using (SqlConnection conexion = ConexionDA.ObtenerConexion())
                {
                    query = "insupdUser ";
                    query = query + "'" + usr.Account + "','" + usr.Password + "','";
                    query = query + usr.Nombre + "','" + usr.Apellido + "','" + usr.FechaNacimiento + "','";
                    query = query + usr.Tel + "','" + usr.Sexo + "',";
                    query = query + usr.Estado + ",'" + usr.FechaRegistracion + "','" + usr.FechaActualizacion + "'";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    this.reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        usu_id = reader.GetInt32(0);
                        conexion.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                throw new ExceptionGen("Se produjo un error al crear el usuario.", ex);
            }


            return usu_id;

        }

        public User UsuChk()
        {
            try
            {
                using (SqlConnection conexion = ConexionDA.ObtenerConexion())
                {
                    query = "select * from sys_usuarios where usu_acc = '" + usr.Account + "' and usu_pass = '" + usr.Password + "'";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    SqlDataReader reader2 = cmd.ExecuteReader();

                    if ( reader2.HasRows )
                    {
                        reader2.Read();
                        usr = new User();
                        usr.Id = reader2.GetInt32(0);
                        usr.Account = reader2.GetString(1);
                        usr.Nombre = reader2.GetString(3);
                        usr.Tel = reader2.GetString(5);
                        usr.Apellido = reader2.GetString(7);
                        
                        conexion.Close();
                                              
                    }

                    return usr;
                }
            }
            catch {

                return usr;    
            
            }

        }
    }
}