using System.Web.Mvc;

namespace Shop.Areas.Centre
{
    public class CentreAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Centre";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Centre_default",
                "Centre/{controller}/{action}/{id}",
                new { action = "Index", contrller = "Dashboard", id = UrlParameter.Optional }
            );
        }
    }
}
