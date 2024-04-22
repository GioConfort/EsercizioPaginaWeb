using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EsercizioPaginaWeb.Controllers
{
    public class MenuController : Controller
    {

        public MenuController()
        {
        
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}