using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Caching;

namespace SessionManagement
{
    public class Global : System.Web.HttpApplication
    {



        protected void Application_Start(object sender, EventArgs e)
        {
            
        }

        public static string SessionPass
        {
            get
            {
                object value = HttpContext.Current.Session["SessionPass"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["SessionPass"] = value;
            }
        }

        public static string SessionUser
        {
            get
            {
                object value = HttpContext.Current.Session["SessionUser"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["SessionUser"] = value;
            }
        }
    }
}