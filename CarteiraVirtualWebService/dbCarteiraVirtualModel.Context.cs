﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarteiraVirtualWebService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CarteiraEntities : DbContext
    {
        public CarteiraEntities()
            : base("name=CarteiraEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Carteira> Carteira { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Configuracoes> Configuracoes { get; set; }
        public virtual DbSet<DashBoard> DashBoard { get; set; }
        public virtual DbSet<Movimento> Movimento { get; set; }
        public virtual DbSet<Parceiro> Parceiro { get; set; }
        public virtual DbSet<ParceiroFilial> ParceiroFilial { get; set; }
        public virtual DbSet<Senha> Senha { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Permissoes> Permissoes { get; set; }
    }
}
