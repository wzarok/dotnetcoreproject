using businesslayer.Concrete;
using dataaccesslayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COREDEMO.Controllers
{
    public class blogc : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult blogreadall(int id)
        {
            var values = bm.GetBlogById(id);
            return View(values);
        }
    }
}
