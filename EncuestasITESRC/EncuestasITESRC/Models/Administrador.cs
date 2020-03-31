using System;
using System.Collections.Generic;

namespace EncuestasITESRC.Models
{
    public partial class Administrador
    {
        public Administrador()
        {
            Encuesta = new HashSet<Encuesta>();
        }

        public int Id { get; set; }
        public string NoControl { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        public ICollection<Encuesta> Encuesta { get; set; }
    }
}
