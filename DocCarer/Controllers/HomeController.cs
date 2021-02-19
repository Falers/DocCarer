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
    public class HomeController : Controller
    {

        public List<DoctorViewModel> Doctors => new List<DoctorViewModel>
        {
            new DoctorViewModel
            {
                Name = "Henry",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name ="Paracetamol"
                            },
                            new MedicineViewModel
                            {
                                Name = "Aspirin"
                            }
                        }
                    }
                }
               
            },
            new DoctorViewModel
            {
                Name = "George",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name ="Babyfen"
                            },
                            new MedicineViewModel
                            {
                                Name = "Alfoderm"
                            }
                        }
                    }
                }
            },
            new DoctorViewModel
            {
                Name = "Katie",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta 1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name ="Acnatel"
                            },
                            new MedicineViewModel
                            {
                                Name = "Izotek"
                            }
                        }
                    }
                }
            }

        };

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View(Doctors);
        }

        
    }
}
