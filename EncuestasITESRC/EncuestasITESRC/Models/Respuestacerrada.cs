using System;
using System.Collections.Generic;

namespace EncuestasITESRC.Models
{
    public partial class Respuestacerrada
    {
        public int Id { get; set; }
        public int IdOpcionRespuesta { get; set; }
        public int IdEncuestado { get; set; }
        public int IdPregunta { get; set; }

        public Encuestado IdEncuestadoNavigation { get; set; }
        public Opcionrespuesta IdOpcionRespuestaNavigation { get; set; }
        public Pregunta IdPreguntaNavigation { get; set; }
    }
}
