using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model_in_MVC.Models;

namespace Model_in_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetEmployee();            
            return View(data);
        }
        private Employee GetEmployee()
        {
            return new Employee()
            {
                id = 1,
                address = "India",
                name = "Aniket"
            };
        }
    }
}