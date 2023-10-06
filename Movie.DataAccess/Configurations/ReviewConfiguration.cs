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

        builder.HasOne(r => r.User).WithOne().HasForeignKey<Review>(r => r.FilmId).IsRequired().OnDelete(DeleteBehavior.Cascade);
    }
}