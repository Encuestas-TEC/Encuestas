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
    public class CategoriasController : Controller
    {
        public IHostingEnvironment Environment { get; set; }

        public CategoriasController(IHostingEnvironment env)
        {
            Environment = env;
        }

        //Administrador ---- Ir a categorias GET---------------------------------------------------------------------------------------
        [Route("Administrador/Categorias")]
        public IActionResult Index()
        {
            CategoriasRepository repos = new CategoriasRepository();
            return View(repos.GetCategoriasActivas());
        }

        //Administrador ---- Agregar una categoria GET---------------------------------------------------------------------------------
        [Route("Administrador/AgregarCategoria")]
        public IActionResult AgregarCategoria()
        {
            //ViewBag.Admin = 1;
            return View();
        }

        //Administrador ---- Agregar una categoria POST--------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult AgregarCategoria(DACategoriasViewModel categoria)
        {
            //ViewBag.Admin = 1;
            if (ModelState.IsValid)
            {
                try
                {
                    CategoriasRepository RepositorioCategorias = new CategoriasRepository();

                    var ResultNombre = RepositorioCategorias.GetCategoriaByNombre(categoria.Nombre);
                    Regex regexNombre = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ0-9 ]{6,}$");
                    bool resultNombreCat = regexNombre.IsMatch(categoria.Nombre);

                    if (!resultNombreCat)
                    {
                        ModelState.AddModelError("", "El nombre debe contener 6 o más caracteres, no puede iniciar con un número y no puede contener caracteres especiales.");
                        return View(categoria);
                    }

                    Regex regexIniciaNum = new Regex(@"[0-9]| $");
                    string expresion = categoria.Nombre.Substring(0, 1);
                    bool resultRegexIniciaNum = regexIniciaNum.IsMatch(expresion);
                    if (resultRegexIniciaNum)
                    {
                        ModelState.AddModelError("", "El nombre de la categoria no puede iniciar con un numero.");
                        return View(categoria);
                    }
                    if (ResultNombre == null)
                    {
                        RepositorioCategorias.Insert(categoria);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Ya existe una categoria con el mismo nombre.");
                        if (RepositorioCategorias.GetCategoriaByNombre(categoria.Nombre).Estatus == false)
                        {
                            ViewBag.Recuperacion = true;
                            ViewBag.IdEncRec = RepositorioCategorias.GetCategoriaByNombre(categoria.Nombre).Id;
                        }
                        return View(categoria);
                    }
                    
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View(categoria);
                }
            }
            else
            {
                return View(categoria);
            }
        }

        //Administrador ---- Editar una categoria GET-----------------------------------------------------------------------------------
        [Route("Administrador/Categorias/EditarCategoria/{id}")]
        public IActionResult EditarCategoria(int id)
        {
            //ViewBag.Admin = 1;
            CategoriasRepository repos = new CategoriasRepository();

            var e = repos.GetCategoriaById(id);


            if (e == null)
            {
                return RedirectToAction("Categorias");
            }
            else
            {
                return View(e);
            }
        }

        //Administrador ---- Editar una categoria POST----------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult EditarCategoria(DACategoriasViewModel vm)
        {
            //ViewBag.Admin = 1;
            if (ModelState.IsValid)
            {
                try
                {
                    CategoriasRepository RepositorioCategorias = new CategoriasRepository();

                    var ResultNombre = RepositorioCategorias.GetCategoriaByNombre(vm.Nombre);

                    Regex regexNombre = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ0-9 ]{6,}$");
                    bool resultNombreCat = regexNombre.IsMatch(vm.Nombre);

                    if (!resultNombreCat)
                    {
                        ModelState.AddModelError("", "El nombre debe contener 6 o más caracteres, no puede iniciar con un número y no puede contener caracteres especiales.");
                        return View(vm);
                    }

                    Regex regexIniciaNumero = new Regex(@"[0-9]| $");
                    string expresion = vm.Nombre.Substring(0, 1);
                    bool resultIniciaNumero = regexIniciaNumero.IsMatch(expresion);
                    if (resultIniciaNumero)
                    {
                        ModelState.AddModelError("", "El nombre de la categoria no puede iniciar con un numero.");
                        return View(vm);
                    }
                    if (ResultNombre == null)
                    {
                        RepositorioCategorias.Update(vm);
                        return RedirectToAction("Index");
                    }
                    else if (ResultNombre.Id == vm.Id)
                    {
                        ResultNombre.Nombre = vm.Nombre;
                        RepositorioCategorias.Update(ResultNombre);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Ya existe una categoria con el mismo nombre.");
                        if (RepositorioCategorias.GetCategoriaByNombre(vm.Nombre).Estatus == false)
                        {
                            ViewBag.Recuperacion = true;
                            ViewBag.IdEncRec = RepositorioCategorias.GetCategoriaByNombre(vm.Nombre).Id;
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

        //Administrador ---- Eliminar una categoria POST-------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult EliminarCategoria(int id)
        {
            //ViewBag.Admin = 1;
            CategoriasRepository repos = new CategoriasRepository();
            EncuestasRepository ER = new EncuestasRepository();
            var v = repos.GetById(id);
            if (v != null)
            {
                if (ER.Context.Encuesta.Where(x => x.IdCategoria == id).Count() == 0)
                {
                    repos.BajaLogica(id);
                }
                else
                {
                    ViewBag.Eliminar = 1;

                }
                //ViewBag.Mensaje = "La categoria ha sido eliminada exitosamente.";
            }
            //else
            //{
            //    ViewBag.Mensaje = "La categoria no existe o ya ha sido eliminada.";
            //}
            return RedirectToAction("Index");
        }

        //Administrador ------ Recuperar una categoria POST--------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult RecuperarCategoria(int id)
        {
            CategoriasRepository repos = new CategoriasRepository();
            repos.Recuperacion(id);
            return RedirectToAction("Index");
        }
    }
}