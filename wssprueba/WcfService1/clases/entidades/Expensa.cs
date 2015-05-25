using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService1.clases.excepcions;



public class Expensa
{
        public Expensa(){
            id_exp = 0;
            titulo = "";
            ruta = "";
        }

        public Expensa(int _id_exp, string _titulo, string _ruta)		
        {
            id_exp = _id_exp;
            titulo = _titulo;
            ruta = _ruta;
        }

        public int id_exp { get; set; }
        public string titulo { get; set; }
        public string ruta { get; set; }
            

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