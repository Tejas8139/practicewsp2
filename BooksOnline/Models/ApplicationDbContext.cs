using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BooksOnline.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
            
        }
          public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
          {
            
            }
    //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //       if(!optionsBuilder.IsConfigured)
    //       {
    //         optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;          
                //Database=ApplicatinDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
    //      }
    //    }
       public DbSet<Category>Categories{get;set;}

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
        modelBuilder.Entity<Category>().HasData(
            new Category{Id=1, Name ="Action", DisplayOrder =2},
            new Category{Id=2, Name ="SiFi", DisplayOrder =20},
            new Category{Id=3, Name ="History", DisplayOrder =12}
        );
       }
    }
}