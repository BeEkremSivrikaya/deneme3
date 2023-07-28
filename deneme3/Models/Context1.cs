
using EntitiyLayer.Tables;
using EntityLayer.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace deneme3.Models
{
    public class Context1:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Database=minikodAkademidb;Port=5432;User Id=postgres;Password=admin ");
            
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<KurOgrenci>().HasOne(b => b.Ogrenci).WithMany(ba => ba.KurOgrencis).HasForeignKey(b1 => b1.Ogrenci_Id);
            modelBuilder.Entity<KurOgrenci>().HasOne(b => b.Kur).WithMany(ba => ba.KurOgrencis).HasForeignKey(b1 => b1.Kur_Id);

        }

        

        public DbSet<Devamsızlık> devamsızlıks { get; set; }
        public DbSet<IndırımOranları> ındırımOranlarıs { get; set; }
        public DbSet<KurOgrenci> KurOgrencis { get; set; }
        public DbSet<Borc> borcs { get; set; }




        public DbSet<Giderler> giderler { get; set; }
        public DbSet<Kur> kurs { get; set; }
        public DbSet<Odemeler> odemelers { get; set; }
        public DbSet<Ogrenci> ogrencis { get; set; }
        public DbSet<Ogrenci_detay> ogrenci_detays { get; set; }
        public DbSet<Personel> personels { get; set; }
        public DbSet<Sınavlar> sınavlars { get; set; }
        public DbSet<Veli> velis { get; set; }
        public DbSet<YasGrubu> yasGrubus { get; set; }
        public DbSet<Il> Ils { get; set; }
        public DbSet<Ilce> Ilces { get; set; }
        public DbSet<Fatura> fatura { get; set; }
        public DbSet<Sube> subes { get; set; }
        public DbSet<FaturaOdemeler> faturaOdemelers { get; set; }
        public DbSet<Banka> bankas{ get; set; }
        public DbSet<GiderTurleri> giderturleris{ get; set; }
        public DbSet<SınavTurleri> sınavkodus{ get; set; }
        public DbSet<OdemeTurleri> OdemeTurleris{ get; set; }

        public DbSet<Admin> Admins { get; set; }


    }
}
