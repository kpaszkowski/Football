﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Football
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbEntities1 : DbContext
    {
        public dbEntities1()
            : base("name=baseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Club> Club { get; set; }
        public virtual DbSet<Match> Match { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Record> Record { get; set; }
        public virtual DbSet<Referee> Referee { get; set; }
        public virtual DbSet<Stadium> Stadium { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<Timetable> Timetable { get; set; }
        public virtual DbSet<TrainingStaff> TrainingStaff { get; set; }
        public virtual DbSet<Winners> Winners { get; set; }
    }
}
