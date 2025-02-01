using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteOtomasyonu.Entities;

namespace UniversiteOtomasyonu.Context
{
    internal class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=202-3\\SQLDERS;Database=UniversiteDB;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ders>()
            .HasOne(a => a.Sinif)
            .WithOne(b => b.Ders)
            .HasForeignKey<Sinif>(b => b.DersId);
        }


        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<OgretimGorevlisi> OgretimGorevlisis { get; set; }
        public DbSet<Fakulte> Fakultes { get; set; }
        public DbSet<Bolum> Bolums { get; set; }
        public DbSet<Ders> Derss { get; set; }
        public DbSet<Sinif> Sinif { get; set; }
        public DbSet<Notlar> Notlars { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
    }
}
