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
                    query = "insupdUser " + usr.Id;
                    query = query + ",'" + usr.Account + "','" + usr.Password + "','";
                    query = query + usr.Nombre + "','" + usr.Apellido + "','" + usr.FechaNacimiento + "','";
                    query = query + usr.Tel + "','" + usr.Sexo + "',";
                    query = query + usr.Estado;

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
                    // BUSCA USUARIO
                    query = "SELECT cod_usu FROM sys_usuarios WHERE usu_acc = '" + usr.Account + "'";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    SqlDataReader reader2 = cmd.ExecuteReader();

                    // SI USUARIO EXISTE
                    if (reader2.HasRows)
                    {
                        reader2.Read();
                        // BUSCO PASSWORD
                        query = "SELECT * FROM sys_usuarios WHERE cod_usu = " + (reader2.GetInt32(0)) + " AND usu_pass = '" + usr.Password + "'";
                        cmd.CommandText = query;
                        reader2.Close();
                        reader2 = cmd.ExecuteReader();

                        // SI PASSWORD COINCIDE
                        if (reader2.HasRows)
                        {
                            reader2.Read();

                            usr.Id = reader2.GetInt32(0);
                            usr.Account = reader2.GetString(1);
                            usr.Nombre = reader2.GetString(3);
                            usr.Apellido = reader2.GetString(4);
                            usr.Tel = reader2.GetString(6);
                            usr.Perfil = reader2.GetString(11).Trim();

                            reader2.Close();

                            if (usr.Perfil == "1")
                            {
                                Habitante habit = new Habitante(usr);


                                query = "select * from vfm_habit where cod_usu = '" + usr.Id + "'";

                                cmd.CommandText = query;
                                reader2 = cmd.ExecuteReader();
                                if (reader2.HasRows)
                                {
                                    reader2.Read();
                                    habit.Id_edif = reader2.GetInt32(0);
                                    habit.Piso = reader2.GetString(3);
                                    habit.Dpto = reader2.GetString(4);
                                }
                                conexion.Close();
                                reader2.Close();

                                return (User)habit;
                            }
                            if (usr.Perfil == "2")
                            {

                                Administrator Admin = new Administrator(usr);


                                query = "select nom_admin,horario,cod_edif,edif_calle,Edif_num from vfm_EdifxAdmin A ";
                                query = query + " inner join vfm_edif E on A.edif_id = E.cod_edif " ;
                                query = query + " where usu_id = " + usr.Id;

                                cmd.CommandText = query;
                                reader2 = cmd.ExecuteReader();
                              
                                
                                //if (reader2.HasRows)
                                //{
                                //    reader2.Read();
                                //    Admin.Nom_Company = reader2.GetString(1);
                                //    Admin.horario_consul = reader2.GetString(2);
                                //}
                                while(reader2.Read()){
                                
                                    Admin.LEdif.Add(new Edificio(reader2.GetInt32(2),reader2.GetString(3),reader2.GetDecimal(4)));
                                
                                }


                                conexion.Close();
                                reader2.Close();

                                return (User)Admin;
                            }
                        }
                        // SI PASSWORD NO COINCIDE
                        else
                        {
                            // EL STRING ESTA SOLO A MODO ILUSTRATIVO
                            string passError = "El password esta incorrecto";
                            usr = null;
                        }

                    }
                    // SI USUARIO NO EXISTE
                    else
                    {
                        // EL STRING ESTA SOLO A MODO ILUSTRATIVO
                        string UserError = "el usuario no existe";
                        usr = null;
                    }

                    return usr;

                }
            }
            catch (Exception ex)
            {
                throw new ExceptionGen("Se produjo un error al loggear", ex);
            }

        }
    }
}