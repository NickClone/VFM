using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;
using WcfService1.clases;

namespace WcfService1.services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DataFeed" in code, svc and config file together.
    public class DataFeed : IDataFeed
    {
       public Stream DataUsr(User usr)
        {


            var s = new JavaScriptSerializer();
            string jsonClient = s.Serialize(usr);
            WebOperationContext.Current.OutgoingResponse.ContentType =
                "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(jsonClient));
        }
    }
}
