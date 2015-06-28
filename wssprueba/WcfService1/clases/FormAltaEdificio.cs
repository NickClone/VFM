using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;



namespace WcfService1.clases
{

    public class FormAltaEdificio : IForm
    {

        public string form { get; set; }



        public FormAltaEdificio()
        {

            this.form = "<form class='form-horizontal'>";

            this.form = this.form + "<fieldset>";



            this.form = this.form + "<!-- Form Name -->";

            this.form = this.form + "<legend>Alta Edificio</legend>";
            this.form = this.form + "<button type='button' class='btn btn-default' id ='edimod' data-toggle='modal' data-target='#modal'><span class='glyphicon glyphicon-pencil'></span></button><button type='button' class='btn btn-default' id ='edibaja' data-toggle='modal' data-target='#modal'><span class='glyphicon glyphicon-minus'></span></button><button type='button' class='btn btn-default' id ='edialta' data-toggle='modal' data-target='#modal'><span class='glyphicon glyphicon-plus'></span></button>";
            
            this.form = this.form + "<!-- Text input-->";

            this.form = this.form + "<div class='form-group'>";

            this.form = this.form + "<label class='col-md-4 control-label' for='edif_nombre'>Nombre de Edificio</label>  ";

            this.form = this.form + " <div class='col-md-3'>";

            this.form = this.form + "  <input id='edif_nombre' name='edif_nombre' type='text' placeholder='Condominio Manzanares' class='form-control input-md'>  ";

            this.form = this.form + "  </div></div>";



            this.form = this.form + "<!-- Text input-->";

            this.form = this.form + "<div class='form-group'>";

            this.form = this.form + "<label class='col-md-4 control-label' for='edif_calle'>Calle</label>  ";

            this.form = this.form + "  <div class='col-md-3'>";

            this.form = this.form + "  <input id='edif_calle' name='edif_calle' type='text' placeholder='Araoz' class='form-control input-md'>";



            this.form = this.form + " </div></div>";



            this.form = this.form + "<!-- Text input-->";

            this.form = this.form + "<div class='form-group'>";

            this.form = this.form + "    <div class='col-md-2 column'>";

            this.form = this.form + "	</div>";



            this.form = this.form + "  <label class='col-md-2 control-label' for='edif_num'>Numero</label>  ";

            this.form = this.form + "    <div class='col-md-1'>";

            this.form = this.form + "  <input id='edif_num' name='edif_num' type='text' placeholder='123' class='form-control input-md'>";

            this.form = this.form + "  </div>";



            this.form = this.form + "    <label class='col-md-1 control-label' for='edif_cp'>Cod Postal</label>  ";

            this.form = this.form + "    <div class='col-md-1'>";

            this.form = this.form + "  <input id='Text1' name='edif_cp' type='text' placeholder='1181' class='form-control input-md'>";

            this.form = this.form + " </div>";



            this.form = this.form + "   <div class='col-md-2 column'>";

            this.form = this.form + "	</div></div>";



            this.form = this.form + "<!-- Select Basic -->";

            this.form = this.form + "<div class='form-group'>";

            this.form = this.form + "    <div class='col-md-2 column'>";

            this.form = this.form + "	</div>";



            this.form = this.form + "  <label class='col-md-2 control-label' for='edif_cantpisos'>Pisos</label>";

            this.form = this.form + "  <div class='col-md-1'>";

            this.form = this.form + "    <select id='edif_cantpisos' name='edif_cantpisos' class='form-control'>";

            this.form = this.form + "      <option value='1'>1</option>";

            this.form = this.form + "      <option value='2'>2</option>";

            this.form = this.form + "      <option value='3'>3</option>";

            this.form = this.form + "      <option value='4'>4</option>";

            this.form = this.form + "      <option value='5'>5</option>";

            this.form = this.form + "      <option value='6'>6</option>";

            this.form = this.form + "      <option value='7'>7</option>";

            this.form = this.form + "      <option value='8'>8</option>";

            this.form = this.form + "      <option value='9'>9</option>";

            this.form = this.form + "      <option value='10'>10</option>";

            this.form = this.form + "      <option value='11'>11</option>";

            this.form = this.form + "      <option value='12'>12</option>";

            this.form = this.form + "      <option value='13'>13</option>";

            this.form = this.form + "      <option value='14'>14</option>";

            this.form = this.form + "      <option value='15'>15</option>";

            this.form = this.form + "      <option value='16'>16</option>";

            this.form = this.form + "      <option value='17'>17</option>";

            this.form = this.form + "      <option value='18'>18</option>";

            this.form = this.form + "      <option value='19'>19</option>";

            this.form = this.form + "      <option value='20'>20</option>";

            this.form = this.form + "      <option value='21'>21</option>";

            this.form = this.form + "      <option value='22'>22</option>";

            this.form = this.form + "      <option value='23'>23</option>";

            this.form = this.form + "      <option value='24'>24</option>";

            this.form = this.form + "      <option value='25'>25</option>";

            this.form = this.form + "    </select>";

            this.form = this.form + " </div>";



            this.form = this.form + "  <label class='col-md-1 control-label' for='edif_deptosxpiso'>Deptos x piso</label>";

            this.form = this.form + "  <div class='col-md-1'>";

            this.form = this.form + "    <select id='edif_deptosxpiso' name='edif_deptosxpiso' class='form-control'>";

            this.form = this.form + "      <option value='1'>1</option>";

            this.form = this.form + "      <option value='2'>2</option>";

            this.form = this.form + "      <option value='3'>3</option>";

            this.form = this.form + "      <option value='4'>4</option>";

            this.form = this.form + "      <option value='5'>5</option>";

            this.form = this.form + "      <option value='6'>6</option>";

            this.form = this.form + "      <option value='7'>7</option>";

            this.form = this.form + "      <option value='8'>8</option>";

            this.form = this.form + "      <option value='9'>9</option>";

            this.form = this.form + "      <option value='10'>10</option>";

            this.form = this.form + "    </select>";

            this.form = this.form + "  </div>";

            this.form = this.form + "      <div class='col-md-2 column'>";

            this.form = this.form + "	</div>";

            this.form = this.form + "</div>";





            this.form = this.form + "<!-- Select Basic -->";

            this.form = this.form + "<div class='form-group'>";

            this.form = this.form + "  <label class='col-md-4 control-label' for='edif_TienePB'>Tiene deptos en Planta Baja</label>";

            this.form = this.form + "  <div class='col-md-1'>";

            this.form = this.form + "    <select id='edif_TienePB' name='edif_TienePB' class='form-control'>";

            this.form = this.form + "      <option value='true'>Si</option>";

            this.form = this.form + "      <option value='false'>No</option>";

            this.form = this.form + "    </select>";

            this.form = this.form + "  </div>";



            this.form = this.form + "  <label class='col-md-1 control-label' for='edif_DeptoLetra'>Tipo ID Depto.</label>";

            this.form = this.form + "  <div class='col-md-1'>";

            this.form = this.form + "    <select id='edif_DeptoLetra' name='edif_DeptoLetra' class='form-control'>";

            this.form = this.form + "      <option value='l'>Letra</option>";

            this.form = this.form + "      <option value='n'>Numero</option>";

            this.form = this.form + "    </select>";

            this.form = this.form + "  </div></div>";



            this.form = this.form + "<!-- Text input-->";

            this.form = this.form + "<div class='form-group'>";

            this.form = this.form + "  <label class='col-md-4 control-label' for='edif_loc'>Localidad/Barrio</label>  ";

            this.form = this.form + " <div class='col-md-2'>";

            this.form = this.form + "  <input id='edif_loc' name='edif_loc' type='text' placeholder='Almagro' class='form-control input-md'>";

            this.form = this.form + "  </div></div>";



            this.form = this.form + "<!-- Text input-->";

            this.form = this.form + "<div class='form-group'>";

            this.form = this.form + "  <label class='col-md-4 control-label' for='edif_prov'>Provincia</label>  ";

            this.form = this.form + "  <div class='col-md-2'>";

            this.form = this.form + "  <input id='edif_prov' name='edif_prov' type='text' placeholder='Buenos Aires' class='form-control input-md'>";

            this.form = this.form + "  </div></div>";



            this.form = this.form + "<!-- Text input-->";

            this.form = this.form + "<div class='form-group'>";

            this.form = this.form + "  <label class='col-md-4 control-label' for='edif_country'>Pais</label>  ";

            this.form = this.form + "  <div class='col-md-2'>";

            this.form = this.form + "  <input id='edif_country' name='edif_country' type='text' placeholder='Argentina' class='form-control input-md'>";

            this.form = this.form + "  </div></div>";



            this.form = this.form + "<!-- Button -->";

            this.form = this.form + "<div class='form-group'>";

            this.form = this.form + "  <label class='col-md-4 control-label' for='edif_btn'></label>";

            this.form = this.form + "  <div class='col-md-4'>";

            this.form = this.form + "    <input type='button' id='edif_btn' name='edif_btn' class='btn btn-primary' value='Cargar'>";

            this.form = this.form + "  </div></div>";



            this.form = this.form + "</fieldset>";

            this.form = this.form + "</form>";



        }



        public string ReturnForm()
        {

            return this.form;

        }



    }

}