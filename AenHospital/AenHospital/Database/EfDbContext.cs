using AenHospital.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AenHospital.Database
{
    public class EfDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public EfDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public EfDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Server = (localdb)\Local; Database=Demo; Trusted_Connection = true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserMast>().HasNoKey();
            modelBuilder.Entity<HospitalMast>().HasNoKey();
        }

        public virtual DbSet<UserMast> T_UserMasts { get; set; }
        public virtual DbSet<HospitalMast> T_HospitalMasts { get; set; }


    }
}
