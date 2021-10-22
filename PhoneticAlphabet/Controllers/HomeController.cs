using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneticAlphabet.Models;

namespace PhoneticAlphabet.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(string message)
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Post(string message)
        {
            var list = new MilitaryNotation().Get(message);
            return View("Index",list);
        }
    }
}
