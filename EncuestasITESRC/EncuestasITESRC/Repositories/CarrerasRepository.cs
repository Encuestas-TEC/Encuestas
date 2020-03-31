using EncuestasITESRC.Areas.Administrador.Models;
using EncuestasITESRC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncuestasITESRC.Repositories
{
    public class CarrerasRepository : Repository<Carrera>
    {
        public IEnumerable<Carrera> GetCarreras()
        {
            return GetAll().OrderBy(x => x.Nombre);
        }
        public DACarrerasViewModel GetCarreraById(int Id)
        {
            return Context.Carrera.Where(x => x.Id == Id)
                .Select(x => new DACarrerasViewModel
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Descripcion = x.Descripcion
                }).FirstOrDefault();
        }
        public void Insert(DACarrerasViewModel vm)
        {
            Carrera carrera = new Carrera
            {
                Id = vm.Id,
                Nombre = vm.Nombre,
                Descripcion = vm.Descripcion
            };
            Insert(carrera);
            vm.Id = carrera.Id;
        }
        public void Update(DACarrerasViewModel vm)
        {
            var a = Context.Carrera.FirstOrDefault(x => x.Id == vm.Id);
            if (a != null)
            {
                a.Id = vm.Id;
                a.Nombre = vm.Nombre;
                a.Descripcion = vm.Descripcion;
                Update(a);
            }
        } 

        //Ya no poner nombres raros POR FAVOR
        public Carrera GetCarreraByNombre(string nombre)
        {
            return Context.Carrera.FirstOrDefault(x => x.Nombre.ToUpper() == nombre.ToUpper());
        }
    }
}
