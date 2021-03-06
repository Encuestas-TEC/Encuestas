﻿using EncuestasITESRC.Areas.Administrador.Models;
using EncuestasITESRC.Models;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EncuestasITESRC.Repositories
{
    public class EncuestasRepository : Repository<Encuesta>
    {
        public IEnumerable<Encuesta> GetEncuestas()
        {
            return Context.Encuesta.Select(x => new Encuesta
            {
                Id = x.Id,
                Titulo = x.Titulo,
                Descripcion = x.Descripcion,
                Estado = x.Estado,
                Estatus = x.Estatus,
                FechaCreacion = x.FechaCreacion,
                Encuestado = x.Encuestado,
                Pregunta = x.Pregunta,
                IdAdministrador = x.IdAdministrador,
                IdCategoria = x.IdCategoria,
                IdAdministradorNavigation = x.IdAdministradorNavigation,
                IdCategoriaNavigation = x.IdCategoriaNavigation
            }).Include(x => x.IdCategoriaNavigation).OrderBy(x => x.Titulo);

            //return GetAll().OrderBy(x => x.Titulo);
        }

        public IEnumerable<Encuesta> GetEncuestasActivas()
        {
            return Context.Encuesta.Select(x => new Encuesta 
            { 
                Id = x.Id,
                Titulo = x.Titulo,
                Descripcion = x.Descripcion,
                Estado = x.Estado, 
                Estatus = x.Estatus, 
                FechaCreacion = x.FechaCreacion,
                Encuestado = x.Encuestado, 
                Pregunta = x.Pregunta, 
                IdAdministradorNavigation = x.IdAdministradorNavigation,
                IdCategoriaNavigation = x.IdCategoriaNavigation
            }).Include(x => x.IdCategoriaNavigation).Where(x => x.Estatus == true).OrderBy(x => x.Titulo);

            //return GetAll().Where(x => x.Estatus == true).OrderBy(x => x.Titulo);
        }

        public DAEncuestasViewModel GetEncuestasById(int Id)
        {
            return Context.Encuesta.Where(x => x.Id == Id)
                .Select(x => new DAEncuestasViewModel
                {
                    Id = x.Id,
                    Titulo = x.Titulo,
                    Descripcion = x.Descripcion,
                    Estado = x.Estado,
                    IdCategoria = x.IdCategoria,
                    IdAdministrador = x.IdAdministrador,
                    FechaCreacion = x.FechaCreacion,
                    Estatus = x.Estatus
                }).FirstOrDefault();
        }

        public void Insert(DAEncuestasViewModel vm)
        {
            Encuesta encuesta = new Encuesta
            {
                Id = vm.Id,
                Titulo = vm.Titulo,
                Descripcion = vm.Descripcion,
                Estado = vm.Estado,
                IdCategoria = vm.IdCategoria,
                IdAdministrador = vm.IdAdministrador,
                FechaCreacion = vm.FechaCreacion,
                Estatus = true
            };
            Insert(encuesta);
            vm.Id = encuesta.Id;

        }

        public void Update(DAEncuestasViewModel vm)
        {
            var c = Context.Encuesta.FirstOrDefault(x => x.Id == vm.Id);
            if (c != null)
            {
                c.Id = vm.Id;
                c.Titulo = vm.Titulo;
                c.Descripcion = vm.Descripcion;
                c.Estado = vm.Estado;
                c.IdCategoria = vm.IdCategoria;
                c.IdAdministrador = vm.IdAdministrador;
                c.FechaCreacion = vm.FechaCreacion;
                Update(c);
            } 
        }

        public Encuesta GetEncuestasByTitulo(string nombre)
        {
            return Context.Encuesta.FirstOrDefault(x => x.Titulo.ToUpper() == nombre.ToUpper());
        }

        public void BajaLogica(int id)
        {
            var tem = Context.Encuesta.FirstOrDefault(x => x.Id == id);
            tem.Estatus = false;
            Update(tem);
        }

        public void Recuperacion(int id)
        {
            var tem = Context.Encuesta.FirstOrDefault(x => x.Id == id);
            tem.Estatus = true;
            Update(tem);
        }
    }
}
