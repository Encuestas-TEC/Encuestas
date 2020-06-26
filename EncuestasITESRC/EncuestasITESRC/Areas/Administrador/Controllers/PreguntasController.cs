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
    public class PreguntasController : Controller
    {
        public IActionResult Index(int id)
        {
            EncuestasRepository encuestas = new EncuestasRepository();
            ViewBag.NE = encuestas.GetById(id).Titulo;
            return View();
        }
    }
}