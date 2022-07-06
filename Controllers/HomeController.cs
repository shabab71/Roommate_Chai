using HomeRental.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeRental.Controllers
{
    public class HomeController : Controller
    {
  
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Privacy()
        {
            return View();
        }

    }
}
