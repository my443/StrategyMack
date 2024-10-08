﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StrategyMack.Data;

#nullable disable

namespace StrategyMack.Migrations
{
    [DbContext(typeof(StrategyMackContext))]
    partial class StrategyMackContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StrategyMack.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAcive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUser");
                });

            modelBuilder.Entity("StrategyMack.Models.AttributeDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InitiativeAttributeId")
                        .HasColumnType("int");

                    b.Property<int>("InitiativeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("InitiativeAttributeId");

                    b.ToTable("AttributeDetail");
                });

            modelBuilder.Entity("StrategyMack.Models.AttributeDetailMultiple", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AprilValue")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("AugustValue")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DecemberValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("FebruaryValue")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("FiscalYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InitiativeAttributeId")
                        .HasColumnType("int");

                    b.Property<int>("InitiativeId")
                        .HasColumnType("int");

                    b.Property<decimal>("JanuaryValue")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("JulyValue")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("JuneValue")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("MarchValue")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("MayValue")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("NovemberValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OctoberValue")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("SeptemberValue")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("AttributeDetailMultiple");
                });

            modelBuilder.Entity("StrategyMack.Models.Initiative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Initiative");
                });

            modelBuilder.Entity("StrategyMack.Models.InitiativeAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AttributeDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasMultipleDetails")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InitiativeAttribute");
                });

            modelBuilder.Entity("StrategyMack.Models.AttributeDetail", b =>
                {
                    b.HasOne("StrategyMack.Models.InitiativeAttribute", null)
                        .WithMany("AttributeDetails")
                        .HasForeignKey("InitiativeAttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StrategyMack.Models.InitiativeAttribute", b =>
                {
                    b.Navigation("AttributeDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
