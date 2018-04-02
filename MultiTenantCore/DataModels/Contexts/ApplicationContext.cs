﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MultiTenantCore.DataModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenantCore.DataModels.Contexts
{
    public class ApplicationContext : DbContext
    { 
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            System.Console.WriteLine($"DbContextOptions= ApplicationContext ApplicationContext ==============================>: ");
        }
        public ApplicationContext()
        {
            System.Console.WriteLine($"DbContextOptions= ApplicationContext ApplicationContext ==============================>: Empty ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            System.Console.WriteLine($"DbContextOptions= ModelBuilder ApplicationContext ==============================>: ");
            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            System.Console.WriteLine($"DbContextOptions= DbContextOptionsBuilder ApplicationContext ==============================>: ");
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Employee> Employees { get; set; }

        public DbSet<LeaveRequest> LeaveRequests { get; set; }
    }
}
