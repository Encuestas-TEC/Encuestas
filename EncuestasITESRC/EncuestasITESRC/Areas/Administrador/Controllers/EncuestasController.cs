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
        [Route("Administrador/Encuestas")]
        public IActionResult Index()
        {
            EncuestasRepository repos = new EncuestasRepository();
            return View(repos.GetEncuestasActivas());
        }
        [Route("Administrador/AgregarEncuestas")]
        public IActionResult AgregarEncuesta()
        {
            //ViewBag.Admin= 1;
            return View();
        }
        [HttpPost]
        public IActionResult AgregarEncuesta(DAEncuestasViewModel encuestas)
        {
            //try
            //{
            EncuestasRepository repos = new EncuestasRepository();
            Regex regex = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ0-9 ]+$");
            bool resultado = regex.IsMatch(encuestas.Titulo);
            if (repos.GetEncuestaByNombre(encuestas.Titulo) != null)
            {
                ModelState.AddModelError("", "Ya existe una encuesta con este nombre");
                if (repos.GetEncuestaByNombre(encuestas.Titulo).Estatus == false)
                {
                    ViewBag.Recuperacion = true;
                    ViewBag.IdEncRec = repos.GetEncuestaByNombre(encuestas.Titulo).Id;
                }
                return View(encuestas);
            }
            if (!resultado)
            {
                ModelState.AddModelError("", "El nombre de la encuesta no puede contener caracteres especiales.");
                return View(encuestas);
            }
            Regex reg = new Regex(@"[0-9]| $");
            string exp = encuestas.Titulo.Substring(0, 1);
            bool res = reg.IsMatch(exp);
            if (res)
            {
                ModelState.AddModelError("", "El nombre de la encuesta no puede iniciar con un número.");
                return View(encuestas);
            }

            repos.Insert(encuestas);
            return RedirectToAction("Index", "Encuestas");
        }
    
        //Administrador ------ Editar encuestas-----------------------------------------------------------------------
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
        [HttpPost]
        public IActionResult EditarEncuesta(DAEncuestasViewModel vm)
        {
            //ViewBag.Admin = 1;
            if (ModelState.IsValid)
            {
                //try
                //{
                    EncuestasRepository repos = new EncuestasRepository();
                    Regex regex = new Regex(@"^[a-zA-Z0-9áéíóúÁÉÍÓÚñÑ ]+$");
                    bool resultado = regex.IsMatch(vm.Titulo);
                    if (repos.GetEncuestaByNombre(vm.Titulo).Id != vm.Id) //Permite editar con el mismo nombre siempre y cuando sea el id original
                {
                        ModelState.AddModelError("", "Ya existe una encuesta con este nombre");
                        if (repos.GetEncuestaByNombre(vm.Titulo).Estatus == false)
                        {
                            ViewBag.Recuperacion = true;
                            ViewBag.IdEncRec = repos.GetEncuestaByNombre(vm.Titulo).Id;
                        }
                        return View(vm);
                    }
                    if (!resultado)
                    {
                        ModelState.AddModelError("", "El nombre de la encuesta no puede contener caracteres especiales.");
                        return View(vm);
                    }
                    Regex reg = new Regex(@"[0-9]| $");
                    string exp = vm.Titulo.Substring(0, 1);
                    bool res = reg.IsMatch(exp);
                    if (res)
                    {
                        ModelState.AddModelError("", "El nombre de la encuesta no puede iniciar con un número.");
                        return View(vm);
                    }
                    repos.Update(vm);
                    return RedirectToAction("Index");
                //}
                //catch (Exception ex)
                //{
                //    ModelState.AddModelError("", ex.Message);
                //    return View(vm);
                //}
            }
            else
            {
                return View(vm);
            }
        }
       
        //Administrador ------ Eliminar encuestas-----------------------------------------------------------------------
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
        //Administrador ------ Recuperar encuestas-----------------------------------------------------------------------
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