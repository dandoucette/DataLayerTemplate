using DataLayerTemplate.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerTemplate
{
    public class MyDatabaseContext : DbContext
    {
        // map your entities here, this is how your context will know about them
        // to create your database do the following commands 
        // Add-Migration migrationName 
        // Update-Database
        public DbSet<ExampleEntity> Examples { get; set; }

        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // You can change the schema like this:
            //modelBuilder.HasDefaultSchema("MySchema");

            // Set required fields like so
            //modelBuilder.Entity<ExampleEntity>(entity =>
            //{
            //    entity.Property(e => e.FirstName)
            //        .IsRequired();

            //    entity.Property(e => e.StartDate)
            //        .IsRequired();
            //});

            // if you need to add a key (should only be used if mapping to a view)
            //modelBuilder.Entity<ExampleEntity>().HasKey(entity => new { entity.FirstName, entity.StartDate });

            base.OnModelCreating(modelBuilder);
        }
    }
}
