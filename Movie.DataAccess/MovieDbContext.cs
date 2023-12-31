﻿using Microsoft.EntityFrameworkCore;
using Movie.DataAccess.Configurations;
using Movie.Domain.Models;

namespace Movie.DataAccess;

public class MovieDbContext : DbContext
{
    public MovieDbContext(DbContextOptions options) : base (options)
    { }

    public DbSet<User> Users { get; set; }
    public DbSet<Film> Films { get; set; }
    public DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new FilmConfiguration());
        modelBuilder.ApplyConfiguration(new ReviewConfiguration());

    }
}