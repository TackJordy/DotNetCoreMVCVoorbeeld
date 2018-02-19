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
        public string Index(string name)
        {
            return $"Hallo {name}";
        }

       
    }
}
