using System.Linq;
using System.Web.Mvc;
using RssFeed.Models;

namespace RssFeed.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
