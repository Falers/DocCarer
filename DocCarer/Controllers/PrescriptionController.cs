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
    public class PrescriptionController : Controller
    {

        public PrescriptionController()
        {
           
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
