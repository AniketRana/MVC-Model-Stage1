using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model_in_MVC.Models;

namespace Model_in_MVC.Controllers
{
    public class TemplateHelperController : Controller
    {
        // GET: TemplateHelper
        public ActionResult Index()
        {
            Emp_template e = new Emp_template()
            {
                id = 1,
                Name = "Aniket",
                Email = "Aniket@gmail.com",
                BirthDate = DateTime.Now,
                IsOnline = true                
            };
            return View(e);
        }

        public ActionResult edit() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult edit(Emp_template e)
        {
            return View();
        }
    }
}