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
            int edif_id = 0;
            edif.estado = 1;
            try
            {
                using (SqlConnection conexion = ConexionDA.ObtenerConexion())
                {
                    query = "insert into vfm_edif values (";
                    query = query + "'" + edif.edif_calle;
                    query = query + "','" + edif.edif_country;
                    query = query + "','" + edif.edif_cp;
                    query = query + "','" + edif.edif_loc;
                    query = query + "','" + edif.edif_num;
                    query = query + "','" + edif.edif_prov;
                    query = query + "','" + edif.estado;
                    query = query + "')";


                    SqlCommand cmd = new SqlCommand(query, conexion);
                    this.reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        edif_id = reader.GetInt32(0);
                        conexion.Close();
                    }
                }

            }
            catch
            {

            }


            return edif_id;
        }

    }
}