﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EFSoftBreak.Models.Entities;

namespace EFSoftBreak.Models.Context
{
    class MyContext : DbContext
    {

        public MyContext() : base("MyConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasOptional(x => x.AppUserProfile).WithRequired(x => x.AppUser);

            modelBuilder.Entity<OrderDetail>().Ignore(x => x.ID);
            modelBuilder.Entity<OrderDetail>().HasKey(x => new
            {
                x.OrderID,
                x.ProductID
            });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> AppUserProfiles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
