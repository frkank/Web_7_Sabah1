using Microsoft.AspNetCore.Mvc;
using Sales.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductsController(IProductRepository productsRepository)
        {
            _productRepository = productsRepository;
        }
        public IActionResult Index()
        {
            return View(_productRepository.GetAll());
        }
    }
}
