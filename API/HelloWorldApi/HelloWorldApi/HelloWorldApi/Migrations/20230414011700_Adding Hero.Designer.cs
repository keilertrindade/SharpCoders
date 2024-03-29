﻿// <auto-generated />
using System;
using HelloWorldApi.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HelloWorldApi.Migrations
{
    [DbContext(typeof(HeroContext))]
    [Migration("20230414011700_Adding Hero")]
    partial class AddingHero
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HelloWorldApi.Model.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Power")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RealName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("isRetired")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Heroes");
                });
#pragma warning restore 612, 618
        }
    }
}
