<%@ Application Language="C#" %>
<%@ Import Namespace="RSVP1" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        Application["Visitors"] = 0;

        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);
    }

  void Session_Start(object sender, EventArgs e)
    {
         // Код, выполняемый при запуске нового сеанса
         // Increment Visitors counter
         Application["Visitors"] = long.Parse(Application["Visitors"].ToString()) + 1;
    } 


</script>
