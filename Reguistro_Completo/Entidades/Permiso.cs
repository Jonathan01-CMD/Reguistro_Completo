using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Reguistro_Completo.Entidades
{
    public class Permiso
    {
        public int PermisoID { get; set; }
        public string Nombre { get; set; }
        public string DetallePermiso { get; set; }
        public string Descripcion { get; set; }
        public bool VecesAsignado { get; set; }

        [ForeignKey("PermisosID")]
        public virtual Permiso permisos { set; get; }
    }
}
