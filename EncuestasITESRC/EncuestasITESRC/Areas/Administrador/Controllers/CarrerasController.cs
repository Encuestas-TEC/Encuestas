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

        //Administrador ---- Ir a carreras GET---------------------------------------------------------------------------------------
        [Route("Administrador/Carreras")]
        public IActionResult Index()
        {
            CarrerasRepository repos = new CarrerasRepository();
            return View(repos.GetCarrerasActivas());
        }

        //Administrador ---- Agregar una carrera GET---------------------------------------------------------------------------------
        [Route("Administrador/AgregarCarrera")]
        public IActionResult AgregarCarrera()
        {
            //ViewBag.Admin = 1;
            return View();
        }

        //Administrador ---- Agregar una carrera POST-------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult AgregarCarrera(DACarrerasViewModel carrera)
        {
            //ViewBag.Admin = 1;
            if (ModelState.IsValid)
            {
                try
                {
                    CarrerasRepository RepositorioCarreras = new CarrerasRepository();

                    var ResultNombre = RepositorioCarreras.GetCarreraByNombre(carrera.Nombre);
                    var ResultClave = RepositorioCarreras.GetCarreraByClave(carrera.Clave);
                    var ResultClaveCarrera = RepositorioCarreras.GetCarreraByClaveNombre(carrera.Clave, carrera.Nombre);

                    Regex regClave = new Regex(@"^[a-zA-Z]+$");
                    Regex regNombre = new Regex(@"^[a-zA-ZñÑáéíóúÁÉÍÓÚ\s  ]{6,}$");
                    bool resultClave = true;
                    resultClave = regClave.IsMatch(carrera.Clave);
                    bool resultNombre = true;
                    resultNombre = regNombre.IsMatch(carrera.Nombre);

                    if (!resultClave)
                    {
                        ModelState.AddModelError("", "La clave solo acepta 2 letras sin espacios ni caracteres especiales.");
                        return View(carrera);
                    }

                    if (!resultNombre)
                    {
                        ModelState.AddModelError("", "El nombre debe contener 6 o más caracteres, no puede contener números y/o caracteres especiales.");
                        return View(carrera);
                    }

                    Regex regexNumInicio = new Regex(@"[0-9]| $");
                    string expresion = carrera.Nombre.Substring(0, 1);
                    bool resultadoRegexNum = regexNumInicio.IsMatch(expresion);

                    if (resultadoRegexNum)
                    {
                        ModelState.AddModelError("", "El nombre de la carrera no puede iniciar con un numero.");
                        return View(carrera);
                    }

                    if (ResultClaveCarrera == null)
                    {
                        if (ResultNombre != null)
                        {
                            ModelState.AddModelError("", "Ya existe una carrera con el mismo nombre.");
                            if (RepositorioCarreras.GetCarreraByNombre(carrera.Nombre).Estatus == false)
                            {
                                ViewBag.Recuperacion = true;
                                ViewBag.IdEncRec = RepositorioCarreras.GetCarreraByNombre(carrera.Nombre).Id;
                            }
                            return View(carrera);
                        }
                        if (ResultClave != null)
                        {
                            ModelState.AddModelError("", "Ya existe una carrera con la misma clave.");
                            return View(carrera);
                        }

                        RepositorioCarreras.Insert(carrera);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Ya existe esta carrera.");
                        return View(carrera);
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View(carrera);
                }
            }
            else
            {
                return View(carrera);
            }

        }

        //Administrador ---- Editar una carrera GET---------------------------------------------------------------------------------
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

        //Administrador ---- Editar una carrera POST--------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult EditarCarrera(DACarrerasViewModel vm)
        {
            //ViewBag.Admin = 1;
            if (ModelState.IsValid)
            {
                try
                {
                    CarrerasRepository carreraRepos = new CarrerasRepository();

                    var ResultNombre = carreraRepos.GetCarreraByNombre(vm.Nombre);
                    var ResultClave = carreraRepos.GetCarreraByClave(vm.Clave);
                    var ResultClaveCarrera = carreraRepos.GetCarreraByClaveNombre(vm.Clave, vm.Nombre);

                    Regex regClave = new Regex(@"^[a-zA-Z]+$");
                    Regex regNombre = new Regex(@"^[a-zA-ZñÑáéíóúÁÉÍÓÚ\s  ]{6,}$");
                    bool resultClave = true;
                    resultClave = regClave.IsMatch(vm.Clave);
                    bool resultNombre = true;
                    resultNombre = regNombre.IsMatch(vm.Nombre);

                    if (!resultClave)
                    {
                        ModelState.AddModelError("", "La clave solo acepta 2 letras sin espacios ni caracteres especiales.");
                        return View(vm);
                    }

                    if (!resultNombre)
                    {
                        ModelState.AddModelError("", "El nombre debe contener 6 o más caracteres, no puede contener números y/o caracteres especiales.");
                        return View(vm);
                    }

                    Regex regexNumInicio = new Regex(@"[0-9]| $");
                    string expresion = vm.Nombre.Substring(0, 1);
                    bool resultadoRegexNum = regexNumInicio.IsMatch(expresion);

                    if (resultadoRegexNum)
                    {
                        ModelState.AddModelError("", "El nombre de la carrera no puede iniciar con un numero.");
                        return View(vm);
                    }

                    if (ResultClaveCarrera == null)
                    {
                        if (ResultNombre != null)
                        {
                            ModelState.AddModelError("", "Ya existe una carrera con el mismo nombre.");
                            if (carreraRepos.GetCarreraByNombre(vm.Nombre).Estatus == false)
                            {
                                ViewBag.Recuperacion = true;
                                ViewBag.IdEncRec = carreraRepos.GetCarreraByNombre(vm.Nombre).Id;
                            }
                            return View(vm);
                        }
                        if (ResultClave != null)
                        {
                            ModelState.AddModelError("", "Ya existe una carrera con la misma clave.");
                            if (carreraRepos.GetCarreraByNombre(vm.Nombre).Estatus == false)
                            {
                                ViewBag.Recuperacion = true;
                                ViewBag.IdEncRec = carreraRepos.GetCarreraByClave(vm.Clave).Id;
                            }
                            return View(vm);
                        }

                        carreraRepos.Update(vm);
                        return RedirectToAction("Index");
                    }
                    else if (ResultClaveCarrera.Id == vm.Id)
                    {

                        if (ResultNombre != null)
                        {
                            if (vm.Id != ResultNombre.Id)
                            {
                                ModelState.AddModelError("", "Ya existe una carrera con el mismo nombre.");
                                return View(vm);
                            }
                        }
                        if (ResultClave != null)
                        {
                            if (vm.Id != ResultClave.Id)
                            {
                                ModelState.AddModelError("", "Ya existe una carrera con la misma clave.");
                                return View(vm);
                            }
                        }

                        ResultClaveCarrera.Clave = vm.Clave;
                        ResultClaveCarrera.Nombre = vm.Nombre;
                        carreraRepos.Update(ResultClaveCarrera);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Ya existe esta carrera.");
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

        //Administrador ---- Eliminar una carrera POST---------------------------------------------------------------------------------
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

        //Administrador ---- Recuperar una carrera POST---------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult RecuperarCarrera(int id)
        {
            CarrerasRepository repos = new CarrerasRepository();
            repos.Recuperacion(id);
            return RedirectToAction("Index");
        }
    }
}