using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using identityScaffoldMvc.Models;
using Microsoft.AspNetCore.Authorization;

namespace identityScaffoldMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Private()
        {
            return Ok("Bu sayfayı sadece üye olanlar görebilecek");
        }
        
    }
}
