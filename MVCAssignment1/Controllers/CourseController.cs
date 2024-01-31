using MVCAssignment1.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignment1.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> course = new List<Course>()
        {
new Course{CId=1, CName="WebTech", CFee=30000, Technology="Java",CStartDate= new DateTime(day:05,month:10, year:2023),CEndtDate= new DateTime(day:20,month:12, year:2023) },
new Course{CId=2, CName="Sql", CFee=30000, Technology="Python",CStartDate= new DateTime(day:21,month:06, year:2022),CEndtDate= new DateTime(day:15,month:01, year:2024) },
new Course{CId=1, CName="Programming", CFee=30000, Technology="c++",CStartDate= new DateTime(day:18,month:11, year:2023),CEndtDate= new DateTime(day:30,month:12, year:2023) },
new Course{CId=1, CName="SpringMVC", CFee=30000, Technology="Java",CStartDate= new DateTime(day:10,month:01, year:2020),CEndtDate= new DateTime(day:29,month:11, year:2020) },
new Course{CId=1, CName="DataStructres", CFee=30000, Technology="Python",CStartDate= new DateTime(day:14,month:07, year:2021),CEndtDate= new DateTime(day:30,month:09, year:2021) },
        };

        public ActionResult Index()
        {
            return View(course);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        [HttpPost]
        public ActionResult Create(Course courses)
        {
            if (ModelState.IsValid)
            {
                course.Add( courses);
                return RedirectToAction("Index");
            }
            return View(courses);
        }
    }
}