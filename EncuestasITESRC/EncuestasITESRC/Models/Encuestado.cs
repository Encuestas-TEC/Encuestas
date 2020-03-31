using System;
using System.Collections.Generic;

namespace EncuestasITESRC.Models
{
    public partial class Encuestado
    {
        public Encuestado()
        {
            Respuestaabierta = new HashSet<Respuestaabierta>();
            Respuestacerrada = new HashSet<Respuestacerrada>();
        }

        public int Id { get; set; }
        public int IdEncuesta { get; set; }
        public int AlumnoId { get; set; }
        public DateTime FechaRespuesta { get; set; }

        public Alumno Alumno { get; set; }
        public Encuesta IdEncuestaNavigation { get; set; }
        public ICollection<Respuestaabierta> Respuestaabierta { get; set; }
        public ICollection<Respuestacerrada> Respuestacerrada { get; set; }
    }
}
