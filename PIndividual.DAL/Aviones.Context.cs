﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PIndividual.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AeropuertoEntities : DbContext
    {
        public AeropuertoEntities()
            : base("name=AeropuertoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aviones> Aviones { get; set; }
        public virtual DbSet<Paises_Destino_Aeropuerto> Paises_Destino_Aeropuerto { get; set; }
        public virtual DbSet<Pasajeros> Pasajeros { get; set; }
        public virtual DbSet<Vuelos> Vuelos { get; set; }
    }
}
