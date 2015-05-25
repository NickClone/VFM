using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService1.clases.excepcions;



public class Amen_hor
{
        public Amen_hor(){
            dia = 0;
            descrip = ""; 
            h_desde = "";
            h_hasta = "";
        }

        public Amen_hor(int _dia,string _descrip, string _h_hasta,string _h_desde)		
        {
            dia = _dia;
            descrip = _descrip; 
            h_desde = _h_desde;
            h_hasta = _h_hasta;

        }

        public int dia { get; set; }
        public string descrip { get; set; }
        public string h_desde { get; set; }
        public string h_hasta { get; set; }
         
        

        public void ValidarDatos()
        {
            
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
  


//[System.Runtime.Serialization.DataContractAttribute()]
//public partial class Person
//{

//    [System.Runtime.Serialization.DataMemberAttribute()]
//    public int id;

//    [System.Runtime.Serialization.DataMemberAttribute()]
//    public string name;

//    [System.Runtime.Serialization.DataMemberAttribute()]
//    public string app;

//}