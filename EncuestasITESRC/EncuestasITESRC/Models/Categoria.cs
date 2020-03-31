using System;
using System.Collections.Generic;

namespace EncuestasITESRC.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Encuesta = new HashSet<Encuesta>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estatus { get; set; }

        public ICollection<Encuesta> Encuesta { get; set; }
    }
}
