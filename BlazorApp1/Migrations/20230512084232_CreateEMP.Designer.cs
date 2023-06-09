﻿// <auto-generated />
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp1.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230512084232_CreateEMP")]
    partial class CreateEMP
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorApp1.Data.ModelData.TableEmployee", b =>
                {
                    b.Property<int>("cust_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cust_id"));

                    b.Property<string>("cust_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cust_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cust_fax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cust_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cust_phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cust_postcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cust_id");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
