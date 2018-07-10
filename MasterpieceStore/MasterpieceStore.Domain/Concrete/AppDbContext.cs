﻿using MasterpieceStore.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterpieceStore.Domain.Concrete
{
   public class AppDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Product> Products { get; set; }
        public AppDbContext() : base("AppDbContext") { }

        static AppDbContext()
        {
            Database.SetInitializer<AppDbContext>(new IdentityDbInit());
        }
        public static AppDbContext Create()
        {
            return new AppDbContext();
        }
    }

    public class IdentityDbInit : DropCreateDatabaseAlways<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            PerformInitialSetup(context);
            base.Seed(context);
        }
        public void PerformInitialSetup(AppDbContext context)
        {
            // initial configuration will go here
        }
    }

}
