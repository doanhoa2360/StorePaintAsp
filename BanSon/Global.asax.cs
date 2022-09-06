using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BanSon
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        protected void Session_Start()
        {
            Session["UserAdmin"] = "";
            Session["UserId"] = "1";
            Session["FullName"] = "";
            Session["Img"] = "";
            Session["MyCart"] = "";
            // L?u th�ng tin ??ng nh?p trang ng??i d�ng
            Session["UserCustomer"] = "";
            Session["CustomerId"] = "";

        }
    }
}
