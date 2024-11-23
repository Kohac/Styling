using Example.Styling.Domain.Entities;
using Example.Styling.Infrastructure.Data.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Example.Styling.Infrastructure.Data;

public class AddressMapping : IEntityTypeConfiguration<AddressDbo>
{
    public void Configure(EntityTypeBuilder<AddressDbo> builder)
    {
        builder.SetDefaultEntity();

        builder.Property(x => x.CustomerId)
            .IsRequired()
            .HasColumnName("CITY");

        builder.Property(x => x.Deleted)
            .HasColumnName("CITY");

        builder.Property(x => x.Deleted)
            .HasColumnName("COUNTRY");

        builder.Property(x => x.Deleted)
            .HasColumnName("ORIENTATION_NUMBER");

        builder.Property(x => x.Deleted)
            .HasColumnName("POSTAL_CODE");

        builder.HasOne(x => x.Customer)
            .WithMany(x => x.Addresses)
            .HasForeignKey(x => x.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
