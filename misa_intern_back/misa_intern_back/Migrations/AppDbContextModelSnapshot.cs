﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using misa_intern_back.Data;

#nullable disable

namespace misa_intern_back.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("misa_intern_back.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("bacnkCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("bankBranch")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("bankName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("birthday")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("department")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("issued_By")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("landline")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("mobilePhone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("personalNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("position")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
