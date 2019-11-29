using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Grzadka.DAL;
using Grzadka.Models;
using Grzadka.ViewModels;

namespace Grzadka.Controllers
{
    public class HomeController : Controller
    {
        private StoreContext db = new StoreContext();
        // GET: Home
        public ActionResult Index()
        {
            var categories = db.Categories;
            var newArrivals = db.Plants.Where(a => !a.IsHidden).OrderByDescending(a => a.DateAdded).Take(3).ToList();
            var bestsellers = db.Plants.Where(a => !a.IsHidden && a.IsBestseller).OrderBy(g => Guid.NewGuid()).Take(3).ToList(); //losuje 3 bestsellery

            var vm = new HomeViewModel()
            {
                Bestsellers = bestsellers,
                Categories = categories,
                NewArrivals = newArrivals
            };

            return View(vm);
        }
        public ActionResult StaticContent(string viewname)
        {
            return View(viewname);
        }
    }
}