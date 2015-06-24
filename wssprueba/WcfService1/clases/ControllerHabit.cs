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

                return "lalal";

        }



    }
}