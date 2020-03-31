using System;
using System.Collections.Generic;

namespace EncuestasITESRC.Models
{
    public partial class Alumno
    {
        public Alumno()
        {
            Encuestado = new HashSet<Encuestado>();
        }

        public int Id { get; set; }
        public string NoControl { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public int CarreraId { get; set; }

        public Carrera Carrera { get; set; }
        public ICollection<Encuestado> Encuestado { get; set; }
    }
}
