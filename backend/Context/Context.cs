﻿namespace backend.Context
{
    using backend.Models;
    using Microsoft.EntityFrameworkCore;

    public class SQLDbContext : DbContext
    {
        DbSet<User> User { get; set; }
        DbSet<Project> Project { get; set; }

        public SQLDbContext(DbContextOptions<SQLDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<User>().ToTable("User");
            
            modelBuilder.Entity<Project>().ToTable("Project");
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
