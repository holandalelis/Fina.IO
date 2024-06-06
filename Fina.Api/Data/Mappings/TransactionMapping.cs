using Fina.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fina.Api.Data.Mappings
{
    public class TransactionMapping : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

            builder.HasKey(x => x.Id);

            builder.Property(t => t.Amount)
                .IsRequired()
                .HasColumnType("MONEY");

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnType("SMALLINT");

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(160);

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.PaidOrReceivedAt);

            builder.Property(x => x.UserId)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(160);
        }
    }
}