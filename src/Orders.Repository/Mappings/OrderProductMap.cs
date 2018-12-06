using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orders.Domain.Models;

namespace Orders.Repository.Mappings
{
    public sealed class OrderProductMap : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.ToTable("OrdersProducts");

            builder.HasKey(x => new { x.OrderId, x.ProductId });

            builder
                .Property(x => x.OrderId)
                .IsRequired();

            builder
                .HasOne(x => x.Order)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.OrderId);

            builder
                .Property(x => x.ProductId)
                .IsRequired();
        }
    }
}
