using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Controllers {
    public class NewController : Controller {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string Get()
        {
            return "Another service.";
        }
    }
}
