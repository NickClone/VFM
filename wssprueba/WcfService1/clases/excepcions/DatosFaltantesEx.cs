using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.clases.excepcions
{
    public class DatosFaltantesEx : ValidacionExcepcionAbstract
    {
   
        public DatosFaltantesEx() : base("Faltan datos obligatorios."){}
        
        }

}
