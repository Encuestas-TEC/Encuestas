﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EncuestasITESRC.Areas.Administrador.Models
{
    public class DACategoriasViewModel
    {
        public int Id { get; set; }
        
        [Required]
        //[MinLength(5, ErrorMessage = "El nombre es demasiado corto.")]
        [StringLength(45, ErrorMessage = "El campo excede el limite de caracteres, 45")]
        public string Nombre { get; set; }
        [StringLength(100, ErrorMessage = "El campo excede el limite de caracteres, 100")]
        public string Descripcion { get; set; }
    }
}
