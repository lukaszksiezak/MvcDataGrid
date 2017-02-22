using MvcDataGrid.Models;
using MvcDatagridSample.Models;
using System.Linq;
using System.Web.Mvc;

namespace MvcDatagridSample.Controllers
{
    public class HomeController : Controller
    {
        private IDataProvider<Users> dataProvider;
        public HomeController(IDataProvider<Users> dataProvider)
        {
            this.dataProvider = dataProvider;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View(this.dataProvider.GetAllUsers().ToList());
        }

        [HttpGet]
        public ActionResult EditUser(int userId)
        {
            return View(this.dataProvider.GetById(userId));
        }

        [HttpPost]
        public ActionResult EditUser(Users user)
        {
            dataProvider.Edit(user);
            return Redirect("/Home/Index");
        }
    }
}