using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StringReverser.Models;

namespace StringReverser.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string inputstring)
        {
            if (inputstring == null)
            {
                return View();
            }
            SuperString superString = new SuperString(inputstring);
            
            ViewData["result"] = superString.Reverse().ToString();
            return View();
        }
        
    }
}