using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.clases
{
    public class Habitante : User
    {
        public Habitante():base()
        {
        
            Id_edif = 0;
            rol = 0;
            Piso = "";
            Dpto = "";
            FechaRegHabit = DateTime.MinValue;
        }
        public Habitante(User usr): base(usr)
        {
            Id_edif = 0;
            rol = 0;
            Piso = "";
            Dpto = "";
            FechaRegHabit = DateTime.MinValue;
        }

 
        public int Id_edif { get; set; }
        public int rol { get; set; }
        public string Piso { get; set; }
        public string Dpto { get; set; }
        public DateTime FechaRegHabit { get; set; }


 /*       public void ValidarDatos()
        {
            if (Nombre.Trim() == "" ||
                Apellido.Trim() == "" ||
                Account.Trim() == "" ||
                Password.Trim() == "" ||
                FechaNacimiento == DateTime.MinValue ||
                Sexo == ' ')
            {
 //               throw new DatosFaltantesEx();
            }

 /*           if (!Util.EsEmail(Email))
            {
                throw new EmailExcepcion();
            }

            if (FechaNacimiento > DateTime.Today)
            {
                throw new FechaNacimientoExcepcion();
            }*/
        }
    }
