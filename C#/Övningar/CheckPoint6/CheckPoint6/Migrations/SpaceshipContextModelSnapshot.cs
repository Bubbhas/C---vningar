﻿// <auto-generated />
using System;
using CheckPoint6;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CheckPoint6.Migrations
{
    [DbContext(typeof(SpaceshipContext))]
    partial class SpaceshipContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CheckPoint6.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("End");

                    b.Property<string>("Made");

                    b.Property<string>("Name");

                    b.Property<int>("Quantity");

                    b.Property<int?>("SpaceshipId");

                    b.HasKey("Id");

                    b.HasIndex("SpaceshipId");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("CheckPoint6.Spaceship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Spaceships");
                });

            modelBuilder.Entity("CheckPoint6.Food", b =>
                {
                    b.HasOne("CheckPoint6.Spaceship")
                        .WithMany("food")
                        .HasForeignKey("SpaceshipId");
                });
#pragma warning restore 612, 618
        }
    }
}
