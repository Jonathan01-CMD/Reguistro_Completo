﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Reguistro_Completo.Entidades
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        public string Clave { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
        public string RolID { get; set; }
        public string Alias { get; set; }
        public bool Activo { get; set; }

        [ForeignKey("UsuarioID")]
        public virtual Roles Rol { get; set; }
    
    }
}
