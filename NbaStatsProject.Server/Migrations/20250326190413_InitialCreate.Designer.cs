﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NbaStatsProject.Server.Data;

#nullable disable

namespace NbaStatsProject.Server.Migrations
{
    [DbContext(typeof(NbaStatsDbContext))]
    [Migration("20250326190413_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NbaStatsProject.Server.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AssistsPerGame")
                        .HasColumnType("float");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PointsPerGame")
                        .HasColumnType("float");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ReboundsPerGame")
                        .HasColumnType("float");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssistsPerGame = 6.7999999999999998,
                            FullName = "LeBron James",
                            PointsPerGame = 25.300000000000001,
                            Position = "SF",
                            ReboundsPerGame = 7.4000000000000004,
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            AssistsPerGame = 4.4000000000000004,
                            FullName = "Jayson Tatum",
                            PointsPerGame = 27.800000000000001,
                            Position = "SF",
                            ReboundsPerGame = 8.1999999999999993,
                            TeamId = 2
                        });
                });

            modelBuilder.Entity("NbaStatsProject.Server.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Conference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Conference = "West",
                            Name = "Lakers"
                        },
                        new
                        {
                            Id = 2,
                            Conference = "East",
                            Name = "Celtics"
                        });
                });

            modelBuilder.Entity("NbaStatsProject.Server.Models.Player", b =>
                {
                    b.HasOne("NbaStatsProject.Server.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("NbaStatsProject.Server.Models.Team", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
