﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RehabBackend.Data;

#nullable disable

namespace RehabBackend.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241002145237_UpdateModels")]
    partial class UpdateModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("RehabBackend.Core.Entities.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Patients")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("RehabBackend.Core.Entities.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Plans")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ExerciseId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("RehabBackend.Core.Entities.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Plans")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("RehabBackend.Core.Entities.Plan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Exercises")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Patients")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PlanId");

                    b.ToTable("Plans");
                });
#pragma warning restore 612, 618
        }
    }
}