using System;
using System.Collections.Generic;

namespace EncuestasITESRC.Models
{
    public partial class Pregunta
    {
        public Pregunta()
        {
            Opcionrespuesta = new HashSet<Opcionrespuesta>();
            Respuestaabierta = new HashSet<Respuestaabierta>();
            Respuestacerrada = new HashSet<Respuestacerrada>();
        }

        public int Id { get; set; }
        public string Contenido { get; set; }
        public int IdTipoRespuesta { get; set; }
        public int IdEncuesta { get; set; }

        public Encuesta IdEncuestaNavigation { get; set; }
        public Tiporespuesta IdTipoRespuestaNavigation { get; set; }
        public ICollection<Opcionrespuesta> Opcionrespuesta { get; set; }
        public ICollection<Respuestaabierta> Respuestaabierta { get; set; }
        public ICollection<Respuestacerrada> Respuestacerrada { get; set; }
    }
}
