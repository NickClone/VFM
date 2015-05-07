using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



public class User
{
    public int id { get; set; }
    public string name { get; set; }
    public string app { get; set; }
    public string pass { get; set; }
    public string email { get; set; }
    public string fac { get; set; }

}


//[System.Runtime.Serialization.DataContractAttribute()]
//public partial class Person
//{

//    [System.Runtime.Serialization.DataMemberAttribute()]
//    public int id;

//    [System.Runtime.Serialization.DataMemberAttribute()]
//    public string name;

//    [System.Runtime.Serialization.DataMemberAttribute()]
//    public string app;

//}