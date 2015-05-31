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
        

        
        public string insupHabit()
        {
            ControllerUsuario contU = new ControllerUsuario(habit);
            string query;
            try
            {
                using (SqlConnection conexion = ConexionDA.ObtenerConexion())
                {

                   var num =  contU.insupdata();
                    query = "insupdHabit " + habit.Id_edif + "," + num + "," + habit.rol + ",'" + habit.Piso + "','" + habit.Dpto + "'" ;
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.ExecuteNonQuery();

                    return "hola";
                }

            }
            catch (Exception ex)
            {
                throw new ExceptionGen("Se produjo un error al crear el usuario.", ex);
            }

        }



    }
}