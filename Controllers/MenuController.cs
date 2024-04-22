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
            return Redirect("https://www.amazon.it/ref=nav_logo");
        }

        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}