
using Fina.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fina.Api.Data.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(c => c.Title)
                .HasColumnType("NVARCHAR")
                .HasMaxLength(255);

            builder.Property(c => c.UserId)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(160);
        }
    }
}