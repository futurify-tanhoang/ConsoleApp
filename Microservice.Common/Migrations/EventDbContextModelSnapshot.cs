﻿// <auto-generated />
using System;
using Microservice.Common.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Microservice.Common.Migrations
{
    [DbContext(typeof(EventDbContext))]
    partial class EventDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microservice.Common.Models.EventTracker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<Guid>("MessageId");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.Property<string>("PayLoad");

                    b.Property<string>("Subscriber");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("EventTracker");
                });

            modelBuilder.Entity("Microservice.Common.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("GuidId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Microservice.Common.Models.RawRabbitEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("Name");

                    b.Property<string>("Subscriber");

                    b.HasKey("Id");

                    b.ToTable("RawRabbitEvent");
                });

            modelBuilder.Entity("Microservice.Common.Models.UnsubscribeEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<Guid>("MessageId");

                    b.Property<string>("Name");

                    b.Property<string>("Real");

                    b.Property<string>("Register");

                    b.HasKey("Id");

                    b.ToTable("UnsubscribeEvent");
                });
#pragma warning restore 612, 618
        }
    }
}
