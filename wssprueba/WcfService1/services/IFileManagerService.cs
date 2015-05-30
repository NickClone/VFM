using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.IO;

namespace WcfService1.services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFileManagerService" in both code and config file together.
    [ServiceContract]
    public interface IFileManagerService
    {

        [OperationContract(Name = "Retrieve")]
        [WebGet(UriTemplate = "RetrieveFile?Path={path}")]
        Stream RetrieveFile(string path);

        [OperationContract(Name = "Upload")]
        [WebInvoke(UriTemplate = "UploadFile", Method = "POST")]
        void UploadFile(Stream stream);

    }  
}
