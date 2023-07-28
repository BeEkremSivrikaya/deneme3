using EntityLayer.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Context:DbContext
    {

        public Context(DbContextOptions <Context> options):base(options)
        { }

        public DbSet<Giderler> Giderler { get; set; }

        public DbSet<Kur> Kurs{ get; set; }
        public DbSet <Odemeler> Odemelers { get; set; }
        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Ogrenci_detay> Ogrenci_detays { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Sınavlar> Sınavlars { get; set; }
        public DbSet<Veli> Velis { get; set; }
        public DbSet<YasGrubu> YasGrubus { get; set; }

}
}
