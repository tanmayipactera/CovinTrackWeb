using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BELayer;
using BusinessCls;

namespace CovinWeb.Controllers
{
    public class VaccineController : Controller
    {
        public BusinessLayer baobj = new BusinessLayer();
        public Vaccinated va = new Vaccinated();
        [HttpGet]
        public IActionResult Create()
        {
            return View();
            
        }
        [HttpPost]
        public IActionResult Create([Bind] Vaccinated va)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int resp = baobj.VaccinatedDetailss(va);
                    TempData["msg"] = resp;
                }
            }
            catch(Exception ex)
            {
                TempData["msg"] = ex.Message;
            }
            return View();
        }
    }
}
