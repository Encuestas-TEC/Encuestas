using EncuestasITESRC.Areas.Administrador.Models;
using EncuestasITESRC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncuestasITESRC.Repositories
{
    public class PreguntasRepository : Repository<Pregunta>
    {
        public Pregunta GetPreguntaByContenido(string contenido)
        {
            return Context.Pregunta.FirstOrDefault(x => x.Contenido == contenido);
        }
        public DAPreguntasViewModel GetPreguntaById(int id)
        {
            return Context.Pregunta.Where(x => x.Id == id)
                .Select(x => new DAPreguntasViewModel
                {
                    Id = x.Id,
                    Contenido = x.Contenido,
                    IdEncuesta = x.IdEncuesta,
                    IdTipoRespuesta = x.IdTipoRespuesta
                }).FirstOrDefault();
        }
        public IEnumerable<Pregunta> GetPreguntasByEncuesta(Encuesta encuesta)
        {
            return Context.Pregunta.Where(x => x.Id == encuesta.Id)
                .Select(x => new Pregunta
                {
                    Id = x.Id,
                    Contenido = x.Contenido,
                    IdEncuesta = x.IdEncuesta,
                    IdTipoRespuesta = x.IdTipoRespuesta,
                    IdEncuestaNavigation = x.IdEncuestaNavigation,
                    IdTipoRespuestaNavigation = x.IdTipoRespuestaNavigation
                }).OrderBy(x => x.Contenido);
        }
        public void Insert(DAPreguntasViewModel vm)
        {
            Pregunta pregunta = new Pregunta
            {
                Id = vm.Id,
                Contenido = vm.Contenido,
                IdTipoRespuesta = vm.IdTipoRespuesta,
                IdEncuesta = vm.IdEncuesta
            };
            Insert(pregunta);
            vm.Id = pregunta.Id;
        }
        public void Update(DAPreguntasViewModel vm)
        {
            var pregunta = GetById(vm.Id);
            if (pregunta != null)
            {
                pregunta.Id = vm.Id;
                pregunta.Contenido = vm.Contenido;
                pregunta.IdEncuesta = vm.IdEncuesta;
                pregunta.IdTipoRespuesta = vm.IdTipoRespuesta;
                Update(pregunta);
            }
        }
    }
}
