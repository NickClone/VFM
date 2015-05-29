using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService1.clases.excepcions;

public class Edificio
{
        public Edificio(){
            cod_edif = 0;
            edif_nombre = "";
            edif_calle = "";
            edif_num = 0;
            edif_cp = "";
            edif_country = 0;
            edif_prov = 0;
            edif_loc = 0;
            estado = 0;
            Ldpto = new List<Dpto>();
            Lexp = new List<Expensa>();  
        }
        public Edificio(int _cod_edif, string _edif_nombre, string _edif_calle, decimal _edif_num, string _edif_cp, decimal _edif_country, decimal _edif_prov, decimal _edif_loc, decimal _estado, List<Dpto> _Ldpto,List<Expensa> _Lexp)		
        {
            cod_edif = _cod_edif;
            edif_nombre = _edif_nombre;
            edif_calle = _edif_calle;
            edif_num = _edif_num;
            edif_cp = _edif_cp;
            edif_country = _edif_country;
            edif_prov = _edif_prov;
            edif_loc = _edif_loc;
            estado = _estado;
            Ldpto = _Ldpto;
            Lexp = _Lexp;
        }


        public int cod_edif { get; set; }
        public string edif_nombre { get; set; }
        public string edif_calle { get; set; }
        public decimal edif_num { get; set; }
        public string edif_cp { get; set; }
        public decimal edif_country { get; set; }
        public decimal edif_prov { get; set; }
        public decimal edif_loc { get; set; }
        public decimal estado { get; set; }
        public List<Dpto> Ldpto { get; set; }
        public List<Expensa> Lexp{ get; set; }


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