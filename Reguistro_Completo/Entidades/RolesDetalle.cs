using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Reguistro_Completo.Entidades
{
    public class RolesDetalle
    {
        [Key]

        public int Id { get; set; }
        public int RolID { get; set; }
        public int PermisoId { get; set; }
        public bool esAsignado { get; set; }

        public RolesDetalle()
        {
            Id = 0;
            RolID = 0;
            PermisoId = 0;
            esAsignado = false;
        }
        public RolesDetalle(int id, int rolId, int permisoId, bool EsAsignado)
        {
            Id = id;
            RolID = rolId;
            PermisoId = permisoId;
            esAsignado = EsAsignado;
        }
    }
}
