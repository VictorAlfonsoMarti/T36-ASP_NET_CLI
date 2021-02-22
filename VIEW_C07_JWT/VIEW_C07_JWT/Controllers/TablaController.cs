using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VIEW_C07_JWT.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Tabla()
        {
            return View();
        }
    }
}
