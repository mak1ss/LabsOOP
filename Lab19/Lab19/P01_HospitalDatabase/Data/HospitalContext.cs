using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab19.P01_HospitalDatabase.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Lab19.P01_HospitalDatabase.Data
{
    public class HospitalContext : DbContext
    {

        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Diagnose> Diagnose => Set<Diagnose>();
        public DbSet<Visitation> visitations => Set<Visitation>();
        public DbSet<Medicament> medicaments => Set<Medicament>();
        public DbSet<PatientMedicament> patientMedicaments => Set<PatientMedicament>();
        public DbSet<Doctor> Doctors => Set<Doctor>();
        
        public HospitalContext()
        {
            /*
            Database.EnsureCreated();*/
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=hospitalDatabase;Trusted_Connection=True;Encrypt=false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasAlternateKey(p => p.Email);
            modelBuilder
                .Entity<Patient>()
                .HasMany(p => p.medicaments)
                .WithMany(m => m.patients)
                .UsingEntity<PatientMedicament>(
                    j => j
                    .HasOne(pm => pm.medicament)
                    .WithMany(m => m.Prescriptions)
                    .HasForeignKey(pm => pm.MedicamentId),

                        j => j
                    .HasOne(pm => pm.patient)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(pm => pm.PatientId), 
                    j =>
                    {
                        j.HasKey(pm => new { pm.MedicamentId, pm.PatientId});
                        j.ToTable("PatientMedicaments");
                    }
                );               
        }
    }
}
