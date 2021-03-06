﻿using System;
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
        [Route("Administrador/Preguntas")]
        public IActionResult Index()
        {
            //EncuestasRepository encuestas = new EncuestasRepository();
            //ViewBag.NE = encuestas.GetById(id).Titulo;
            return View();
        }
        [Route("Administrador/AgregarPregunta/{id}")]
        public IActionResult AgregarEncuesta(int id)
        {
            //ViewBag.Admin= 1;
            EncuestasRepository encuestas = new EncuestasRepository();
            ViewBag.NE = encuestas.GetById(id).Titulo;
            return View();
        }
        [HttpPost]
        public IActionResult AgregarPregunta(DAPreguntasViewModel pregunta)
        {
            //ViewBag.Admin= 1;
            if (ModelState.IsValid)
            {
                PreguntasRepository repos = new PreguntasRepository();
                var result = repos.GetPreguntaByContenido(pregunta.Contenido);
                if (result == null)
                {
                    repos.Insert(pregunta);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Ya existe esta pregunta.");
                    return View(pregunta);
                }
            }
            else { return View(pregunta); }
        }
    }
}