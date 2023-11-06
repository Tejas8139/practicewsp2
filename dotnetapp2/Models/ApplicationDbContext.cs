using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp2.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }

        public DbSet<Category1>Categories2{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category1>().HasData(
                new Category1 {Id=1,Name="Action",DisplayOrder=3},
                new Category1 {Id=2,Name="SciFi",DisplayOrder=2},
                new Category1 {Id=3,Name="Romantic",DisplayOrder=21},
                new Category1 {Id=4,Name="History",DisplayOrder=90}

        );
        }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=ApplicationDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
        }
    }
    }
}