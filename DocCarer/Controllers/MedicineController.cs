using DocCarer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DocCarer.Controllers
{
    public class MedicineController : Controller
    {


        public MedicineController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
