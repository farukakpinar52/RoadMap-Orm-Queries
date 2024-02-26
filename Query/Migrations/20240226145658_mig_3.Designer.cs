﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Query.Migrations
{
    [DbContext(typeof(ETicaretDbContext))]
    [Migration("20240226145658_mig_3")]
    partial class mig_3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Parca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ParcaAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UrunId");

                    b.ToTable("Parcas");
                });

            modelBuilder.Entity("Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Fiyat")
                        .HasColumnType("real");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Uruns");
                });

            modelBuilder.Entity("UrunParca", b =>
                {
                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.Property<int>("ParcaId")
                        .HasColumnType("int");

                    b.HasKey("UrunId", "ParcaId");

                    b.HasIndex("ParcaId");

                    b.ToTable("UrunParcas");
                });

            modelBuilder.Entity("Parca", b =>
                {
                    b.HasOne("Urun", null)
                        .WithMany("Parcalar")
                        .HasForeignKey("UrunId");
                });

            modelBuilder.Entity("UrunParca", b =>
                {
                    b.HasOne("Parca", "Parca")
                        .WithMany()
                        .HasForeignKey("ParcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Urun", "Urun")
                        .WithMany()
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parca");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("Urun", b =>
                {
                    b.Navigation("Parcalar");
                });
#pragma warning restore 612, 618
        }
    }
}
