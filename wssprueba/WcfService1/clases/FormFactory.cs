using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.clases
{
    public class FormFactory
    {

         public IForm CreateForm(string tipo)
        {
            IForm Formulario = null;

            switch (tipo)
            {
                case "1":
                    Formulario = new FormExpensa();
                    break;
                case "2":
                    Formulario = new FormAltaResidente();
                    break;
                
            }

            return Formulario;
        }

    }




}