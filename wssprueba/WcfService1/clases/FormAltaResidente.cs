using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.clases
{
    public class FormAltaResidente : IForm
    {
        public string form{get;set;}

        public FormAltaResidente()
        {
            this.form = "<form class='form-horizontal col-md-8' id ='altares'>";
            this.form = this.form + "<input id='idUsr' type='hidden' value='0'>";
            this.form = this.form + "<fieldset>";  // data-toggle='modal' data-target='#modal'
           // this.form = this.form + "<a data-toggle='modal' href='#myModal' class='btn btn-success btn-xs pull-right' id ='usralta'>Alta</a></button><button type='button' class='btn-danger btn-xs pull-right' id ='usrbaja'>Baja</button><button type='button' class='btn-info btn-xs pull-right' id ='usrmod'>Modificacion</button>";
            this.form = this.form + "<legend>Gestion Residentes</legend>";
            this.form = this.form + "<button type='button' class='btn btn-default' id ='usrmod' data-toggle='modal' data-target='#modal'><span class='glyphicon glyphicon-pencil'></span></button><button type='button' class='btn btn-default' id ='usrbaja' data-toggle='modal' data-target='#modal'><span class='glyphicon glyphicon-minus'></span></button>";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='nomUsr'>Nombre</label>  ";
            this.form = this.form + "  <div class='col-md-4'>";
            this.form = this.form + "  <input id='nomUsr' name='nomUsr'  class='form-control input-md' required='' type='text'>";
            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";
            this.form = this.form + "<!-- Text input-->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='apeUsr'>Apellido</label>  ";
            this.form = this.form + "  <div class='col-md-4'>";
            this.form = this.form + "  <input id='apeUsr' name='apeUsr' placeholder='' class='form-control input-md' required='' type='text'>";

            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Text input-->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='mailusr'>Email</label>  ";
            this.form = this.form + "  <div class='col-md-4'>";
            this.form = this.form + "  <input id='mailusr' name='mailusr' placeholder='' class='form-control input-md' required='' type='text'>";

            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Text input-->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for=PassUsr'>Password</label>  ";
            this.form = this.form + "  <div class='col-md-4'>";
            this.form = this.form + "  <input id='PassUsr' name='PassUsr' placeholder='' class='form-control input-md' required='' type='password'>";

            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Text input-->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='telUsr'>Telefono</label>  ";
            this.form = this.form + "  <div class='col-md-4'>";
            this.form = this.form + "  <input id='telUsr' name='telUsr' placeholder='' class='form-control input-md' required='' type='text'>";

            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Text input-->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='fnUsr'>Fecha Nac.</label>  ";
            this.form = this.form + "  <div class='col-md-4'>";
            this.form = this.form + "  <input id='fnUsr' name='fnUsr' placeholder='' class='form-control input-md' required='' type='text'>";

            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Multiple Radios (inline) -->";
            this.form = this.form + "<div class='form-group' id='sexo'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='sexUsr'>Sexo</label>";
            this.form = this.form + "  <div class='col-md-3'> ";
            this.form = this.form + "    <label class='radio-inline' for='sexUsr-0'>";
            this.form = this.form + "      <input name='sexUsr' id='sexUsr' value='1' checked='checked' type='radio'>";
            this.form = this.form + "      F";
            this.form = this.form + "    </label> ";
            this.form = this.form + "    <label class='radio-inline' for='sexUsr-1'>";
            this.form = this.form + "      <input name='sexUsr' id='sexUsr' value='2' type='radio'>";
            this.form = this.form + "      M";
            this.form = this.form + "    </label>";
            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Multiple Checkboxes -->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='encUsr'>Encargado</label>";
            this.form = this.form + "  <div class='col-md-3'>";
            this.form = this.form + "  <div class='checkbox'>";
            this.form = this.form + "    <label for='encUsr-0'>";
            this.form = this.form + "      <input name='encUsr' id='encUsr-0' value='1' type='checkbox'>";
            this.form = this.form + "      Si";
            this.form = this.form + "    </label>";
            this.form = this.form + "	</div>";
            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Text input-->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='pisUsr'>Piso</label>  ";
            this.form = this.form + "  <div class='col-md-2'>";
            this.form = this.form + "  <input id='pisUsr' name='pisUsr' placeholder='' class='form-control input-md' required='' type='text'>";

            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Text input-->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='depUsr'>Depto</label>  ";
            this.form = this.form + "  <div class='col-md-2'>";
            this.form = this.form + "  <input id='depUsr' name='depUsr' placeholder='' class='form-control input-md' required='' type='text'>";
            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Button -->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='crearUsr'></label>";
            this.form = this.form + "  <div class='col-md-4'>";
            this.form = this.form + "    <input type='button' id='crearUsr' name='crearUsr' class='btn btn-primary' value='Generar'";
            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "</fieldset>";
            this.form = this.form + "<div id='modal' class='modal fade' tabindex='-1' role='dialog'><div class='modal-dialog'><div class='modal-content'><div class='modal-header'><button type='button' class='close' data-dismiss='modal' aria-hidden='true'>X</button><h3 id='modalTitle'>Residente</h3></div><div class='modal-body' id ='bod'><div id='detsearch'></div></div></div></div></div>";
            this.form = this.form + "</form>";
        }


        public void setAltaresidente()
        {
            this.form = "<form class='form-horizontal'>";
            this.form = this.form + "<fieldset>";
            this.form = this.form + "<legend>Alta Residente</legend>";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='nomUsr'>Nomre</label>  ";
            this.form = this.form + "  <div class='col-md-2'>";
            this.form = this.form + "  <input id='nomUsr' name='nomUsr'  class='form-control input-md' required='' type='text'>";
            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";
            this.form = this.form + "<!-- Text input-->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='apeUsr'>Apellido</label>  ";
            this.form = this.form + "  <div class='col-md-4'>";
            this.form = this.form + "  <input id='apeUsr' name='apeUsr' placeholder='' class='form-control input-md' required='' type='text'>";

            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Text input-->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='mailusr'>Email</label>  ";
            this.form = this.form + "  <div class='col-md-4'>";
            this.form = this.form + "  <input id='mailusr' name='mailusr' placeholder='' class='form-control input-md' required='' type='text'>";

            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Text input-->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for=PassUsr'>Password</label>  ";
            this.form = this.form + "  <div class='col-md-4'>";
            this.form = this.form + "  <input id='PassUsr' name='PassUsr' placeholder='' class='form-control input-md' required='' type='password'>";

            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Text input-->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='telUsr'>Telefono</label>  ";
            this.form = this.form + "  <div class='col-md-4'>";
            this.form = this.form + "  <input id='telUsr' name='telUsr' placeholder='' class='form-control input-md' required='' type='text'>";

            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Text input-->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='fnUsr'>Fecha Nac.</label>  ";
            this.form = this.form + "  <div class='col-md-4'>";
            this.form = this.form + "  <input id='fnUsr' name='fnUsr' placeholder='' class='form-control input-md' required='' type='text'>";

            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Multiple Radios (inline) -->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='sexUsr'>Sexo</label>";
            this.form = this.form + "  <div class='col-md-4'> ";
            this.form = this.form + "    <label class='radio-inline' for='sexUsr-0'>";
            this.form = this.form + "      <input name='sexUsr' id='sexUsr' value='1' checked='checked' type='radio'>";
            this.form = this.form + "      F";
            this.form = this.form + "    </label> ";
            this.form = this.form + "    <label class='radio-inline' for='sexUsr-1'>";
            this.form = this.form + "      <input name='sexUsr' id='sexUsr' value='2' type='radio'>";
            this.form = this.form + "      M";
            this.form = this.form + "    </label>";
            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Multiple Checkboxes -->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='encUsr'>Encargado</label>";
            this.form = this.form + "  <div class='col-md-4'>";
            this.form = this.form + "  <div class='checkbox'>";
            this.form = this.form + "    <label for='encUsr-0'>";
            this.form = this.form + "      <input name='encUsr' id='encUsr-0' value='1' type='checkbox'>";
            this.form = this.form + "      Si";
            this.form = this.form + "    </label>";
            this.form = this.form + "	</div>";
            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Text input-->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='pisUsr'>Piso</label>  ";
            this.form = this.form + "  <div class='col-md-2'>";
            this.form = this.form + "  <input id='pisUsr' name='pisUsr' placeholder='' class='form-control input-md' required='' type='text'>";

            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Text input-->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='depUsr'>Depto</label>  ";
            this.form = this.form + "  <div class='col-md-2'>";
            this.form = this.form + "  <input id='depUsr' name='depUsr' placeholder='' class='form-control input-md' required='' type='text'>";
            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "<!-- Button -->";
            this.form = this.form + "<div class='form-group'>";
            this.form = this.form + "  <label class='col-md-4 control-label' for='crearUsr'></label>";
            this.form = this.form + "  <div class='col-md-4'>";
            this.form = this.form + "    <input type='button' id='crearUsr' name='crearUsr' class='btn btn-primary' value='Generar'";
            this.form = this.form + "  </div>";
            this.form = this.form + "</div>";

            this.form = this.form + "</fieldset>";
            this.form = this.form + "</form>";

        }

        public string ReturnForm() {

            return this.form;
        
        }


    }
}