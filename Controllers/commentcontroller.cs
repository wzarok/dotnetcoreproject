using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COREDEMO.Controllers
{
    public class commentcontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult partialaddcomment()
        {
            return PartialView();
        }
        public PartialViewResult commentlistbyblog()
        {
            return PartialView();
        }
    }
}
