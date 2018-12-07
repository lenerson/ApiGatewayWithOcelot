using Catalog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Repository.Mappings
{
    public sealed class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
