using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aerospace.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {     
            return View();
        }
    }
}