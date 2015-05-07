using System;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using WcfService1.clases;

namespace WcfService1
{
    [ServiceContract]
    public interface Ipages
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/GetExp", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, Method = "POST")]
        Stream GetUrl(User dat);
    }
}
