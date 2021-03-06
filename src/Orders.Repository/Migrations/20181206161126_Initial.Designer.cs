﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Orders.Repository;

namespace Orders.Repository.Migrations
{
    [DbContext(typeof(OrdersDbContext))]
    [Migration("20181206161126_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Orders.Domain.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4bf0580e-a079-4aaa-a659-10b0bcb3773f")
                        });
                });

            modelBuilder.Entity("Orders.Domain.Models.OrderProduct", b =>
                {
                    b.Property<Guid>("OrderId");

                    b.Property<Guid>("ProductId");

                    b.HasKey("OrderId", "ProductId");

                    b.ToTable("OrdersProducts");

                    b.HasData(
                        new
                        {
                            OrderId = new Guid("4bf0580e-a079-4aaa-a659-10b0bcb3773f"),
                            ProductId = new Guid("7e9729b8-9704-4a0b-ae39-036cacae09f6")
                        },
                        new
                        {
                            OrderId = new Guid("4bf0580e-a079-4aaa-a659-10b0bcb3773f"),
                            ProductId = new Guid("3e5ff496-e40d-4a59-baf9-30081918f445")
                        },
                        new
                        {
                            OrderId = new Guid("4bf0580e-a079-4aaa-a659-10b0bcb3773f"),
                            ProductId = new Guid("11253e54-ed71-466c-9e7a-430fc14a17b9")
                        });
                });

            modelBuilder.Entity("Orders.Domain.Models.OrderProduct", b =>
                {
                    b.HasOne("Orders.Domain.Models.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
