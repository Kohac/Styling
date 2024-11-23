using Example.Styling.Domain.Entities;
using Example.Styling.Infrastructure.Data.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Example.Styling.Infrastructure.Data;

public class CustomerMapping : IEntityTypeConfiguration<CustomerDbo>
{
    public void Configure(EntityTypeBuilder<CustomerDbo> builder)
    {
        builder.SetDefaultEntity();

        builder.Property(x => x.FirstName)
            .HasColumnName("FIRST_NAME");

        builder.Property(x => x.LastName)
            .HasColumnName("LAST_NAME");

        builder.Property(x => x.Email)
            .HasColumnName("EMAIL");

        builder.Property(x => x.Phone)
            .HasColumnName("PHONE");

        builder.HasMany(x => x.Addresses)
            .WithOne(x => x.Customer)
            .HasForeignKey(x => x.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}
