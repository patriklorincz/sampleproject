using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class ProductMVCController : Controller
    {
        // GET: ProductMVC
        public ActionResult Index()
        {
            return View();
        }
    }
}