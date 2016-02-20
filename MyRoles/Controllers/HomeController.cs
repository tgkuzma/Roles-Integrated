using System.Web.Mvc;

namespace MyRoles.Controllers
{
    [AuthorizePermission(Roles = "Admin")]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [AuthorizePermission(Roles = "Something")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}