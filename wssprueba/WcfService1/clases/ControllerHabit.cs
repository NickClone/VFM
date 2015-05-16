using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WcfService1.clases.excepcions;

namespace WcfService1.clases
{
    public class ControllerHabit : ControllerUsuario
    {
        public Habitante habit { get; set; }

        public ControllerHabit(Habitante habit):base(habit)
        {
            
        }
        

        
        public void insupHabit()
        {
            string query;
            try
            {
                using (SqlConnection conexion = ConexionDA.ObtenerConexion())
                {

                    query = "insupdHabit " + habit.Id_edif + "," + this.insupdata() + "," + habit.rol + ",'" + habit.Piso + "','" + habit.Dpto + "'" ;
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                throw new ExceptionGen("Se produjo un error al crear el usuario.", ex);
            }

        }



    }
}