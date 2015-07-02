using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.clases
{
    public class Banner
    {
        public string banner { get; set; }

        public Banner(User user) {
            if (user is Habitante)
            {

                this.banner = "<input id='mhdnId' type='hidden' value=" + user.Id + " />";
                this.banner = this.banner + "<input id='mhdnAccount' type='hidden' value=" + user.Account + " />";
                this.banner = this.banner + "<input id='mhdnApellido' type='hidden' value=" + user.Apellido + " />";
                this.banner = this.banner + "<div class='row'><div class='container' id='title'><div class='col-md-12 col-md-offset-4'><h1 id ='BanTit'>Virtual Facility Manager</h1></div><div class='col-md-3'><h5 id='adm'> USUARIO: " + user.Account + "   NOMBRE: " + user.Apellido + ", "+ user.Nombre  +"</h5></div></div></div>";
            }

            if (user is Administrator)
            {
                Administrator adm = (Administrator)user;

                this.banner = "<input id='mhdnId' type='hidden' value=" + user.Id + " />";
                this.banner = this.banner + "<input id='mhdnAccount' type='hidden' value=" + user.Account + " />";
                this.banner = this.banner + "<input id='mhdnApellido' type='hidden' value=" + user.Apellido + " />";
                this.banner = this.banner + "<div class='row'><div class='container' id='title'><div class='col-md-12 col-md-offset-4'><h1 id ='BanTit'><strong>VFM</strong>Admin</h1></div>";
                this.banner = this.banner + "<div class='col-md-3'><h5 id='adm'> <strong>USUARIO:</strong> " + user.Account + "   <strong>NOMBRE:</strong>  " + user.Apellido + ", " + user.Nombre + "</h5>";
                this.banner = this.banner + "  <label class='col-md-3' for='edif_cantpisos'><h5>Edificios</h5></label>";
                this.banner = this.banner + "    <select id='edif_cantpisos' name='edif_cantpisos' class='form-control'>";

                foreach (Edificio edif in adm.LEdif)
                {
                    this.banner = this.banner + "      <option value='" + edif.cod_edif + "'>" + edif.edif_calle + "  " + edif.edif_num + "</option>";
                }
                this.banner = this.banner + "    </select>";

                this.banner = this.banner + "</div></div></div>";
             }
  
        }
        public Banner()
        {
         
        }

        public void setUser(User user)
        {
                this.banner =  "<input id='mhdnId' type='hidden' value=" + user.Id + " />";
                this.banner = this.banner + "<input id='mhdnAccount' type='hidden' value=" + user.Account + " />";
                this.banner = this.banner + "<input id='mhdnApellido' type='hidden' value=" + user.Apellido + " />";
                this.banner = this.banner + "<div class='row'><div class='container' id='title'><div class='col-md-12 col-md-offset-4'><h1>Virtual Facility Manager</h2></div><div class='col-md-3'><h5 id='adm'>" + user.Account + "</h5></div></div></div>";
        }

    }
}