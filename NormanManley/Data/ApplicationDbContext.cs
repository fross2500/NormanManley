using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NormanManley.Data;
using NormanManley.Models;

namespace NormanManley.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        
        public DbSet<Students> Students { get; set; } 
        public DbSet<Genders> Gender { get; set; }
        public DbSet<Grades> Grades { get; set; }
        public DbSet<Disabilities> Disabilities { get; set; }
        public DbSet<NormanManley.Models.StudentVM> StudentVM { get; set; }
       


    }
}
