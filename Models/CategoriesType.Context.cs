﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewDemoProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EmployeeDBEntities : DbContext
    {
        public EmployeeDBEntities()
            : base("name=EmployeeDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<INCIDENT_BUSINESS_FUNCTION_LOOKUP> INCIDENT_BUSINESS_FUNCTION_LOOKUP { get; set; }
        public virtual DbSet<INCIDENT_CATEGORY_LOOKUP> INCIDENT_CATEGORY_LOOKUP { get; set; }
        public virtual DbSet<INCIDENT_SERVICE_LOOKUP> INCIDENT_SERVICE_LOOKUP { get; set; }
    }
}
