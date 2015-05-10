using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security;
using System.Runtime.Serialization;

namespace WcfService1.clases.excepcions
{
    public abstract class ValidacionExcepcionAbstract : Exception
    {
        public ValidacionExcepcionAbstract()
            : base()
        {
        }

        public ValidacionExcepcionAbstract(string message)
            : base(message)
        {
        }

        [SecuritySafeCritical]
        protected ValidacionExcepcionAbstract(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public ValidacionExcepcionAbstract(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}