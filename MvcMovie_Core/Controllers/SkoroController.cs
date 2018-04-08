using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie_Core.Controllers
{
    public class SkoroController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Skoro/Test.cshtml");
        }
    }
}