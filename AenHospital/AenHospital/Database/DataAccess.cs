using AenHospital.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AenHospital.Database
{
    public class DataAccess : DbContext
    {
        private readonly IEfDbContext _efDbContext;
        public DataAccess()
        {
            _efDbContext = new EfDbContext
            {
                server_name = "localhost",
                server_dbname = "Demo",
                server_user = "sa",
                server_pass = "123456"
            };
        }

        public DbSet<T_Log> T_Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_efDbContext.Connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<T_Log>().HasNoKey();
        }
    }
}
