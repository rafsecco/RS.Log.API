﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RS.Log.API.Data;

namespace RS.Log.API.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211023105148_Tenant")]
    partial class Tenant
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("RS.Log.API.Domain.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Message")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("StackTrace")
                        .HasColumnType("longtext");

                    b.Property<string>("TenantId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.HasIndex("DateCreated", "TenantId")
                        .HasDatabaseName("idx_tenantid");

                    b.ToTable("Logs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2021, 10, 23, 7, 51, 47, 750, DateTimeKind.Local).AddTicks(1211),
                            Message = "teste 1",
                            TenantId = "tenant-1"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2021, 10, 23, 7, 51, 47, 751, DateTimeKind.Local).AddTicks(1584),
                            Message = "teste 2",
                            TenantId = "tenant-2"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2021, 10, 23, 7, 51, 47, 751, DateTimeKind.Local).AddTicks(1602),
                            Message = "teste 3",
                            TenantId = "tenant-2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}