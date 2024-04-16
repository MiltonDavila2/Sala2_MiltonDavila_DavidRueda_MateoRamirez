﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiltonDavila_Taller.Data;

#nullable disable

namespace MiltonDavila_Taller.Migrations
{
    [DbContext(typeof(MiltonDavila_TallerContext))]
    [Migration("20240416004905_CambiosBdd")]
    partial class CambiosBdd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MiltonDavila_Taller.Models.EstudianteUDLA", b =>
                {
                    b.Property<int>("BannerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BannerID"));

                    b.Property<DateTime?>("FechadeNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("LugarVacunacionId")
                        .HasColumnType("int");

                    b.Property<string>("NombreEstudiante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VacunaId")
                        .HasColumnType("int");

                    b.HasKey("BannerID");

                    b.HasIndex("LugarVacunacionId");

                    b.HasIndex("VacunaId");

                    b.ToTable("EstudianteUDLA");
                });

            modelBuilder.Entity("MiltonDavila_Taller.Models.LugarVacunacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaVacunacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("LugarVacunacion");
                });

            modelBuilder.Entity("MiltonDavila_Taller.Models.Vacuna", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NombreVacuna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("paisProcedencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vacuna");
                });

            modelBuilder.Entity("MiltonDavila_Taller.Models.EstudianteUDLA", b =>
                {
                    b.HasOne("MiltonDavila_Taller.Models.LugarVacunacion", "LugarVacunacion")
                        .WithMany()
                        .HasForeignKey("LugarVacunacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiltonDavila_Taller.Models.Vacuna", "Vacuna")
                        .WithMany()
                        .HasForeignKey("VacunaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LugarVacunacion");

                    b.Navigation("Vacuna");
                });
#pragma warning restore 612, 618
        }
    }
}
