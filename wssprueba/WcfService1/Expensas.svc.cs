using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Expensas" in code, svc and config file together.
    public class Expensas : IExpensas
    {
        public Person GetExpensas(Person per)
        {
            return per;

        }
    }
}
