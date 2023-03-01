using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class BasvuruContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=6543;Database=Kayit_Db;User Id=postgres;Password=19891989!!as;");


        }
        public DbSet<AbonelikTuru> AbonelikTurus { get; set; }
        public DbSet<Il> Ils { get; set; }
        public DbSet<Ilce> Ilces { get; set; }
        public DbSet<Cadde> Caddes { get; set; }
        public DbSet<Mahalle> Mahalles { get; set; }
        public DbSet<KisiselBilgiler> KisiselBilgilers { get; set; }
        public DbSet<MeslekKodlari> MeslekKodlaris { get; set; }
        public DbSet<Numaralar> Numaralars { get; set; }
    }
}
