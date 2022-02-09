using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COREDEMO.Controllers
{
    public class category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
