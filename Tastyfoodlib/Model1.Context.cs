﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tastyfoodlib
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TastyFoodsEntities : DbContext
    {
        public TastyFoodsEntities()
            : base("name=TastyFoodsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FoodDetail> FoodDetails { get; set; }
        public virtual DbSet<FoodList> FoodLists { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<LoginMember> LoginMembers { get; set; }
        public virtual DbSet<PersonalInfo> PersonalInfoes { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
    }
}
