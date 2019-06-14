using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RailDelay.Models;

namespace RailDelay.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Delay> Delay { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
            modelBuilder.Entity<Delay>().ToTable("Delay");
            modelBuilder.Seed();
        }

        public DbSet<RailDelay.Models.Traveler> Traveler { get; set; }

    }
}
