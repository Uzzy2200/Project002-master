﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project002.Repository.Models;

#nullable disable

namespace Project002.Repository.Migrations
{
    [DbContext(typeof(Dbcontext))]
    [Migration("20240422075242_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClanWar", b =>
                {
                    b.Property<int>("ClansClanId")
                        .HasColumnType("int");

                    b.Property<int>("WarsWarId")
                        .HasColumnType("int");

                    b.HasKey("ClansClanId", "WarsWarId");

                    b.HasIndex("WarsWarId");

                    b.ToTable("ClanWar");
                });

            modelBuilder.Entity("Project002.Repository.Models.Armour", b =>
                {
                    b.Property<int>("ArmourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArmourId"), 1L, 1);

                    b.Property<string>("ArmourDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArmourName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArmourId");

                    b.ToTable("Armour");
                });

            modelBuilder.Entity("Project002.Repository.Models.Clan", b =>
                {
                    b.Property<int>("ClanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClanId"), 1L, 1);

                    b.Property<string>("ClanName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClanId");

                    b.ToTable("Clan");
                });

            modelBuilder.Entity("Project002.Repository.Models.Clothing", b =>
                {
                    b.Property<int>("ClothingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClothingId"), 1L, 1);

                    b.Property<string>("ClothingDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClothingName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClothingId");

                    b.ToTable("Clothing");
                });

            modelBuilder.Entity("Project002.Repository.Models.Horse", b =>
                {
                    b.Property<int>("HorseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HorseId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HorseId");

                    b.ToTable("Horse");
                });

            modelBuilder.Entity("Project002.Repository.Models.Rank", b =>
                {
                    b.Property<int>("RankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RankId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RankId");

                    b.ToTable("Rank");
                });

            modelBuilder.Entity("Project002.Repository.Models.Samurai", b =>
                {
                    b.Property<int>("SamuraiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SamuraiId"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("ArmourId")
                        .HasColumnType("int");

                    b.Property<int>("ClanId")
                        .HasColumnType("int");

                    b.Property<int>("ClothingId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SamuraiName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransportId")
                        .HasColumnType("int");

                    b.Property<int>("WarId")
                        .HasColumnType("int");

                    b.HasKey("SamuraiId");

                    b.ToTable("Samurai");
                });

            modelBuilder.Entity("Project002.Repository.Models.TimePeriod", b =>
                {
                    b.Property<int>("TimePeriodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TimePeriodId"), 1L, 1);

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TimePeriodId");

                    b.ToTable("TimePeriod");
                });

            modelBuilder.Entity("Project002.Repository.Models.War", b =>
                {
                    b.Property<int>("WarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WarId"), 1L, 1);

                    b.Property<int>("DeathCount")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WarId");

                    b.ToTable("War");
                });

            modelBuilder.Entity("Project002.Repository.Models.Weapon", b =>
                {
                    b.Property<int>("WeaponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WeaponId"), 1L, 1);

                    b.Property<string>("WeaponName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WeaponId");

                    b.ToTable("Weapon");
                });

            modelBuilder.Entity("ClanWar", b =>
                {
                    b.HasOne("Project002.Repository.Models.Clan", null)
                        .WithMany()
                        .HasForeignKey("ClansClanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project002.Repository.Models.War", null)
                        .WithMany()
                        .HasForeignKey("WarsWarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
