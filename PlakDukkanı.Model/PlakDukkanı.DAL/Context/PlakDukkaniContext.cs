using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlakDukkanı.Model.Models;

namespace PlakDukkanı.DAL.Context
{
    public class PlakDukkaniContext: DbContext
    {
        public PlakDukkaniContext()
        {
            
        }

        public PlakDukkaniContext(DbContextOptions<PlakDukkaniContext> options) : base(options) 
        {
            
        }
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist_Group> Artist_Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=.\;Database=PlakDukkaniDB;Trusted_Connection=True;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>(entity =>
            {
               
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.UserName).IsRequired().HasMaxLength(25);
            });
            modelBuilder.Entity<Album>(entity =>
            {

                entity.Property(e => e.Price).IsRequired().HasColumnType("money");
                entity.Property(e => e.Name).IsRequired().HasMaxLength(25);
            });
            modelBuilder.Entity<Artist_Group>(entity =>
            {

                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
