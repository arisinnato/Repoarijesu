﻿// <auto-generated />
using System.Collections.Generic;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250129222052_TipoPersonaje")]
    partial class TipoPersonaje
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Enemigo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("agilidad")
                        .HasColumnType("integer");

                    b.Property<int>("defensa")
                        .HasColumnType("integer");

                    b.Property<int>("energia")
                        .HasColumnType("integer");

                    b.Property<int>("fuerza")
                        .HasColumnType("integer");

                    b.Property<int>("inteligencia")
                        .HasColumnType("integer");

                    b.Property<int>("nivelAmenaza")
                        .HasColumnType("integer");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.PrimitiveCollection<List<string>>("recompensas")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<int>("salud")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Enemigo", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Equipo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("Personajeid")
                        .HasColumnType("integer");

                    b.Property<string>("arma1")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("arma2")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("armadura")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("casco")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("grebas")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("guanteletes")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("id");

                    b.HasIndex("Personajeid");

                    b.ToTable("Equipo", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Habilidad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("Enemigoid")
                        .HasColumnType("integer");

                    b.Property<int>("ataqueBase")
                        .HasColumnType("integer");

                    b.Property<int>("costoEnergia")
                        .HasColumnType("integer");

                    b.Property<int>("costoMana")
                        .HasColumnType("integer");

                    b.Property<int>("costoSalud")
                        .HasColumnType("integer");

                    b.Property<int>("nivelRequerido")
                        .HasColumnType("integer");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("tiempoEnfriamiento")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.HasIndex("Enemigoid");

                    b.ToTable("Habilidads");
                });

            modelBuilder.Entity("Core.Entities.Mision", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<char>("estado")
                        .HasColumnType("character(1)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.PrimitiveCollection<List<string>>("objetivos")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.PrimitiveCollection<List<string>>("recompensas")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.HasKey("id");

                    b.ToTable("Mision", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Objeto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.PrimitiveCollection<List<string>>("estadisticas")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("id");

                    b.ToTable("Objeto", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Personaje", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("agilidad")
                        .HasColumnType("integer");

                    b.Property<int>("defensa")
                        .HasColumnType("integer");

                    b.Property<int>("energia")
                        .HasColumnType("integer");

                    b.Property<int>("experiencia")
                        .HasColumnType("integer");

                    b.Property<int>("fuerza")
                        .HasColumnType("integer");

                    b.Property<int>("idTipoPersonaje")
                        .HasColumnType("integer");

                    b.Property<int>("inteligencia")
                        .HasColumnType("integer");

                    b.Property<int>("nivel")
                        .HasColumnType("integer");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("salud")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("idTipoPersonaje");

                    b.ToTable("Personaje", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoPersonaje", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("TipoPersonaje");
                });

            modelBuilder.Entity("Core.Entities.Ubicacion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("clima")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("id");

                    b.ToTable("Ubicacion", (string)null);
                });

            modelBuilder.Entity("HabilidadPersonaje", b =>
                {
                    b.Property<int>("habilidadesid")
                        .HasColumnType("integer");

                    b.Property<int>("personajesid")
                        .HasColumnType("integer");

                    b.HasKey("habilidadesid", "personajesid");

                    b.HasIndex("personajesid");

                    b.ToTable("HabilidadPersonaje");
                });

            modelBuilder.Entity("Core.Entities.Equipo", b =>
                {
                    b.HasOne("Core.Entities.Personaje", null)
                        .WithMany("equipo")
                        .HasForeignKey("Personajeid");
                });

            modelBuilder.Entity("Core.Entities.Habilidad", b =>
                {
                    b.HasOne("Core.Entities.Enemigo", null)
                        .WithMany("habilidades")
                        .HasForeignKey("Enemigoid");
                });

            modelBuilder.Entity("Core.Entities.Personaje", b =>
                {
                    b.HasOne("Core.Entities.TipoPersonaje", "tipo")
                        .WithMany()
                        .HasForeignKey("idTipoPersonaje")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tipo");
                });

            modelBuilder.Entity("HabilidadPersonaje", b =>
                {
                    b.HasOne("Core.Entities.Habilidad", null)
                        .WithMany()
                        .HasForeignKey("habilidadesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Personaje", null)
                        .WithMany()
                        .HasForeignKey("personajesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entities.Enemigo", b =>
                {
                    b.Navigation("habilidades");
                });

            modelBuilder.Entity("Core.Entities.Personaje", b =>
                {
                    b.Navigation("equipo");
                });
#pragma warning restore 612, 618
        }
    }
}
