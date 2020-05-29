using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EncuestasITESRC.Areas.Administrador.Models
{
    public class DAPreguntasViewModel
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public int IdTipoRespuesta { get; set; }
        public int IdEncuesta { get; set; }
    }
}
