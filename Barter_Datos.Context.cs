﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Barter
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Barter_OficialEntities : DbContext
    {
        public Barter_OficialEntities()
            : base("name=Barter_OficialEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Carrito> Carrito { get; set; }
        public virtual DbSet<Local> Local { get; set; }
        public virtual DbSet<Local_Producto> Local_Producto { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Producto_Usuario> Producto_Usuario { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Usuario_Local> Usuario_Local { get; set; }
    }
}
