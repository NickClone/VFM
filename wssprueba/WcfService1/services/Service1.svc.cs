﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;
using WcfService1.clases;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        //[WebInvoke(UriTemplate = "/GetData/{dat}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]

        public Stream GetData(User log)
        {
            //ControllerUsuario cont = new ControllerUsuario(log);

            Banner ban = new Banner();
            Menu men = new Menu();

            ban.setUser(log);
            men.setmenu();
            string ret = ban.banner + men.menubar + "<div id='forminy'></div>";
            object lal = new
            {
                campo = ret
            };
            var s = new JavaScriptSerializer();
            string jsonClient = s.Serialize(lal);
            WebOperationContext.Current.OutgoingResponse.ContentType =
                "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(jsonClient));

        }

        public Stream GetFormRes() //aca tenia (User usr) como parametro, pero del lado de la interfaz no tiene. se lo borre, ya que no 
                                   //veo en el codigo que lo esté usando.
        {
            //ControllerUsuario cont = new ControllerUsuario(log);

            AltaResidente AltaR = new AltaResidente();
           

            AltaR.setAltaresidente();
           
            string ret = AltaR.form;
            object lal = new
            {
                campo = ret
            };
            var s = new JavaScriptSerializer();
            string jsonClient = s.Serialize(lal);
            WebOperationContext.Current.OutgoingResponse.ContentType =
                "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(jsonClient));
        }

        public Stream insUsr(User usr)
        {

            ControllerUsuario cont = new ControllerUsuario(usr);

            var s = new JavaScriptSerializer();
            string jsonClient = s.Serialize(cont.insupdata());
            WebOperationContext.Current.OutgoingResponse.ContentType =
                "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(jsonClient));

        }

        public Stream AltaEdificio(Edificio ed)
        {
            ControllerEdificio contEdif = new ControllerEdificio(ed);

            var s = new JavaScriptSerializer();
            string jsonClient = s.Serialize(contEdif.Alta());
            WebOperationContext.Current.OutgoingResponse.ContentType =
                "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(jsonClient));
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
