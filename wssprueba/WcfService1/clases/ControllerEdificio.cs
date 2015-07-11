using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using WcfService1.clases.excepcions;

namespace WcfService1.clases
{
    public class ControllerEdificio
    {
        public Edificio edif { get; set; }
        public SqlDataReader reader;
        string query;

        public ControllerEdificio(Edificio ed)
        {
            this.edif = ed;
            query = "";
        }
        public ControllerEdificio(int cod_ed)
        {
            edif = new Edificio();
            edif.cod_edif = cod_ed;
            query = "";
        }
        public void getEdifbyId(int id) { 
        
        
        }

        public List <Habitante> getListHabit()
        {
            try
            {
                using (SqlConnection conexion = ConexionDA.ObtenerConexion())
                {

                    query = "[vfm_ListHabitxEdif]" + edif.cod_edif;
                    List <Habitante> HabitList = new List <Habitante> ();
                    
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    this.reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        
                        Habitante habit = new Habitante();

                        habit.Id = reader.GetInt32(0);
                        habit.Nombre = reader.GetString(1);
                        habit.Apellido = reader.GetString(2);
                        habit.Password = reader.GetString(3);
                        habit.Tel = reader.GetString(4);
                        habit.FechaNacimiento = reader.GetString(5);
                        habit.Sexo = reader.GetString(6).First();
                        habit.rol = reader.GetInt32(7);
                        habit.Dpto = reader.GetString(9);
                        habit.Piso = reader.GetString(10);
                        habit.Account = reader.GetString(11);

                        HabitList.Add(habit);

                       
                    }
                    reader.Close();
                    conexion.Close();

                    return HabitList;

                }
            }
            catch (Exception ex) {

                return null;
            }

        }

        public int Alta()
        {
            edif.cod_edif = 0;
            edif.estado = 1;

            try
            {
                using (SqlConnection conexion = ConexionDA.ObtenerConexion())
                {
                    query = "insupdEdif ";
                    query = query + "'" + edif.cod_edif;
                    query = query + "','" + edif.edif_calle;
                    query = query + "','" + edif.edif_num;
                    query = query + "','" + edif.edif_cp;
                    query = query + "','" + edif.edif_country;
                    query = query + "','" + edif.edif_prov;
                    query = query + "','" + edif.edif_loc;
                    query = query + "','" + edif.estado;
                    query = query + "','" + edif.edif_nombre;
                    query = query + "'";


                    SqlCommand cmd = new SqlCommand(query, conexion);
                    this.reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        edif.cod_edif = reader.GetInt32(0);
                        reader.Close();

                        var pbsi=0;    
                        int ASCII = 49;
                        //defino si tengo deptos en PB o no
                        if (edif.edif_tienepb)
                        {
                            pbsi = 0;
                        }
                        else {
                            pbsi = 1;
                        }
                        if (edif.edif_deptoletra == 'l') {

                            ASCII = 65;
                        
                        }

                        for (int i = pbsi; i <= edif.edif_cantpisos;i++ ) {

                           
        
                            for (int j = 1; j <= edif.edif_deptosxpiso; j++) {

                                query = "insert into vfm_departamento values (";
                                query = query + "'" + edif.cod_edif;
                                query = query + "','" + i;
                                query = query + "','" + char.ConvertFromUtf32(ASCII);
                                query = query + "')";

                                cmd.CommandText = query;
                                cmd.ExecuteNonQuery();

                                ASCII++;
                                      
                            }

                            ASCII = ASCII - edif.edif_deptosxpiso;
                        }

                    }

                    conexion.Close();
                }
            }


            catch (Exception ex)
            {
                return 3;
            }

            return edif.cod_edif;

        }

    }
}