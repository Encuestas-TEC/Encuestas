using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EncuestasITESRC.Areas.Administrador.Models;
using EncuestasITESRC.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace EncuestasITESRC.Areas.Administrador.Controllers
{
    [Area("Administrador")]

    public class HomeController : Controller
    {
        public IHostingEnvironment Environment { get; set; }

        public HomeController(IHostingEnvironment env)
        {
            Environment = env;
        }

        public IActionResult Index()
        {
            EncuestasRepository repos = new EncuestasRepository();
            return View(repos.GetEncuestasActivas());
        }
       
    }
}