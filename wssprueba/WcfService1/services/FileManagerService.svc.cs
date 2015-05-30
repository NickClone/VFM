using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.ServiceModel.Web;

namespace WcfService1.services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FileManagerService" in code, svc and config file together.
    public class FileManagerService : IFileManagerService
    {
        public Stream RetrieveFile(string path)
        {
            if (WebOperationContext.Current == null) throw new Exception("WebOperationContext not set");

            // As the current service is being used by a windows client, there is no browser interactivity.  
            // In case you are using the code Web, please use the appropriate content type.  
            var fileName = Path.GetFileName(path);
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/octet-stream";
            WebOperationContext.Current.OutgoingResponse.Headers.Add("content-disposition", "inline; filename=" + fileName);

            return File.OpenRead(path);
        }

        public void UploadFile(Stream stream)
        {
            using (var file = File.Create("C:\\gitHub\\VFM\\wssprueba\\WcfService1\\Upload\\test.txt"))
            {
                stream.CopyTo(file);
            }
        }

        private void CreateDirectoryIfNotExists(string filePath)
        {
            var directory = new FileInfo(filePath).Directory;
            if (directory == null) throw new Exception("Directory could not be determined for the filePath");

            Directory.CreateDirectory(directory.FullName);
        }
    }  
}
