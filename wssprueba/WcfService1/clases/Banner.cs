using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.clases
{
    public class Banner
    {
        public string banner { get; set; }

        public void setUser(User user)
        {
            this.banner ="<div class='row'><div class='container' id='title'><div class='col-md-12 col-md-offset-4'><h1>Virtual Facility Manager</h2></div><div class='col-md-3'><h5 id='adm'>" + user.Account + "</h5></div></div></div>";
        }

    }
}