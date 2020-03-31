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
                    Clave = x.Clave
                }).FirstOrDefault();
        }
        public void Insert(DACarrerasViewModel vm)
        {
            Carrera carrera = new Carrera
            {
                Id = vm.Id,
                Nombre = vm.Nombre,
                Clave = vm.Clave
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
                a.Clave = vm.Clave;
                Update(a);
            }
        } 
        public Carrera GetCarreraByNombre(string nombre)
        {
            return Context.Carrera.FirstOrDefault(x => x.Nombre.ToUpper() == nombre.ToUpper());
        }
        public void BajaLogica(int id)
        {
            var tem = Context.Carrera.FirstOrDefault(x => x.Id == id);
            tem.Estatus = false;
            Update(tem);
        }
        public void Recuperacion(int id)
        {
            var tem = Context.Carrera.FirstOrDefault(x => x.Id == id);
            tem.Estatus = true;
            Update(tem);
        }
    }
}
