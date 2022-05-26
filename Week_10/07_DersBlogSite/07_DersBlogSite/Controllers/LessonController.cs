using _07_DersBlogSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_DersBlogSite.Controllers
{
    public class LessonController : Controller
    {
        public IActionResult Index()
        {
            var lessons = new List<Lesson>
            {
                new Lesson {ID=1, LessonName="HTML", Catogory="FrontEnd"},
                new Lesson {ID=2, LessonName="CSS", Catogory="FrontEnd"},
                new Lesson {ID=3, LessonName="Bootstrap", Catogory="FrontEnd"},
                new Lesson {ID=4, LessonName="JavaScript", Catogory="FrontEnd"},
                new Lesson {ID=5, LessonName="Jquery", Catogory="FrontEnd"},
                new Lesson {ID=6, LessonName="React", Catogory="FrontEnd"},
                new Lesson {ID=7, LessonName="C#", Catogory="BackEnd"},
                new Lesson {ID=8, LessonName="PHP", Catogory="BackEnd"}
            };


            return View(lessons);
        }
    }
}
