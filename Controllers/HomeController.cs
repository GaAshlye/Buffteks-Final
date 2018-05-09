using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BuffteksWebsite.Models;

namespace BuffteksWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //List<string> results = new List<string>();
            return View();
        }

    
    }
}
