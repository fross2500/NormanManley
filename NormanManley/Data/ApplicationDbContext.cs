using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NormanManley.Data.Migrations;

namespace NormanManley.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        internal readonly object Grades;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Parent> Parent { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Disabilities> Disabilities { get; set; }
    }
}
