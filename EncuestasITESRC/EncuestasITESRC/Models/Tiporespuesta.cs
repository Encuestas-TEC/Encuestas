using System;
using System.Collections.Generic;

namespace EncuestasITESRC.Models
{
    public partial class Tiporespuesta
    {
        public Tiporespuesta()
        {
            Pregunta = new HashSet<Pregunta>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Pregunta> Pregunta { get; set; }
    }
}
