using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.clases;
using System.Web.Script.Serialization;
using System.IO;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
         //[WebInvoke(UriTemplate = "/GetData/{dat}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]
  
        public Stream GetData(Login log)
        {
          //  string vuelta;

            ControllerUsuario cont = new ControllerUsuario(log);

            var s = new JavaScriptSerializer();
            string jsonClient = s.Serialize(cont.UsuChk());
            WebOperationContext.Current.OutgoingResponse.ContentType =
                "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(jsonClient));
            
        }
        public Stream insUsr(User usr) {

            ControllerUsuario cont = new ControllerUsuario(usr);

            var s = new JavaScriptSerializer();
            string jsonClient = s.Serialize(cont.insupdata());
            WebOperationContext.Current.OutgoingResponse.ContentType =
                "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(jsonClient));
            
        
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
