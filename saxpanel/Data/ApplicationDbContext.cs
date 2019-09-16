using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using saxpanel.Models;

namespace saxpanel.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SaxCompose> SaxComposes {get;set;}
        public DbSet<SaxService> SaxServices {get;set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<SaxCompose>().ToTable("SaxCompose");
            builder.Entity<SaxService>().ToTable("SaxTable");
        }
    }
}
