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
    public class CarrerasController : Controller
    {
        public IHostingEnvironment Environment { get; set; }

        public CarrerasController(IHostingEnvironment env)
        {
            Environment = env;
        }
        [Route("Administrador/Carreras")]
        public IActionResult Index()
        {
            CarrerasRepository repos = new CarrerasRepository();
            return View(repos.GetCarrerasActivas());
        }

        //Administrador ---- Agregar una Carrera
        [Route("Administrador/AgregarCarrera")]
        public IActionResult AgregarCarrera()
        {
            //ViewBag.Admin = 1;
            return View();
        }
        [HttpPost]
        public IActionResult AgregarCarrera(DACarrerasViewModel carrera)
        {
            //ViewBag.Admin = 1;
            //try
            //{
            CarrerasRepository repos = new CarrerasRepository();
            Regex regex = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]{5,}$");
            bool resultado = regex.IsMatch(carrera.Nombre);
            int x = carrera.Nombre.Length;
            if (x < 5)
            {
                ModelState.AddModelError("", "El nombre es demasiado corto.");
                return View(carrera);
            }
            if (repos.GetCarreraByNombre(carrera.Nombre) != null)
                {
                    ModelState.AddModelError("", "Ya existe una carrera con este nombre");
                    if (repos.GetCarreraByNombre(carrera.Nombre).Estatus == false)
                    {
                        ViewBag.Recuperacion = true;
                        ViewBag.IdEncRec = repos.GetCarreraByNombre(carrera.Nombre).Id;
                    }
                    return View(carrera);
            }
            if (!resultado)
            {
                ModelState.AddModelError("", "El nombre de la carrera no puede contener numeros y/o caracteres especiales.");
                return View(carrera);
            }
            repos.Insert(carrera);
            return RedirectToAction("Index");
            //}
            //catch (Exception ex)
            //{
            //    ModelState.AddModelError("", ex.Message);
            //    return View(carrera);
            //}

        }

        //Administrador ---- Editar una Carrera
        [Route("Administrador/Carreras/EditarCarrera/{id}")]
        public IActionResult EditarCarrera(int id)
        {
            //ViewBag.Admin = 1;
            CarrerasRepository repos = new CarrerasRepository();

            var e = repos.GetCarreraById(id);


            if (e == null)
            {
                return RedirectToAction("Carreras");
            }
            else
            {
                return View(e);
            }
        }

        [HttpPost]
        public IActionResult EditarCarrera(DACarrerasViewModel vm)
        {
            //ViewBag.Admin = 1;
            if (ModelState.IsValid)
            {
                //try
                //{
                CarrerasRepository repos = new CarrerasRepository();
                Regex regex = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]{5,}$");
                bool resultado = regex.IsMatch(vm.Nombre);
                int x = vm.Nombre.Length;
                if (x < 5)
                {
                    ModelState.AddModelError("", "El nombre es demasiado corto.");
                    return View(vm);
                }
                //------------------Antiguo--------------------------------------------------------
                //if (repos.GetCarreraByNombre(vm.Nombre) != null)
                //{
                //    ModelState.AddModelError("", "Ya existe una carrera con este nombre");
                //    if (repos.GetCarreraByNombre(vm.Nombre).Estatus == false)
                //    {
                //        ViewBag.Recuperacion = true;
                //        ViewBag.IdEncRec = repos.GetCarreraByNombre(vm.Nombre).Id;
                //    }
                //    return View(vm);
                //}
                //------------------Antiguo--------------------------------------------------------

                //------------------Nuevo----------------------------------------------------------
                if (repos.GetCarreraByNombre(vm.Nombre).Id != vm.Id) //Permite editar con el mismo nombre siempre y cuando sea el id original
                {
                    ModelState.AddModelError("", "Ya existe una carrera con este nombre");
                    if (repos.GetCarreraByNombre(vm.Nombre).Estatus == false)
                    {
                        ViewBag.Recuperacion = true;
                        ViewBag.IdEncRec = repos.GetCarreraByNombre(vm.Nombre).Id;
                    }
                    return View(vm);
                }
                if (!resultado)
                {
                     ModelState.AddModelError("", "El nombre de la carrera no puede contener numeros y/o caracteres especiales.");
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
       
        //Administrador ---- Eliminar una Carrera
        [HttpPost]
        public IActionResult EliminarCarrera(int id)
        {
            //ViewBag.Admin = 1;
            CarrerasRepository repos = new CarrerasRepository();
            var v = repos.GetById(id);
            if (v != null)
            {
                repos.BajaLogica(id);
                ViewBag.Mensaje = "La carrera ha sido eliminada exitosamente.";
            }
            else
            ViewBag.Mensaje = "La carrera no existe o ya ha sido eliminada.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RecuperarCarrera(int id)
        {
            CarrerasRepository repos = new CarrerasRepository();
            repos.Recuperacion(id);
            return RedirectToAction("Index");
        }
    }
}