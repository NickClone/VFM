using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WcfService1.clases
{
    public class Conn
    {
        protected SqlConnection conn;
        protected void  connect(){
            this.conn=new SqlConnection(@"Data Source=vcore1\SQLEXPRESS;Initial Catalog=VFM;Integrated Security=True");
            this.conn.Open();
        }
       
    }
}