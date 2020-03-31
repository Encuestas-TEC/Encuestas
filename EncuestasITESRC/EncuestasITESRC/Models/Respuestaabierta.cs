using System;
using System.Collections.Generic;

namespace EncuestasITESRC.Models
{
    public partial class Respuestaabierta
    {
        public int Id { get; set; }
        public string Respuesta { get; set; }
        public int IdEncuestado { get; set; }
        public int IdPregunta { get; set; }

        public Encuestado IdEncuestadoNavigation { get; set; }
        public Pregunta IdPreguntaNavigation { get; set; }
    }
}
