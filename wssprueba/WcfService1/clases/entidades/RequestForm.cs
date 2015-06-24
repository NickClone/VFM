using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.clases
{
    public class RequestForm
    {
        public string IdRequestor{get;set;}
        public string FormTipo { get; set; }
        public string Data { get; set; } 

        public RequestForm() {  
        }
        
    }
}