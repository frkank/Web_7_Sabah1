using DersAtamaApp.Models;
using DersAtamaApp.Models.Concrete;
using DersAtamaApp.Models.Concrete.EfCore;
using DersAtamaApp.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DersAtamaApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AssignLesson()
        {
            var model = new EfCoreStudentDal();
            return View(model.GetAll());
        }

        public IActionResult Assign(int id)
        {
            var model2 = new EfCoreCourseDal();
            var context = new EfCoreStudentDal();
            var entity = context.GetByIdWithCourses(id);
            var model = new StudentModel()
            {
                StudentId = entity.StudentId,
                No = entity.No,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                DateOfBirth = entity.DateOfBirth,
                DateOfRegistration = entity.DateOfRegistration,
                Period = entity.Period,
                DepartmentId = entity.DepartmentId,
                SelectedCourses = entity.StudentCourses.Select(x => x.Course).ToList()
            };
            ViewBag.Courses = model2.GetAll();
            return View(model);
        }
    }
}
