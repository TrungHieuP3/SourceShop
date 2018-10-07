using System.Web.Mvc;
using System.Linq;

namespace ShopNetMVC.Areas.Centre.Controllers
{
    public class DashboardController : BaseController
    {
        // GET: Centre/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}