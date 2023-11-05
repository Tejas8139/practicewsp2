using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp1.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Category>Categoriess{get;set;}

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Category>().HasData(
        //         new Category {Id=1,Name="Action",DisplayOrder=3},
        //         new Category {Id=2,Name="SciFi",DisplayOrder=2},
        //         new Category {Id=3,Name="Romantic",DisplayOrder=21},
        //         new Category {Id=4,Name="History",DisplayOrder=90}

        // );
        // }
    }
}