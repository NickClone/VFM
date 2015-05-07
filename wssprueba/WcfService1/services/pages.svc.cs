using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Script.Serialization;
using System.IO;
using System.ServiceModel.Web;
using WcfService1.clases;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Expensas" in code, svc and config file together.
    public class Pages : Ipages
    {
        public Stream  GetUrl(User dat){
            string path="";
             
            ControllerUsuario usrdat = new ControllerUsuario(dat);
                if (!string.IsNullOrEmpty(usrdat.getdata())){
                    path="http://localhost:1066/main.html";
                }
                var j = new
                {
                    url = path
                };
                var s = new JavaScriptSerializer();
                string jsonClient = s.Serialize(j);
                WebOperationContext.Current.OutgoingResponse.ContentType =
                    "application/json; charset=utf-8";
                return new MemoryStream(Encoding.UTF8.GetBytes(jsonClient));
        }
    }
}
