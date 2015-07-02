using System;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.clases;
using System.IO;


namespace WcfService1.services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDataFeed" in both code and config file together.
    [ServiceContract]
    public interface IDataFeed
    {
        [OperationContract(Name = "DataUsr")]
        [WebInvoke(UriTemplate = "/DataUsr", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]
        Stream DataUsr(User usr);
    }
}
