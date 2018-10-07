using Models.DataAccess.Common;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShopNetMVC.Areas.Centre.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (Session.UserSession)Session[CommonConstants.USER_SESSION];
            if (session == null || session.GrantID != 0)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "login", acction = "index" }));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}