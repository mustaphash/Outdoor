﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(OutdoorContext))]
    [Migration("20220427180156_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AnimalLake", b =>
                {
                    b.Property<int>("AnimalsId")
                        .HasColumnType("int");

                    b.Property<int>("LakesId")
                        .HasColumnType("int");

                    b.HasKey("AnimalsId", "LakesId");

                    b.HasIndex("LakesId");

                    b.ToTable("AnimalLake");
                });

            modelBuilder.Entity("AnimalNatureReserve", b =>
                {
                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<int>("NatureReservesId")
                        .HasColumnType("int");

                    b.HasKey("AnimalId", "NatureReservesId");

                    b.HasIndex("NatureReservesId");

                    b.ToTable("AnimalNatureReserve");
                });

            modelBuilder.Entity("AnimalPark", b =>
                {
                    b.Property<int>("AnimalsId")
                        .HasColumnType("int");

                    b.Property<int>("ParksId")
                        .HasColumnType("int");

                    b.HasKey("AnimalsId", "ParksId");

                    b.HasIndex("ParksId");

                    b.ToTable("AnimalPark");
                });

            modelBuilder.Entity("Core.Entities.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Animals", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The bear is the largest carnivore in Bulgaria and can be found in the Rhodope Mountains, Rila Mountains, Pirin Mountains, and Stara Planina",
                            Name = "Brown Bear"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Wolves live in parts of Stara Planina (Balkan Mountains), Strandzha Mountains, the Rhodopes, and around the city of Ruse.",
                            Name = "Wolf"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The fox can be encountered in many places in Bulgaria, usually in forest areas",
                            Name = "Fox"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Wild rabbits are still widespread around Bulgaria, mainly in the flat and low areas.",
                            Name = "Wild Rabbit"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Boars are known to be aggressive when they are with their cubs so stay out of the forest in the Spring. Wild Boar are hunted in Bulgaria and in some areas their population is stimulated in order to offer better hunting conditions.",
                            Name = "Wild Boar"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Storks have a special role in the local folklore. They are believed to be the birds bringing spring with them. Storks spend the winter in Africa and come back to their nests in Bulgaria every year at the end of March.",
                            Name = "Stork"
                        },
                        new
                        {
                            Id = 7,
                            Description = "The cuckoo has a special role in spring. Old people say that when you here the cuckoo song for the first time in spring, you should check your wallet. If it’s full of money, you’ll have a prosperous year. If it’s not, it is going to be bad for you.",
                            Name = "Cuckoo"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Hedgehogs can be seen in the wild as well as in cities and villages. Some people in the villages even leave food for the hedgehogs to make sure they are around because they are famous for eating snakes.",
                            Name = "Hedgehog"
                        },
                        new
                        {
                            Id = 9,
                            Description = "",
                            Name = "Pig"
                        },
                        new
                        {
                            Id = 10,
                            Description = "",
                            Name = "Horse"
                        },
                        new
                        {
                            Id = 11,
                            Description = "",
                            Name = "Goat"
                        },
                        new
                        {
                            Id = 12,
                            Description = "",
                            Name = "Cow"
                        },
                        new
                        {
                            Id = 13,
                            Description = "",
                            Name = "Snake"
                        },
                        new
                        {
                            Id = 14,
                            Description = "",
                            Name = "Bison"
                        },
                        new
                        {
                            Id = 15,
                            Description = "",
                            Name = "Deer"
                        },
                        new
                        {
                            Id = 16,
                            Description = "",
                            Name = "Sheep"
                        },
                        new
                        {
                            Id = 17,
                            Description = "",
                            Name = "Pike"
                        },
                        new
                        {
                            Id = 18,
                            Description = "",
                            Name = "Carp"
                        },
                        new
                        {
                            Id = 19,
                            Description = "",
                            Name = "Trout"
                        },
                        new
                        {
                            Id = 20,
                            Description = "",
                            Name = "Salmon"
                        },
                        new
                        {
                            Id = 21,
                            Description = "",
                            Name = "Perch"
                        },
                        new
                        {
                            Id = 22,
                            Description = "",
                            Name = "Bonito"
                        },
                        new
                        {
                            Id = 23,
                            Description = "",
                            Name = "Popche"
                        },
                        new
                        {
                            Id = 24,
                            Description = "",
                            Name = "Catfish"
                        },
                        new
                        {
                            Id = 25,
                            Description = "",
                            Name = "Redeye"
                        },
                        new
                        {
                            Id = 26,
                            Description = "",
                            Name = "Woodpecker"
                        },
                        new
                        {
                            Id = 27,
                            Description = "",
                            Name = "Collared Dove"
                        },
                        new
                        {
                            Id = 28,
                            Description = "",
                            Name = "Swallow"
                        },
                        new
                        {
                            Id = 29,
                            Description = "",
                            Name = "Sparrow"
                        },
                        new
                        {
                            Id = 30,
                            Description = "",
                            Name = "Owl"
                        });
                });

            modelBuilder.Entity("Core.Entities.Extras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Extras", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Wi-Fi"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Camping"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "FishingAllowed"
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            Name = "Elrctricity"
                        },
                        new
                        {
                            Id = 5,
                            Description = "",
                            Name = "OpenForTourist"
                        },
                        new
                        {
                            Id = 6,
                            Description = "",
                            Name = "WalkingPaths"
                        });
                });

            modelBuilder.Entity("Core.Entities.Outdoor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Description");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("Image");

                    b.Property<double>("Latitude")
                        .HasColumnType("float")
                        .HasColumnName("Latitude");

                    b.Property<double>("Longitude")
                        .HasColumnType("float")
                        .HasColumnName("Longitude");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Name");

                    b.Property<int>("WorkingHours")
                        .HasColumnType("int")
                        .HasColumnName("WorkingHours");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Outdoors", (string)null);
                });

            modelBuilder.Entity("Core.Entities.WaterType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("WaterTypes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mineral"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Spring"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Table"
                        });
                });

            modelBuilder.Entity("ExtrasFountain", b =>
                {
                    b.Property<int>("ExtrasId")
                        .HasColumnType("int");

                    b.Property<int>("FountainsId")
                        .HasColumnType("int");

                    b.HasKey("ExtrasId", "FountainsId");

                    b.HasIndex("FountainsId");

                    b.ToTable("ExtrasFountain");
                });

            modelBuilder.Entity("ExtrasLake", b =>
                {
                    b.Property<int>("ExtrasId")
                        .HasColumnType("int");

                    b.Property<int>("LakesId")
                        .HasColumnType("int");

                    b.HasKey("ExtrasId", "LakesId");

                    b.HasIndex("LakesId");

                    b.ToTable("ExtrasLake");
                });

            modelBuilder.Entity("ExtrasLandmark", b =>
                {
                    b.Property<int>("ExtrasId")
                        .HasColumnType("int");

                    b.Property<int>("LandmarksId")
                        .HasColumnType("int");

                    b.HasKey("ExtrasId", "LandmarksId");

                    b.HasIndex("LandmarksId");

                    b.ToTable("ExtrasLandmark");
                });

            modelBuilder.Entity("ExtrasNatureReserve", b =>
                {
                    b.Property<int>("ExtrasId")
                        .HasColumnType("int");

                    b.Property<int>("NatureReservesId")
                        .HasColumnType("int");

                    b.HasKey("ExtrasId", "NatureReservesId");

                    b.HasIndex("NatureReservesId");

                    b.ToTable("ExtrasNatureReserve");
                });

            modelBuilder.Entity("ExtrasPark", b =>
                {
                    b.Property<int>("ExtrasId")
                        .HasColumnType("int");

                    b.Property<int>("ParksId")
                        .HasColumnType("int");

                    b.HasKey("ExtrasId", "ParksId");

                    b.HasIndex("ParksId");

                    b.ToTable("ExtrasPark");
                });

            modelBuilder.Entity("ExtrasVilla", b =>
                {
                    b.Property<int>("ExtrasId")
                        .HasColumnType("int");

                    b.Property<int>("VillasId")
                        .HasColumnType("int");

                    b.HasKey("ExtrasId", "VillasId");

                    b.HasIndex("VillasId");

                    b.ToTable("ExtrasVilla");
                });

            modelBuilder.Entity("Core.Entities.Fountain", b =>
                {
                    b.HasBaseType("Core.Entities.Outdoor");

                    b.Property<string>("InMemoryOf")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("InMemoryOf");

                    b.Property<int>("WaterTypeId")
                        .HasColumnType("int");

                    b.HasIndex("WaterTypeId");

                    b.ToTable("Fountains", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Lake", b =>
                {
                    b.HasBaseType("Core.Entities.Outdoor");

                    b.ToTable("Lakes", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Landmark", b =>
                {
                    b.HasBaseType("Core.Entities.Outdoor");

                    b.ToTable("Landmarks", (string)null);
                });

            modelBuilder.Entity("Core.Entities.NatureReserve", b =>
                {
                    b.HasBaseType("Core.Entities.Outdoor");

                    b.Property<double>("Size")
                        .HasColumnType("float")
                        .HasColumnName("Size");

                    b.ToTable("NatureReserves", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Park", b =>
                {
                    b.HasBaseType("Core.Entities.Outdoor");

                    b.Property<string>("Safety")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Safety");

                    b.ToTable("Parks", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Villa", b =>
                {
                    b.HasBaseType("Core.Entities.Outdoor");

                    b.Property<int>("GuestCount")
                        .HasMaxLength(1000)
                        .HasColumnType("int")
                        .HasColumnName("GuestCount");

                    b.Property<int>("ParkingCount")
                        .HasColumnType("int")
                        .HasColumnName("ParkingCount");

                    b.Property<int>("RoomCount")
                        .HasMaxLength(1000)
                        .HasColumnType("int")
                        .HasColumnName("RoomCount");

                    b.ToTable("Villas", (string)null);
                });

            modelBuilder.Entity("AnimalLake", b =>
                {
                    b.HasOne("Core.Entities.Animal", null)
                        .WithMany()
                        .HasForeignKey("AnimalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Lake", null)
                        .WithMany()
                        .HasForeignKey("LakesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnimalNatureReserve", b =>
                {
                    b.HasOne("Core.Entities.Animal", null)
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.NatureReserve", null)
                        .WithMany()
                        .HasForeignKey("NatureReservesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnimalPark", b =>
                {
                    b.HasOne("Core.Entities.Animal", null)
                        .WithMany()
                        .HasForeignKey("AnimalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Park", null)
                        .WithMany()
                        .HasForeignKey("ParksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExtrasFountain", b =>
                {
                    b.HasOne("Core.Entities.Extras", null)
                        .WithMany()
                        .HasForeignKey("ExtrasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Fountain", null)
                        .WithMany()
                        .HasForeignKey("FountainsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExtrasLake", b =>
                {
                    b.HasOne("Core.Entities.Extras", null)
                        .WithMany()
                        .HasForeignKey("ExtrasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Lake", null)
                        .WithMany()
                        .HasForeignKey("LakesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExtrasLandmark", b =>
                {
                    b.HasOne("Core.Entities.Extras", null)
                        .WithMany()
                        .HasForeignKey("ExtrasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Landmark", null)
                        .WithMany()
                        .HasForeignKey("LandmarksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExtrasNatureReserve", b =>
                {
                    b.HasOne("Core.Entities.Extras", null)
                        .WithMany()
                        .HasForeignKey("ExtrasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.NatureReserve", null)
                        .WithMany()
                        .HasForeignKey("NatureReservesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExtrasPark", b =>
                {
                    b.HasOne("Core.Entities.Extras", null)
                        .WithMany()
                        .HasForeignKey("ExtrasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Park", null)
                        .WithMany()
                        .HasForeignKey("ParksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExtrasVilla", b =>
                {
                    b.HasOne("Core.Entities.Extras", null)
                        .WithMany()
                        .HasForeignKey("ExtrasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Villa", null)
                        .WithMany()
                        .HasForeignKey("VillasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entities.Fountain", b =>
                {
                    b.HasOne("Core.Entities.Outdoor", null)
                        .WithOne()
                        .HasForeignKey("Core.Entities.Fountain", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.WaterType", "WaterType")
                        .WithMany("Fountains")
                        .HasForeignKey("WaterTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WaterType");
                });

            modelBuilder.Entity("Core.Entities.Lake", b =>
                {
                    b.HasOne("Core.Entities.Outdoor", null)
                        .WithOne()
                        .HasForeignKey("Core.Entities.Lake", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entities.Landmark", b =>
                {
                    b.HasOne("Core.Entities.Outdoor", null)
                        .WithOne()
                        .HasForeignKey("Core.Entities.Landmark", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entities.NatureReserve", b =>
                {
                    b.HasOne("Core.Entities.Outdoor", null)
                        .WithOne()
                        .HasForeignKey("Core.Entities.NatureReserve", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entities.Park", b =>
                {
                    b.HasOne("Core.Entities.Outdoor", null)
                        .WithOne()
                        .HasForeignKey("Core.Entities.Park", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entities.Villa", b =>
                {
                    b.HasOne("Core.Entities.Outdoor", null)
                        .WithOne()
                        .HasForeignKey("Core.Entities.Villa", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entities.WaterType", b =>
                {
                    b.Navigation("Fountains");
                });
#pragma warning restore 612, 618
        }
    }
}
