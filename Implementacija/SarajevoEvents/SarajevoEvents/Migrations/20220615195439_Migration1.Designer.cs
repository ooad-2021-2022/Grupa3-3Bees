﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SarajevoEvents.Migrations
{
    [DbContext(typeof(ApplicationDataContext))]
    [Migration("20220615195439_Migration1")]
    partial class Migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SarajevoEvents.Models.Dogadjaj", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDPoslovniKorisnik")
                        .HasColumnType("int");

                    b.Property<int>("brojNagradnihBodova")
                        .HasColumnType("int");

                    b.Property<double>("cijenaKarte")
                        .HasColumnType("float");

                    b.Property<DateTime>("datumOdrzavanja")
                        .HasColumnType("datetime2");

                    b.Property<bool>("potrebnaKarta")
                        .HasColumnType("bit");

                    b.Property<bool>("potrebnaRezervacija")
                        .HasColumnType("bit");

                    b.Property<int>("vrstaDogadjaja")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDPoslovniKorisnik");

                    b.ToTable("Dogadjaj");
                });

            modelBuilder.Entity("SarajevoEvents.Models.Feedback", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("SarajevoEvents.Models.Karta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDDogadjaj")
                        .HasColumnType("int");

                    b.Property<int>("IDPlacanje")
                        .HasColumnType("int");

                    b.Property<int?>("IDRegistrovaniKorisnik")
                        .HasColumnType("int");

                    b.Property<double>("cijena")
                        .HasColumnType("float");

                    b.Property<int?>("dogadjajID")
                        .HasColumnType("int");

                    b.Property<int?>("placanjeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDRegistrovaniKorisnik");

                    b.HasIndex("dogadjajID");

                    b.HasIndex("placanjeID");

                    b.ToTable("Karta");
                });

            modelBuilder.Entity("SarajevoEvents.Models.Placanje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDPopust")
                        .HasColumnType("int");

                    b.Property<double>("cijenaZaPlatiti")
                        .HasColumnType("float");

                    b.Property<string>("korisnik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazivSistema")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("popustID")
                        .HasColumnType("int");

                    b.Property<double>("vrijednostPopusta")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("popustID");

                    b.ToTable("Placanje");
                });

            modelBuilder.Entity("SarajevoEvents.Models.Popust", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDRegistrovaniKorisnik")
                        .HasColumnType("int");

                    b.Property<string>("skupljeniBodovi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("vrijednostPopusta")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("IDRegistrovaniKorisnik");

                    b.ToTable("Popust");
                });

            modelBuilder.Entity("SarajevoEvents.Models.PoslovniKorisnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("brojNagradnihBodova")
                        .HasColumnType("int");

                    b.Property<string>("brojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazivKorisnika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PoslovniKorisnik");
                });

            modelBuilder.Entity("SarajevoEvents.Models.RegistrovaniKorisnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("brojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazivKorisnika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("RegistrovaniKorisnik");
                });

            modelBuilder.Entity("SarajevoEvents.Models.Dogadjaj", b =>
                {
                    b.HasOne("SarajevoEvents.Models.PoslovniKorisnik", "PoslovniKorisnik")
                        .WithMany()
                        .HasForeignKey("IDPoslovniKorisnik")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PoslovniKorisnik");
                });

            modelBuilder.Entity("SarajevoEvents.Models.Feedback", b =>
                {
                    b.HasOne("SarajevoEvents.Models.RegistrovaniKorisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("SarajevoEvents.Models.Karta", b =>
                {
                    b.HasOne("SarajevoEvents.Models.RegistrovaniKorisnik", "RegistrovaniKorisnik")
                        .WithMany()
                        .HasForeignKey("IDRegistrovaniKorisnik");

                    b.HasOne("SarajevoEvents.Models.Dogadjaj", "dogadjaj")
                        .WithMany()
                        .HasForeignKey("dogadjajID");

                    b.HasOne("SarajevoEvents.Models.Placanje", "placanje")
                        .WithMany()
                        .HasForeignKey("placanjeID");

                    b.Navigation("dogadjaj");

                    b.Navigation("placanje");

                    b.Navigation("RegistrovaniKorisnik");
                });

            modelBuilder.Entity("SarajevoEvents.Models.Placanje", b =>
                {
                    b.HasOne("SarajevoEvents.Models.Popust", "popust")
                        .WithMany()
                        .HasForeignKey("popustID");

                    b.Navigation("popust");
                });

            modelBuilder.Entity("SarajevoEvents.Models.Popust", b =>
                {
                    b.HasOne("SarajevoEvents.Models.RegistrovaniKorisnik", "RegistrovaniKorisnik")
                        .WithMany()
                        .HasForeignKey("IDRegistrovaniKorisnik")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegistrovaniKorisnik");
                });
#pragma warning restore 612, 618
        }
    }
}
