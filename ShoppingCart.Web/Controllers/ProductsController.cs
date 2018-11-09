using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCart.Core.Facade;
namespace ShoppingCart.Web.Controllers
{
    public class ProductsController : Controller
    {
        private IPoductRepository repo;
        public ProductsController(IPoductRepository repo)
        {
            this.repo = repo;
        }
        public ActionResult Index()
        {
            return View(repo.FindAll());
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