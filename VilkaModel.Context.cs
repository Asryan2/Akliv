﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vilka
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VilkaEntities : DbContext
    {
        public VilkaEntities()
            : base("name=VilkaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BetOffer> BetOffers { get; set; }
        public virtual DbSet<BetTarget> BetTargets { get; set; }
        public virtual DbSet<BetType> BetTypes { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Outcome> Outcomes { get; set; }
        public virtual DbSet<OutcomeType> OutcomeTypes { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Sport> Sports { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
    }
}