using MvcDataGrid.Models;
using MvcDatagridSample.Models;
using System.Linq;
using System.Web.Mvc;

namespace MvcDatagridSample.Controllers
{
    public class HomeController : Controller
    {
        private IDataProvider<IEntity> dataProvider;
        HomeController(IDataProvider<IEntity> dataProvider)
        {
            this.dataProvider = dataProvider;
        }
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