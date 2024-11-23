using Example.Styling.Domain.Entities.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Example.Styling.Infrastructure.Data.Abstraction;

public static class EntityMapping
{
    public static EntityTypeBuilder<TEntity> SetDefaultEntity<TEntity>(this EntityTypeBuilder<TEntity> builder) where TEntity : Entity
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .IsRequired()
            .HasColumnName("ID");

        builder.Property(x => x.Created)
            .IsRequired()
            .HasColumnName("CREATED");

        builder.Property(x => x.Updated)
            .HasColumnName("UPDATED");

        builder.Property(x => x.Deleted).
            HasColumnName("DELETED");

        return builder;
    }
}
