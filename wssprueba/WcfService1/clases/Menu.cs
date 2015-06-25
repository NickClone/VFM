using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.clases
{
    public class Menu
    {
        public string menubar { get; set; }

        public Menu(User usr) {

            this.menubar = "<div class='col-md-2 menuvar'><nav class='navbar nav-pills nav-stacked span3 navbar-default ' role='navigation'>";
            this.menubar = this.menubar + "     <div class='navbar-header'>";
            this.menubar = this.menubar + "          <a class='navbar-brand' href='#' id = 'edificio'>Edificio</a>";
            this.menubar = this.menubar + "            <button type='button' class='navbar-toggle' data-toggle='collapse' data-target='.navbar-collapse'>"; ;
            this.menubar = this.menubar + "                <span class='icon-bar'></span>";
            this.menubar = this.menubar + "                <span class='icon-bar'></span>";
            this.menubar = this.menubar + "                <span class='icon-bar'></span>";
            this.menubar = this.menubar + "            </button>";
            this.menubar = this.menubar + "     </div>";
            this.menubar = this.menubar + "  <div class='collapse navbar-collapse navbar-ex1-collapse'>";
            this.menubar = this.menubar + "    <ul class='nav navbar-nav'>";
            this.menubar = this.menubar + "    <li ><a href='#' id ='edificio'>Datos Edificio</a></li>";
            this.menubar = this.menubar + "    <li><a href='#' id='drop' data-toggle='collapse' data-target='#submenu1' aria-expanded='false'>Expensas</a>";
            this.menubar = this.menubar + "      <ul class='active nav collapse' id='submenu1' role='menu' aria-labelledby='btn-1'>";
            this.menubar = this.menubar + "        <li><a href='#' id='cargaexp' >Carga de expensas</a></li>";
            this.menubar = this.menubar + "        <li><a href='#'>Morosos</a></li>";
            this.menubar = this.menubar + "        <li><a href='#'>Estado del mes</a></li>";
            this.menubar = this.menubar + "      </ul>";
            this.menubar = this.menubar + "    </li>";
            this.menubar = this.menubar + "    <li><a href='#' id='drop' data-toggle='collapse' data-target='#amen' aria-expanded='false'>Amenities</a>";
            this.menubar = this.menubar + "      <ul class='nav collapse' id='amen' role='menu' aria-labelledby='btn-1'>";
            this.menubar = this.menubar + "        <li><a href='#'>Pileta</a></li>";
            this.menubar = this.menubar + "        <li><a href='#'>Laundry</a></li>";
            this.menubar = this.menubar + "        <li><a href='#'>Gym</a></li>";
            this.menubar = this.menubar + "        <li><a href='#'>Cochera</a></li>";
            this.menubar = this.menubar + "      </ul>";
            this.menubar = this.menubar + "    </li>";
            this.menubar = this.menubar + "    <li ><a href='#' id ='altaUsr'>Alta Usuario</a></li>";
            this.menubar = this.menubar + "    <li ><a href='#' id ='bajaUsr'>Baja Usuario</a></li>";
            this.menubar = this.menubar + "      </ul>";
            this.menubar = this.menubar + "  </div>";
            this.menubar = this.menubar + "</nav>";
            this.menubar = this.menubar + "</div>";
        
        }
        public Menu()
        {

        }

        public void setmenu()
        {

            this.menubar = "<div class='col-md-2 menuvar'><nav class='navbar nav-pills nav-stacked span3 navbar-default ' role='navigation'>";
            this.menubar = this.menubar + "     <div class='navbar-header'>";
            this.menubar = this.menubar + "          <a class='navbar-brand' href=''>Edificio</a>";
            this.menubar = this.menubar + "            <button type='button' class='navbar-toggle' data-toggle='collapse' data-target='.navbar-collapse'>"; ;
            this.menubar = this.menubar + "                <span class='icon-bar'></span>";
            this.menubar = this.menubar + "                <span class='icon-bar'></span>";
            this.menubar = this.menubar + "                <span class='icon-bar'></span>";
            this.menubar = this.menubar + "            </button>";
            this.menubar = this.menubar + "     </div>";
            this.menubar = this.menubar + "  <div class='collapse navbar-collapse navbar-ex1-collapse'>";
            this.menubar = this.menubar + "    <ul class='nav navbar-nav'>";
            this.menubar = this.menubar + "    <li><a href='#' id='drop' data-toggle='collapse' data-target='#submenu1' aria-expanded='false'>Expensas</a>";
            this.menubar = this.menubar + "      <ul class='active nav collapse' id='submenu1' role='menu' aria-labelledby='btn-1'>";
            this.menubar = this.menubar + "        <li><a href='#' id='cargaexp' >Carga de expensas</a></li>";
            this.menubar = this.menubar + "        <li><a href='#'>Morosos</a></li>";
            this.menubar = this.menubar + "        <li><a href='#'>Estado del mes</a></li>";
            this.menubar = this.menubar + "      </ul>";
            this.menubar = this.menubar + "    </li>";
            this.menubar = this.menubar + "    <li><a href='#' id='drop' data-toggle='collapse' data-target='#amen' aria-expanded='false'>Amenities</a>";
            this.menubar = this.menubar + "      <ul class='nav collapse' id='amen' role='menu' aria-labelledby='btn-1'>";
            this.menubar = this.menubar + "        <li><a href='#'>Pileta</a></li>";
            this.menubar = this.menubar + "        <li><a href='#'>Laundry</a></li>";
            this.menubar = this.menubar + "        <li><a href='#'>Gym</a></li>";
            this.menubar = this.menubar + "        <li><a href='#'>Cochera</a></li>";
            this.menubar = this.menubar + "      </ul>";
            this.menubar = this.menubar + "    </li>";
            this.menubar = this.menubar + "      <li ><a href=''>Alta Usuario</a></li>";
            this.menubar = this.menubar + "      <li ><a href=''>Baja Usuario</a></li>";
            this.menubar = this.menubar + "      </ul>";
            this.menubar = this.menubar + "  </div>";
            this.menubar = this.menubar + "</nav>";
            this.menubar = this.menubar + "</div>";
        }

    }
}