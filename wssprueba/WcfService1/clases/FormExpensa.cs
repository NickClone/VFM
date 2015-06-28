using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.clases
{
    public class FormExpensa : IForm
    {

        public string form { get; set; }

        public FormExpensa()
        {
           
           this.form="<form class='form-horizontal col-md-6'>";
           this.form = this.form + "<fieldset>";
           this.form = this.form + "";
           this.form = this.form + "<!-- Form Name -->";
           this.form = this.form + "    <legend>Carga de Expensas</legend>";
           this.form = this.form + "<button type='button' class='btn btn-default' id ='ediexp' data-toggle='modal' data-target='#modal'><span class='glyphicon glyphicon-pencil'></span></button><button type='button' class='btn btn-default' id ='expbaja' data-toggle='modal' data-target='#modal'><span class='glyphicon glyphicon-minus'></span></button><button type='button' class='btn btn-default' id ='expalta' data-toggle='modal' data-target='#modal'><span class='glyphicon glyphicon-plus'></span></button><br>";
            
       //    this.form = this.form +"";
       //    this.form = this.form +"";
           this.form = this.form +"    <form >";
           this.form = this.form +"         <!--<input id='File1' class='file' type='file' multiple data-min-file-count='1'>-->";
           this.form = this.form +"         <input id='File1' class='file' type='file'>";
           this.form = this.form +"         <input type='text' id='hide' style='display: none'>";
           this.form = this.form +"         <br>";
           this.form = this.form +"         <button type='button' id='Submit1' class='btn btn-primary'>Submit</button>";
           this.form = this.form +"    </form>";
           this.form = this.form +"    ";
           this.form = this.form +"<!-- Text input-->";
           this.form = this.form +"";
           this.form = this.form +"";
           this.form = this.form +"<!-- Ejemplo para seguir agregandole cosas";
           this.form = this.form +"<div class='form-group'>";
           this.form = this.form +"  <label class='col-md-4 control-label' for='edif_calle'>Calle</label>  ";
           this.form = this.form +"  <div class='col-md-3'>";
           this.form = this.form +"  <input id='edif_calle' name='edif_calle' type='text' placeholder='Araoz' class='form-control input-md'>";
           this.form = this.form +"    ";
           this.form = this.form +"  </div>";
           this.form = this.form +"</div>";
           this.form = this.form +"-->";
           this.form = this.form +"";
           this.form = this.form +"<!-- Text input";
           this.form = this.form +"<div class='form-group'>";
           this.form = this.form +"  <label class='col-md-4 control-label' for='edif_prov'>Provincia</label>  ";
           this.form = this.form +"  <div class='col-md-2'>";
           this.form = this.form +"  <input id='edif_prov' name='edif_prov' type='text' placeholder='Buenos Aires' class='form-control input-md'>";
           this.form = this.form +"    ";
           this.form = this.form +"  </div>";
           this.form = this.form +"</div>";
           this.form = this.form +"-->";
           this.form = this.form +"</fieldset>";
           this.form = this.form +"</form>";


        }
        public string ReturnForm()
        {

            return this.form;

        }
       
    }
}



