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

namespace WcfService1
{

    [ServiceContract]
    public interface IService1
    {

        // [WebGet]
        [OperationContract(Name = "data")]
        [WebInvoke(UriTemplate = "/GetData", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]
        Stream GetData(User per);

        [OperationContract(Name = "usr")]
        [WebInvoke(UriTemplate = "/insUsr", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]
        Stream insUsr(User usr);

        [OperationContract(Name = "res")]
        [WebInvoke(UriTemplate = "/FormRes", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]
        Stream GetFormRes();

        [OperationContract(Name = "AltaEdif")]
        [WebInvoke(UriTemplate = "/AltaEdificio", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]
        Stream AltaEdificio(Edificio ed);


        [OperationContract(Name = "lala")]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
