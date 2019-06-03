﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RailDelay.Data;

namespace RailDelay.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190603194511_SeedDelayDB")]
    partial class SeedDelayDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RailDelay.Models.Delay", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActualArrivalTime");

                    b.Property<DateTime>("ActualDepartureTime");

                    b.Property<string>("ActualTrain1Number")
                        .HasMaxLength(4);

                    b.Property<string>("ActualTrain2Number")
                        .HasMaxLength(4);

                    b.Property<string>("DepartureTrainStationID");

                    b.Property<string>("DestinationTrainStationID");

                    b.Property<DateTime>("LastDateOfUse");

                    b.Property<DateTime>("PlannedArrivalTime");

                    b.Property<DateTime>("PlannedDepartureTime");

                    b.Property<string>("PlannedTrain1Number")
                        .HasMaxLength(4);

                    b.Property<string>("PlannedTrain2Number")
                        .HasMaxLength(4);

                    b.Property<int>("TicketID");

                    b.Property<string>("TicketNumber")
                        .HasMaxLength(13);

                    b.Property<string>("TransferTrainStationID");

                    b.Property<DateTime>("TravelDate");

                    b.HasKey("ID");

                    b.HasIndex("TicketID");

                    b.ToTable("Delay");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ActualArrivalTime = new DateTime(2019, 4, 1, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            ActualDepartureTime = new DateTime(2019, 4, 1, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            ActualTrain1Number = "6543",
                            ActualTrain2Number = "",
                            DepartureTrainStationID = "",
                            DestinationTrainStationID = "",
                            LastDateOfUse = new DateTime(2019, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PlannedArrivalTime = new DateTime(2019, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            PlannedDepartureTime = new DateTime(2019, 4, 1, 8, 15, 0, 0, DateTimeKind.Unspecified),
                            PlannedTrain1Number = "1234",
                            PlannedTrain2Number = "",
                            TicketID = 1,
                            TicketNumber = "",
                            TransferTrainStationID = "",
                            TravelDate = new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 2,
                            ActualArrivalTime = new DateTime(2019, 5, 1, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            ActualDepartureTime = new DateTime(2019, 5, 1, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            ActualTrain1Number = "6543",
                            ActualTrain2Number = "",
                            DepartureTrainStationID = "",
                            DestinationTrainStationID = "",
                            LastDateOfUse = new DateTime(2019, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PlannedArrivalTime = new DateTime(2019, 5, 1, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            PlannedDepartureTime = new DateTime(2019, 5, 1, 8, 15, 0, 0, DateTimeKind.Unspecified),
                            PlannedTrain1Number = "1234",
                            PlannedTrain2Number = "",
                            TicketID = 1,
                            TicketNumber = "",
                            TransferTrainStationID = "",
                            TravelDate = new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("RailDelay.Models.Ticket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TicketName");

                    b.HasKey("ID");

                    b.ToTable("Ticket");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            TicketName = "Biljet"
                        },
                        new
                        {
                            ID = 2,
                            TicketName = "Treinkaart"
                        },
                        new
                        {
                            ID = 3,
                            TicketName = "Campus"
                        },
                        new
                        {
                            ID = 4,
                            TicketName = "Halftijdse Treinkaart"
                        },
                        new
                        {
                            ID = 5,
                            TicketName = "Pass"
                        },
                        new
                        {
                            ID = 6,
                            TicketName = "Kaart"
                        },
                        new
                        {
                            ID = 7,
                            TicketName = "MOBIB Kaart"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RailDelay.Models.Delay", b =>
                {
                    b.HasOne("RailDelay.Models.Ticket", "Ticket")
                        .WithMany()
                        .HasForeignKey("TicketID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
