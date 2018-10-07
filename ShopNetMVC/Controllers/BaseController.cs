using System.Web.Mvc;
using System.Web.Routing;
using Models.DataAccess.Common;

namespace ShopNetMVC.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (Session.UserSession)Session[CommonConstants.USER_SESSION];
            if(session == null || session.GrantID == 1)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "login", acction = "index" }));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}