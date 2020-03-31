using EncuestasITESRC.Models;
using EncuestasITESRC.Areas.Administrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncuestasITESRC.Repositories
{
    public class CategoriasRepository : Repository<Categoria>
    {
        public IEnumerable<Categoria> GetCategorias()
        {
            return GetAll().OrderBy(x => x.Nombre);
        }

        public Categoria GetCategoriaByNombre(string nombre)
        {
            return Context.Categoria.FirstOrDefault(x => x.Nombre.ToUpper() == nombre.ToUpper());
        }


        public DACategoriasViewModel GetCategoriaById(int Id)
        {
            return Context.Categoria.Where(x => x.Id == Id)
                .Select(x => new DACategoriasViewModel
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Descripcion = x.Descripcion
                }).FirstOrDefault();
        }

        public void Insert(DACategoriasViewModel vm)
        {
            Categoria categoria = new Categoria
            {
                Id = vm.Id,
                Nombre = vm.Nombre,
                Descripcion = vm.Descripcion
            };
            Insert(categoria);
            vm.Id = categoria.Id;
        }
        public void Update(DACategoriasViewModel vm)
        {
            var a = Context.Categoria.FirstOrDefault(x => x.Id == vm.Id);
            if (a != null)
            {
                a.Id = vm.Id;
                a.Nombre = vm.Nombre;
                a.Descripcion = vm.Descripcion;
                Update(a);
            }
        }
        public void BajaLogica(int id)
        {
            var tem = Context.Categoria.FirstOrDefault(x => x.Id == id);
            tem.Estatus = false;
            Update(tem);
        }

        public void Recuperacion(int id)
        {
            var tem = Context.Categoria.FirstOrDefault(x => x.Id == id);
            tem.Estatus = true;
            Update(tem);
        }
    }
}
