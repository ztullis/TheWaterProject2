﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheWaterProject2.Models;

#nullable disable

namespace TheWaterProject2.Migrations
{
    [DbContext(typeof(WaterProjectContext2))]
    [Migration("20240319034508_Initial4")]
    partial class Initial4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("TheWaterProject2.Models.Project", b =>
                {
                    b.Property<int>("projectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("programName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("projectImpactLevel")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("projectInstallation")
                        .HasColumnType("TEXT");

                    b.Property<string>("projectName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("projectPhase")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("projectType")
                        .HasColumnType("TEXT");

                    b.HasKey("projectId");

                    b.ToTable("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
