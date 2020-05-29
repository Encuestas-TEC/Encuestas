using EncuestasITESRC.Areas.Administrador.Models;
using EncuestasITESRC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncuestasITESRC.Repositories
{
    public class TipoRespuestaRepository : Repository<Tiporespuesta>
    {
        public IEnumerable<Tiporespuesta> GetTiposRespuesta()
        {
            return GetAll().OrderBy(x => x.Tipo);
        }
    }
}
