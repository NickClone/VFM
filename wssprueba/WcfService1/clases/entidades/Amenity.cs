using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService1.clases.excepcions;



public class Amenity
{
        public Amenity(){
            cod_amen = 0;
            descrip = "";
            horario = new List<Amen_hor>();
        }

        public Amenity(int _cod_amen, string _descrip,List<Amen_hor> _hora)		
        {
            cod_amen = _cod_amen;
            descrip = _descrip;
            horario = _hora;
        }

        public int cod_amen { get; set; }
        public string descrip { get; set; }
        public List<Amen_hor> horario { get; set; }
        

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