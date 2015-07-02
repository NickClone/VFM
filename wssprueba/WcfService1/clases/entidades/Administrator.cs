using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService1.clases.excepcions;

namespace WcfService1
{
    public class Administrator : User
    {
        public string Nom_Company { get; set; }
        public string horario_consul { get; set; }
        public  List<Edificio> LEdif { get; set; }
 


        public Administrator(User usr): base(usr)
        {
            Nom_Company = "";
            horario_consul = "";
            LEdif = new List<Edificio>();
        }
    }
}