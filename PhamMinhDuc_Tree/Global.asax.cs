using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace PhamMinhDuc_Tree
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application.Lock();
            System.IO.StreamReader stReader = new System.IO.StreamReader(Server.MapPath("FileTXT/sl.txt"));
            String s = stReader.ReadLine();
            stReader.Close();

            Application.Add("Luot_truy_cap", s);
            Application["So_nguoi_online"] = 0;
            Application.UnLock();
        }

        void Application_End(object sender, EventArgs e)
        {

        }

        void Application_Error(object sender, EventArgs e)
        {

        }

        void Session_Start(object sender, EventArgs e)
        {
            Application["So_nguoi_online"] = int.Parse(Application["So_nguoi_online"].ToString()) + 1;
            Application["Luot_truy_cap"] = int.Parse(Application["Luot_truy_cap"].ToString()) + 1;
            System.IO.StreamWriter stWriter = new System.IO.StreamWriter(Server.MapPath("FileTXT/sl.txt"));
            stWriter.Write(Application["Luot_truy_cap"]);
            stWriter.Close();
        }

        void Session_End(object sender, EventArgs e)
        {
            Application["So_nguoi_online"] = int.Parse(Application["So_nguoi_online"].ToString()) - 1;
        }
    }
}