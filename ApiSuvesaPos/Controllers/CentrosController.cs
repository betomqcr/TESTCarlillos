using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSuvesaPos.Controllers
{
    public class CentrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
