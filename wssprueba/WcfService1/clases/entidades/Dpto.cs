using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService1.clases.excepcions;



public class Dpto
{
        public Dpto(){
            dpto_piso = "";
            dpto_dpto = "";
        }

        public Dpto(string _dpto_piso,string _dpto_dpto)		
        {
            dpto_dpto = _dpto_dpto;
            dpto_piso = _dpto_piso;

        }

        public string dpto_piso { get; set; }
        public string dpto_dpto { get; set; }
        

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