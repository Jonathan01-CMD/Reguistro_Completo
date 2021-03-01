using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Reguistro_Completo.Entidades
{
    public class Roles
    {
        [Key]
        public int RolID { get; set; }
        public string Descripcion { get; set; }
        public bool esActivo { get; set; }
        public DateTime FechaCreacion { get; set; }

        [ForeignKey("RolID")]

        public virtual List<RolesDetalle> Detalles { get; set; }

        public Roles()
        {
            RolID = 0;
            Descripcion = string.Empty;
            esActivo = false;
             Detalles = new List<RolesDetalle>();
        }


    }
}
