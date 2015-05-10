using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WcfService1.clases
{
    public class ControllerHabit : ControllerUsuario
    {
        public Habitante habit { get; set; }

        public ControllerHabit(Habitante habit):base(habit)
        {
            
        }
        

        
        public int insupHabit()
        {
            int usu_id = 0;
            string query;
            try
            {
                using (SqlConnection conexion = ConexionDA.ObtenerConexion())
                {

                    query = "insupdHabit " + this.insupdata();
                  



                }

            }
            catch (Exception ex)
            {
                throw new ExceptionGen("Se produjo un error al crear el usuario.", ex);
            }


            return usu_id;

        }



    }
}