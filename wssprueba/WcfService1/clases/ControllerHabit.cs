using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using WcfService1.clases.excepcions;

namespace WcfService1.clases
{
    public class ControllerHabit
    {
        public Habitante habit { get; set; }

        public ControllerHabit(Habitante _habit)
        {
            habit = _habit;   
        }
        

        
        public string insupHabit()        {
            ControllerUsuario contU = new ControllerUsuario(habit);
            string query;
            int ret = 0;
                using (SqlConnection conexion = ConexionDA.ObtenerConexion())
                {

                   var num =  contU.insupdata();
                   query = "insupdHabit " + habit.Id_edif + "," + num + "," + habit.rol + ",'" + habit.Piso + "','" + habit.Dpto + "'" ;
                   SqlCommand cmd = new SqlCommand(query, conexion);
                   ret=cmd.ExecuteNonQuery();
                   if (ret > 0)
                   {

                   }
                }

                return "habitante creado";

        }

        public string DeleteHabit()
        {
            ControllerUsuario contU = new ControllerUsuario(habit);
            string query;
            int ret = 0;
            using (SqlConnection conexion = ConexionDA.ObtenerConexion())
            {
                query = "SELECT COUNT(*) FROM vfm_habit WHERE cod_usu = '" + habit.Id + "'";
                SqlCommand cmd = new SqlCommand(query, conexion);
                ret = cmd.ExecuteNonQuery();
                
                // SI EL USUARIO ES HABITANTE EN UN SOLO DEPTO DE UN SOLO EDIFICIO
                if (ret == 1)
                {
                    // DESHABILITAR LA CUENTA DE USUARIO
                    query = "UPDATE sys_usuarios SET estado = -1 WHERE cod_usu = '" + habit.Id + "'";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }

                // ELIMINAR EL HABITANTE ESPECIFICO
                query = "DELETE FROM vfm_habit WHERE cod_edif = '" + habit.Id_edif + "'";
                query = query + " AND cod_usu = '" + habit.Id + "'";
                query = query + " AND dpto_piso = '" + habit.Piso + "'";
                query = query + " AND dpto_dpto = '" + habit.Dpto + "'";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }

            return "habitante eliminado";
        }

    }
}