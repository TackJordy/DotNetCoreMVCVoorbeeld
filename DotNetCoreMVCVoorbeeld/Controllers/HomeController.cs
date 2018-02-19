using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreMVCVoorbeeld.Models;

namespace DotNetCoreMVCVoorbeeld.Controllers
{
    public class HomeController : Controller
    {
        private string[] groenten = {"Rode kool","Spruitjes","Wortel","Spinazie" };
        public ViewResult Index(string name)
        {
            ViewBag.Groet = DateTime.Now.Hour < 12 ? "Goeiemorgen" : "Goeiemiddag";
            return View();
        }

        public ViewResult Groenten(string zoekGroente)
        {
            ViewBag.Groenten = groenten;
            if (!string.IsNullOrEmpty(zoekGroente))
            {
                ViewBag.Zoekresultaat = $"de gezochte groente is de {Array.IndexOf(groenten, zoekGroente) + 1}e uit de lijst";
            }
            
            return View();
        }


    }
}
