﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DPHCSEntities : DbContext
    {
        public DPHCSEntities()
            : base("name=DPHCSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<DoctorSpecializationList> DoctorSpecializationList { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Hospital> Hospital { get; set; }
        public virtual DbSet<LabTestOrder> LabTestOrder { get; set; }
        public virtual DbSet<LabTestResult> LabTestResult { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientAllergie> PatientAllergie { get; set; }
        public virtual DbSet<PatientHealthRecord> PatientHealthRecord { get; set; }
        public virtual DbSet<PatientPrescription> PatientPrescription { get; set; }
        public virtual DbSet<PatientVital> PatientVital { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TestBloodGroup> TestBloodGroup { get; set; }
        public virtual DbSet<UserAccount> UserAccount { get; set; }
        public virtual DbSet<UserConnection> UserConnection { get; set; }
    }
}