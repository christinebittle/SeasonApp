using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeasonApp.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: Course/Show
        public ActionResult Show()
        {
            //objective: pass information about the course name and course code to the Show.cshtml

            string CourseName = "Web Application Development";
            string CourseDesc = "Learning how to build server rendered pages that connect to a database";

            ViewData["CourseName"] = CourseName;
            ViewData["CourseDesc"] = CourseDesc;

            return View();
        }
    }
}