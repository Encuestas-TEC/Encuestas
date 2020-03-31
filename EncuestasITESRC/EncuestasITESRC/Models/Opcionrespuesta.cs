using System;
using System.Collections.Generic;

namespace EncuestasITESRC.Models
{
    public partial class Opcionrespuesta
    {
        public Opcionrespuesta()
        {
            Respuestacerrada = new HashSet<Respuestacerrada>();
        }

        public int Id { get; set; }
        public string Respuesta { get; set; }
        public int IdPregunta { get; set; }

        public Pregunta IdPreguntaNavigation { get; set; }
        public ICollection<Respuestacerrada> Respuestacerrada { get; set; }
    }
}
