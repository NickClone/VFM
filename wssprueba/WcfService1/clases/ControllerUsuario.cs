using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.clases
{
    public class ControllerUsuario: Conn
    {
        public User usr { get; set; }
        public ControllerUsuario(User per)
        {
            this.usr=per;
        }

        public string getdata()
        {
            string query = "select * from users where email = '"+this.usr.email +"' and pass = '" +this.usr.pass +"' and facility= '"+this.usr.fac+"'";

            return "existe!";
            
            //string query = "Insert into users values (";
            //query = query + per.id + ",'" + per.name + "','" + per.pass + "')";
            //this.conn.
        }
    }
}