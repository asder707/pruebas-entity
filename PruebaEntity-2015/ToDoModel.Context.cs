﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaEntity_2015
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TO_DO_LISTEntities : DbContext
    {
        public TO_DO_LISTEntities()
            : base("name=TO_DO_LISTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BOARD> BOARD { get; set; }
        public DbSet<REL_TICKET_HAS_STATUS> REL_TICKET_HAS_STATUS { get; set; }
        public DbSet<STATUS> STATUS { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<TICKET> TICKET { get; set; }
        public DbSet<USER> USER { get; set; }
    }
}
