using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace EncuestasITESRC.Areas.Administrador.Models
{
    public class DAEncuestasViewModel
    {
        public int Id { get; set; }
        
        [Required]
        [MinLength(5)]
        [StringLength(45, ErrorMessage = "El campo excede el limite de caracteres, 45")]
        public string Titulo { get; set; }

        [StringLength(250, ErrorMessage = "El campo excede el limite de caracteres, 250")]
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public int IdCategoria { get; set; }
        public bool Estatus { get; set; }
        public int IdAdministrador { get; set; }
        public bool Visualizar { get; set; }
        public DateTime FechaCreacion { get; set; }


    }
}