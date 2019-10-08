using MvcTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //things you can do within controllers
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\HP\OneDrive\Documents\C#-Projects\TTA-Basic-C-Sharp-Projects\MvcTutorial\Log.txt", text);

            //Random ran = new Random(10);
            //int num = ran.Next();

            //if (num > 20000)
            //{
            //    return View("About");
            //}

            //viewbag.randomnumber = num;

            //return Content("Hello!");

            //return RedirectToAction("Contact");

            //throw new Exception("Hey Baunch this page isn't working anymore!");

            //List<string> names = new List<string>
            //{
            //    "jesse",
            //    "joe",
            //    "toney"
            //};

            //return View(names);
            User user = new User();
            user.ID = 1;
            user.FirstName = "Joe";
            user.LastName = "Tony";
            user.Age = 47;

            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}