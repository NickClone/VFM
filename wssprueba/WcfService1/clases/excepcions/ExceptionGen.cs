using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WcfService1.clases.excepcions
{
    public class ExceptionGen : Exception
    {

        public ExceptionGen(string mensaje, Exception ex) : base(mensaje, ex)
        {
        }
    
}
    }