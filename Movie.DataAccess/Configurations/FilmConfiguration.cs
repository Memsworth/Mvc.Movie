﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Domain.Models;

namespace Movie.DataAccess.Configurations;

public class FilmConfiguration : IEntityTypeConfiguration<Film>
{
    public void Configure(EntityTypeBuilder<Film> builder)
    {
        builder.HasKey(f => f.Id); 
        builder.Property(f => f.Title).IsRequired();
        builder.Property(f => f.ImageUrl).IsRequired();
        builder.Property(f => f.ReleaseDate).IsRequired();
        builder.Property(f => f.Genre).IsRequired();

        builder.HasMany(f => f.Reviews).WithOne(r => r.Film).HasForeignKey(r => r.FilmId).OnDelete(DeleteBehavior.Cascade);
    }
}