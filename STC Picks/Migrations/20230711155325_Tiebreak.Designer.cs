﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using STC_Picks.Data;

#nullable disable

namespace STC_Picks.Migrations
{
    [DbContext(typeof(STCDbContext))]
    [Migration("20230711155325_Tiebreak")]
    partial class Tiebreak
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("STC_Picks.Models.User", b =>
                {
                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("accessCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("female1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("female2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("female3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("female4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("female5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("female6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("female7")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("female8")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("male1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("male2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("male3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("male4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("male5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("male6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("male7")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("male8")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("score")
                        .HasColumnType("int");

                    b.HasKey("fullName");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
