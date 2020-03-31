using System;
using System.Collections.Generic;

namespace EncuestasITESRC.Models
{
    public partial class Carrera
    {
        public Carrera()
        {
            Alumno = new HashSet<Alumno>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public bool? Estatus { get; set; }

        public ICollection<Alumno> Alumno { get; set; }
    }
}
