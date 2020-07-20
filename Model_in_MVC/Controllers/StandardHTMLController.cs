using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model_in_MVC.Models;


namespace Model_in_MVC.Controllers
{
    public class StandardHTMLController : Controller
    {
        // GET: StandardHTML
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult about(string name = null)  
        {
            return View();
        }
    }
}