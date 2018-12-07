using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Orders.Domain.Models;
using Orders.Repository.Mappings;
using System;
using System.Collections.Generic;

namespace Orders.Repository
{
    public sealed class OrdersDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public OrdersDbContext(IConfiguration configuration) => this.configuration = configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("OrdersDb"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new OrderProductMap());

            var order = Order.CreateNew(new Guid("354d06be-9c1d-4b8b-a7d7-79f10c5beebb"), new List<Guid>());

            modelBuilder.Entity<Order>().HasData(order);

            modelBuilder.Entity<OrderProduct>().HasData(
                OrderProduct.Create(order.Id, new Guid("7E9729B8-9704-4A0B-AE39-036CACAE09F6")),
                OrderProduct.Create(order.Id, new Guid("3E5FF496-E40D-4A59-BAF9-30081918F445")),
                OrderProduct.Create(order.Id, new Guid("11253E54-ED71-466C-9E7A-430FC14A17B9"))
            );
        }
    }
}
