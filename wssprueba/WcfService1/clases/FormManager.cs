using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.clases
{
    public class FormManager
    {

        public string GetBanner(User usr)
        {
            Banner ban = new Banner(usr);

            return ban.banner;

        }
        public string GetMenu(User usr)
        {
            Menu menu = new Menu(usr);

            return menu.menubar;

        }
        public string GetAltaResidente() {

            AltaResidente aResid = new AltaResidente();

            return aResid.form;

        }

    }




}