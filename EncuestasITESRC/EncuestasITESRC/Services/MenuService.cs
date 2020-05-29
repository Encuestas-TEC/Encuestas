using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncuestasITESRC.Repositories;
using EncuestasITESRC.Models;

namespace EncuestasITESRC.Services
{
    public class MenuService
    {
        public IEnumerable<Categoria> GetNombreCategoria()
        {
            CategoriasRepository repos = new CategoriasRepository();
            var list = repos.GetCategoriasActivas();
            return list;
        }
        public IEnumerable<Tiporespuesta> GetTiposRespuesta()
        {
            TipoRespuestaRepository repos = new TipoRespuestaRepository();
            var list = repos.GetTiposRespuesta();
            return list;
        }
    }
}
