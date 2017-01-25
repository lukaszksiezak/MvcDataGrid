using MvcDatagridSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDatagridSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            MvcDatagridSample.Models.SampleCRMEntities context = new Models.SampleCRMEntities();

            var users = context.Users.ToList();
            return View(users);
        }

        public ActionResult EditUser(Users user)
        {
            return View(user);
        }
    }
}