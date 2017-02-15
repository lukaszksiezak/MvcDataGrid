using MvcDatagridSample.Models;
using System.Linq;
using System.Web.Mvc;

namespace MvcDatagridSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult EditUser(int userId)
        {

            return View();
        }
    }
}