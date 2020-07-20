using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model_in_MVC.Models;
namespace Model_in_MVC.Controllers
{
    public class LamdaController : Controller
    {
        // GET: Lamda
        public ActionResult Index()
        {
            Emp emp = new Emp()
            {
                address = "Surat",
                isEmp = true,
                name = "Aniket"
            };

            return View(emp);
        }
        [HttpPost]
        public ActionResult Index(Emp emp) 
        {             
            return View();
        }
    }
}