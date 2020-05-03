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
    public class EncuestasController : Controller
    {
        public IHostingEnvironment Environment { get; set; }

        public EncuestasController(IHostingEnvironment env)
        {
            Environment = env;
        }

        //Administrador ------ Ir a encuestas GET-------------------------------------------------------------------------------
        [Route("Administrador/Encuestas")]
        public IActionResult Index()
        {
            EncuestasRepository repos = new EncuestasRepository();
            return View(repos.GetEncuestasActivas());
        }

        //Administrador ------ Editar una encuesta GET--------------------------------------------------------------------------
        [Route("Administrador/AgregarEncuestas")]
        public IActionResult AgregarEncuesta()
        {
            //ViewBag.Admin= 1;
            return View();
        }

        //Administrador ------ Agregar una encuesta POST-----------------------------------------------------------------------
        [HttpPost]
        public IActionResult AgregarEncuesta(DAEncuestasViewModel encuesta)
        {
            //ViewBad.Admin = 1;
            if (ModelState.IsValid)
            {
                try
                {
                    EncuestasRepository RepositorioEncuestas = new EncuestasRepository();

                    var resultTitulo = RepositorioEncuestas.GetEncuestasByTitulo(encuesta.Titulo);

                    Regex regexTitulo = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ0-9 ]{6,}$");
                    bool resultadoRegexTitulo = regexTitulo.IsMatch(encuesta.Titulo);

                    if (!resultadoRegexTitulo)
                    {
                        ModelState.AddModelError("", "El titulo debe contener 6 o más caracteres, no puede iniciar con un número y no puede contener caracteres especiales.");
                        return View(encuesta);
                    }
                    Regex regexIniciaNum = new Regex(@"[0-9]| $");
                    string expresion = encuesta.Titulo.Substring(0, 1);
                    bool resultRegexIniciaNum = regexIniciaNum.IsMatch(expresion);
                    if (resultRegexIniciaNum)
                    {
                        ModelState.AddModelError("", "El nombre de la encuesta no puede iniciar con un número.");
                        return View(encuesta);
                    }
                    if (resultTitulo == null)
                    {
                        RepositorioEncuestas.Insert(encuesta);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Ya existe una encuesta con este nombre.");
                        if (RepositorioEncuestas.GetEncuestasByTitulo(encuesta.Titulo).Estatus == false)
                        {
                            ViewBag.Recuperacion = true;
                            ViewBag.IdEncRec = RepositorioEncuestas.GetEncuestasByTitulo(encuesta.Titulo).Id;
                        }
                        return View(encuesta);
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View(encuesta);
                }
            }
            else
            {
                return View(encuesta);
            }   
        }
    
        //Administrador ------ Editar una encuesta GET--------------------------------------------------------------------------
        [Route("Administrador/Encuestas/EditarEncuesta/{id}")]
        public IActionResult EditarEncuesta(int id)
        {
            //ViewBag.Admin = 1;
            //ViewBag.Nombre = id;
            EncuestasRepository repos = new EncuestasRepository();

            var e = repos.GetEncuestasById(id);

            if (e == null)
            {
                return RedirectToAction("Encuestas");
            }
            else
            {
                return View(e);
            }
        }

        //Administrador ------ Editar una encuesta POST------------------------------------------------------------------------
        [HttpPost]
        public IActionResult EditarEncuesta(DAEncuestasViewModel vm)
        {
            //ViewBag.Admin = 1;
            if (ModelState.IsValid)
            {
                try
                {
                    EncuestasRepository RepositorioEncuestas = new EncuestasRepository();

                    var resultTitulo = RepositorioEncuestas.GetEncuestasByTitulo(vm.Titulo);

                    Regex regexTitulo = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ0-9 ]{6,}$");
                    bool resultadoRegexTitulo = regexTitulo.IsMatch(vm.Titulo);

                    if (!resultadoRegexTitulo)
                    {
                        ModelState.AddModelError("", "El titulo debe contener 6 o más caracteres, no puede iniciar con un número y no puede contener caracteres especiales.");
                        return View(vm);
                    }
                    Regex regexIniciaNum = new Regex(@"[0-9]| $");
                    string expresion = vm.Titulo.Substring(0, 1);
                    bool resultRegexIniciaNum = regexIniciaNum.IsMatch(expresion);
                    if (resultRegexIniciaNum)
                    {
                        ModelState.AddModelError("", "El nombre de la encuesta no puede iniciar con un número.");
                        return View(vm);
                    }
                    if (resultTitulo == null)
                    {
                        RepositorioEncuestas.Update(vm);
                        return RedirectToAction("Index");
                    }
                    else if (resultTitulo.Id == vm.Id)
                    {
                        resultTitulo.Titulo = vm.Titulo;
                        RepositorioEncuestas.Update(vm);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Ya existe una encuesta con este nombre.");
                        if (RepositorioEncuestas.GetEncuestasByTitulo(vm.Titulo).Estatus == false)
                        {
                            ViewBag.Recuperacion = true;
                            ViewBag.IdEncRec = RepositorioEncuestas.GetEncuestasByTitulo(vm.Titulo).Id;
                        }
                        return View(vm);
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View(vm);
                }
            }
            else
            {
                return View(vm);
            }
        }
       
        //Administrador ------ Eliminar una encuesta POST----------------------------------------------------------------------
        [HttpPost]
        public IActionResult EliminarEncuesta(int id)
        {
            //ViewBag.Admin = 1;
            EncuestasRepository repos = new EncuestasRepository();
            var v = repos.GetById(id);
            if (v != null)
            {
                repos.BajaLogica(id);
                ViewBag.Mensaje = "La encuesta ha sido eliminar exitosamente.";
            }
            else
            ViewBag.Mensaje = "La encuesta no existe o ya ha sido eliminada.";
            return RedirectToAction("Index");
        }

        //Administrador ------ Recuperar una encuesta POST---------------------------------------------------------------------
        [HttpPost]
        public IActionResult RecuperarEncuesta(int id)
        {
            EncuestasRepository repos = new EncuestasRepository();
            repos.Recuperacion(id);
            //var res = repos.GetEncuestaBynombre(titulo);

            //repos.Recuperacion(res.Id);
            return RedirectToAction("Index");
        }
    }
}