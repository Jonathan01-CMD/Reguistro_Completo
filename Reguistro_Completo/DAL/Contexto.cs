using Microsoft.EntityFrameworkCore;
using Reguistro_Completo.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reguistro_Completo.DAL
{
    public class Contexto :DbContext
    {
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permiso> Permiso { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = ReguistroCompleto.DB");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Permiso>().HasData(
                new Permiso()
                {
                    Nombre = "Papita",
                    Descripcion = "Producto en venta",
                    PermisoID = 1,
                    DetallePermiso = "Descuento"
                },
                new Permiso()
                {
                    Nombre = "Juan",
                    Descripcion = "Vendedor en puesto",
                    PermisoID = 2,
                    DetallePermiso = "Venta"
                },
                new Permiso()
                {
                    Nombre = "Paola",
                    Descripcion = "Cobradora en turno",
                    PermisoID = 3,
                    DetallePermiso = "Cobrar"
                });
        }
    }

}
