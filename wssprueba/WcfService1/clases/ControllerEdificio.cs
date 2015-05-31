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

                        //defino si los deptos usan nombre con letra o solo numeracion
                        //si son numeros
                        //if (edif.edif_deptoletra == 'l')
                        //{
                        //    ASCII = 65;
                        //    //ciclo por cada piso
                        //    while (i <= edif.edif_cantpisos)
                        //    {
                        //        //ciclo por cada depto
                        //        while (j <= edif.edif_deptosxpiso)
                        //        {
                        //            query = "insert into vfm_departamento values (";
                        //            query = query + "'" + edif.cod_edif;
                        //            query = query + "','" + i;
                        //            query = query + "','" + char.ConvertFromUtf32(ASCII);
                        //            query = query + "')";

                        //            cmd.CommandText = query;
                        //            cmd.ExecuteNonQuery();

                        //            ASCII++;
                        //            j++;
                        //        }
                        //        if (edif.edif_deptoletra == 'l')
                        //        {
                        //            ASCII = 97;
                        //        }
                        //        else
                        //        {
                        //            ASCII = 49;
                        //        }
                        //        i++;
                        //    }
                        //}

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