using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WarhammerAPI.Model.DAL.Entities;

namespace WarhammerAPI.Model.DAL.EF
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Unit> Unit { get; set; }
        public DbSet<Models> Models { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SpecialAbilities> SpecialAbilities { get; set; }
        public DbSet<UnitNumber> UnitNumber { get; set; }
        public DbSet<UnitType> UnitType { get; set; }
        public DbSet<WarlordTrait> WarlordTrait { get; set; }
        public DbSet<Degradation> Degradation { get; set; }
        public DbSet<FractionKeywords> FractionKeywords { get; set; }
        public DbSet<Keywords> Keywords { get; set; }
        public DbSet<WargearOptions> WargearOptions { get; set; }
        public DbSet<WargearSetUp> WargearSetUp { get; set; }
        public DbSet<WeaponSet> WeaponSet { get; set; }
        public DbSet<Weapon> Weapon { get; set; }
        public DbSet<AbilitiesWeapon> AbilitiesWeapon { get; set; }
        public DbSet<Abilities> Abilities { get; set; }




        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Warhammer40k;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<HQ>()
            //    .HasMany(m => m.Activities)
            //    .WithOne(a => a.Milestone)
            //    .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Models>()
                .HasOne(m => m.Unit)
                .WithMany(n => n.Models);
            modelBuilder.Entity<SpecialAbilities>()
                .HasOne(m => m.Role)
                .WithMany(a => a.SpecialAbilities);
            modelBuilder.Entity<Role>()
                .HasOne(m => m.Unit)
                .WithOne(a => a.Role)
                .HasForeignKey<Role>(b=>b.Id);
            modelBuilder.Entity<UnitNumber>()
                .HasOne(m => m.Unit)
                .WithOne(a => a.UnitNumber)
                .HasForeignKey<UnitNumber>(x=>x.Id);
            modelBuilder.Entity<UnitType>()
                .HasOne(m => m.Unit)
                .WithOne(a => a.UnitType)
                .HasForeignKey<UnitType>(x => x.Id);
            modelBuilder.Entity<Degradation>()
                .HasOne(m => m.Unit)
                .WithMany(a => a.Degradation);
            modelBuilder.Entity<FractionKeywords>()
                .HasOne(m => m.Unit)
                .WithMany(a => a.FractionKeywords);
            modelBuilder.Entity<Keywords>()
                .HasOne(m => m.Unit)
                .WithMany(a => a.Keywords);
            modelBuilder.Entity<Abilities>()
                .HasOne(m => m.Unit)
                .WithMany(a => a.Abilities);
            //weapon
            modelBuilder.Entity<AbilitiesWeapon>()
                .HasOne(m => m.Weapon)
                .WithMany(a => a.AbilitiesWeapon);
            modelBuilder.Entity<Weapon>()
                .HasOne(m => m.WeaponSet)
                .WithMany(a => a.Weapon);
            //Wargear
            modelBuilder.Entity<WeaponSet>()
                .HasOne(m => m.WargearSetUp)
                .WithMany(a => a.WeaponSet);
            modelBuilder.Entity<WargearSetUp>()
                .HasOne(m => m.WargearOption)
                .WithMany(a => a.WargearSet);
            modelBuilder.Entity<WargearOptions>()
                .HasOne(m => m.Unit)
                .WithMany(a => a.WargearOptions);

        }
    }
}
