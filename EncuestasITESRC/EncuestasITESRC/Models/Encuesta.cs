using System;
using System.Collections.Generic;

namespace EncuestasITESRC.Models
{
    public partial class Encuesta
    {
        public Encuesta()
        {
            Encuestado = new HashSet<Encuestado>();
            Pregunta = new HashSet<Pregunta>();
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public int IdCategoria { get; set; }
        public int IdAdministrador { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estatus { get; set; }

        public Administrador IdAdministradorNavigation { get; set; }
        public Categoria IdCategoriaNavigation { get; set; }
        public ICollection<Encuestado> Encuestado { get; set; }
        public ICollection<Pregunta> Pregunta { get; set; }
    }
}
