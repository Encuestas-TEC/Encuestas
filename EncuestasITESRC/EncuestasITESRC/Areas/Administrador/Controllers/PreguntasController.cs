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
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AgregarPregunta(DAPreguntasViewModel pregunta)
        {
            if (ModelState.IsValid)
            {
                PreguntasRepository repos = new PreguntasRepository();
                repos.Insert(pregunta);
                return RedirectToAction("Index");
            }
            else
            {
                return View(pregunta);
            }
        }
    }
}