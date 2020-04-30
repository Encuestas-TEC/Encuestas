using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EncuestasITESRC.Areas.Administrador.Models
{
    public class DACarrerasViewModel
    {
        public int Id { get; set; }
        
        [Required]
        //[MinLength(5, ErrorMessage = "El nombre es demasiado corto.")]
        [StringLength(45, ErrorMessage = "El campo excede el limite de caracteres, 45")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La clave de la carrera es un campo requerido, por lo que no puede estar vacío.")]
        [StringLength(2, ErrorMessage = "El campo excede el limite de caracteres, 2")]
        public string Clave { get; set; }
    }
}
