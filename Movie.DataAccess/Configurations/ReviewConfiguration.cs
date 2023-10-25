using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Domain.Models;

namespace Movie.DataAccess.Configurations;

public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.HasKey(review => review.Id);
        builder.Property(review => review.ReviewText).IsRequired();
        builder.Property(review => review.Rating).IsRequired();

        builder.HasIndex(review => new { review.UserId, review.FilmId }).IsUnique();

        builder.HasOne(r => r.User).WithMany(u => u.Reviews).HasForeignKey(r => r.UserId);
        builder.HasOne(r => r.Film).WithMany(f => f.Reviews).HasForeignKey(r => r.FilmId);
    }
}