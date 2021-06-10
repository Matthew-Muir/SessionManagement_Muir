using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SessionManagement
{
    public static class UrlStringParse
    {

        public static string ReturnUserName(string url)
        {
            int ui = url.IndexOf("?u=") + 3;
            int pi = url.IndexOf("&p=");
            int len = pi - ui;
            string done = url.Substring(ui, len);
            return done;
        }

        public static string ReturnPassword(string url)
        {

            int pi = url.IndexOf("&p=") + 3;
            string done = url.Substring(pi);
            return done;
        }

        public static string ReturnPage(string url)
        {

            int pi = url.IndexOf("&p=");
            int len = url.Length - pi;

            string done = url.Substring(0, len);
            return done;
        }

        public static string RebuildUrl(string page, string user, string pass)
        {
            return page + "?u=" + user + "&p=" + pass;
        }

        public static string UnsaltHash(string hash)
        {
            return hash.Substring(0, hash.Length - 1);
        }
    }

}