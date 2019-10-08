using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() // action result can be thought of as "rendered HTML" 
        {
            return View(); // the view method looks for the view file that the method name calls for in this case it Index() 
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - The Tech Academy";

            return View();
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id=1,
                    FirstName = "Daithi",
                    LastName = "DeNogla"
                },
                new Instructor
                {
                    Id=2,
                    FirstName = "BigJiggly",
                    LastName = "Panda"

                },
                new Instructor
                {
                    Id= 3,
                    FirstName="Joe",
                    LastName="Shmoe"
                }
            };
            return View(instructors);
        }
        public ActionResult Instructor()
        {
            return View();
        }
    }
}