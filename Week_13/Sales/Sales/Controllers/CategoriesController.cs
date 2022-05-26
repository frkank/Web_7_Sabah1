using Microsoft.AspNetCore.Mvc;
using Sales.Models.Abstract;
using Sales.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoriesController(ICategoryRepository categoriesController)
        {
            _categoryRepository = categoriesController;
        }
        public IActionResult Index()
        {
            return View(_categoryRepository.GetAll());
        }
    }
}
