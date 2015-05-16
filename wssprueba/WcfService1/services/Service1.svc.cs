using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.clases;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
         //[WebInvoke(UriTemplate = "/GetData/{dat}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]
  
        public string GetData(Login per)
        {
            ControllerUsuario cont = new ControllerUsuario(per);


            return cont.UsuChk().ToString(); 
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
