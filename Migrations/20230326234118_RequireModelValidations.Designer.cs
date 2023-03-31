﻿// <auto-generated />
using BusinessApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessApi.Migrations
{
    [DbContext(typeof(BusinessApiContext))]
    [Migration("20230326234118_RequireModelValidations")]
    partial class RequireModelValidations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BusinessApi.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("BusinessId");

                    b.ToTable("Businesss");

                    b.HasData(
                        new
                        {
                            BusinessId = 1,
                            Age = 7,
                            Name = "Matilda",
                            Species = "Wooly Mammoth"
                        },
                        new
                        {
                            BusinessId = 2,
                            Age = 10,
                            Name = "Rexi",
                            Species = "Dinosaur"
                        },
                        new
                        {
                            BusinessId = 3,
                            Age = 2,
                            Name = "Matilda",
                            Species = "Dinosaur"
                        },
                        new
                        {
                            BusinessId = 4,
                            Age = 4,
                            Name = "Pip",
                            Species = "Shark"
                        },
                        new
                        {
                            BusinessId = 5,
                            Age = 22,
                            Name = "Bartholomew",
                            Species = "Dinosaur"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
