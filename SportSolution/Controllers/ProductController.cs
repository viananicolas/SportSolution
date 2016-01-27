using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportSolution.Domain.Abstract;

namespace SportSolution.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;

        public ProductController(IProductsRepository productRepository)
        {
            this.repository = productRepository;
        }
        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}