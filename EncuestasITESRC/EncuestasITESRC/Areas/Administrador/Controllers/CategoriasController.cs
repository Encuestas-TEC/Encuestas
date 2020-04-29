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
        [Route("Administrador/Categorias")]
        public IActionResult Index()
        {
            CategoriasRepository repos = new CategoriasRepository();
            return View(repos.GetCategoriasActivas());
        }
        //Administrador ---- Agregar una categorias---------------------------------------------------------------------------------
        [Route("Administrador/AgregarCategoria")]
        public IActionResult AgregarCategoria()
        {
            //ViewBag.Admin = 1;
            return View();
        }

        [HttpPost]
        public IActionResult AgregarCategoria(DACategoriasViewModel categoria)
        {
            //ViewBag.Admin = 1;
            //try
            //{
            CategoriasRepository repos = new CategoriasRepository();
            Regex regex = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ0-9 ]{5,}$");
            bool resultado = regex.IsMatch(categoria.Nombre);
            int x = categoria.Nombre.Length;
            if (x < 5)
            {
                ModelState.AddModelError("", "El nombre es demasiado corto.");
                return View(categoria);
            }
            if (repos.GetCategoriaByNombre(categoria.Nombre) != null)
                {
                    ModelState.AddModelError("", "Ya existe una categoria con este nombre");
                    if (repos.GetCategoriaByNombre(categoria.Nombre).Estatus == false)
                    {
                        ViewBag.Recuperacion = true;
                        ViewBag.IdEncRec = repos.GetCategoriaByNombre(categoria.Nombre).Id;
                    }
                    return View(categoria);
            }
            if (!resultado)
            {
                ModelState.AddModelError("", "El nombre de la categoria no puede contener caracteres especiales.");
                return View(categoria);
            }
            Regex reg = new Regex(@"[0-9]| $");
            string exp = categoria.Nombre.Substring(0, 1);
            bool res = reg.IsMatch(exp);
            if (res)
            {
                ModelState.AddModelError("", "El nombre de la categoria no puede iniciar con un numero.");
                return View(categoria);
            }
            repos.Insert(categoria);
            return RedirectToAction("Index");
            //}
            //catch (Exception ex)
            //{
            //    ModelState.AddModelError("", ex.Message);
            //    return View(categoria);
            //}
        }

        //Administrador ---- Editar una categoria----------------------------------------------------------------------------------
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

        [HttpPost]
        public IActionResult EditarCategoria(DACategoriasViewModel vm)
        {
            //ViewBag.Admin = 1;

            if (ModelState.IsValid)
            {
                //try
                //{
                CategoriasRepository repos = new CategoriasRepository();
                Regex regex = new Regex(@"^[a-zA-Z0-9áéíóúÁÉÍÓÚñÑ ]{5,}$");
                bool resultado = regex.IsMatch(vm.Nombre);
                int x = vm.Nombre.Length;
                if (x < 5)
                {
                    ModelState.AddModelError("", "El nombre es demasiado corto.");
                    return View(vm);
                }
                if (repos.GetCategoriaByNombre(vm.Nombre).Id != vm.Id) //Permite editar con el mismo nombre siempre y cuando sea el id original
                {
                    ModelState.AddModelError("", "Ya existe una categoria con este nombre");
                    if (repos.GetCategoriaByNombre(vm.Nombre).Estatus == false)
                    {
                        ViewBag.Recuperacion = true;
                        ViewBag.IdEncRec = repos.GetCategoriaByNombre(vm.Nombre).Id;
                    }
                    return View(vm);
                }

                if (!resultado)
                {
                    ModelState.AddModelError("", "El nombre de la categoria no puede contener caracteres especiales.");
                    return View(vm);
                }
                Regex reg = new Regex(@"[0-9]| $");
                string exp = vm.Nombre.Substring(0, 1);
                bool res = reg.IsMatch(exp);
                if (res)
                {
                    ModelState.AddModelError("", "El nombre de la categoria no puede iniciar con un numero.");
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
        //Administrador ---- Eliminar una categoria---------------------------------------------------------------------------------
       
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

        //Administrador ------ Recuperar categoria ---------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult RecuperarCategoria(int id)
        {
            CategoriasRepository repos = new CategoriasRepository();
            repos.Recuperacion(id);
            return RedirectToAction("Index");
        }
    }
}