﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjekatWeb2.Infrastructure;

#nullable disable

namespace ProjekatWeb2.Migrations
{
    [DbContext(typeof(OnlineProdavnicaDbContext))]
    partial class OnlineProdavnicaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjekatWeb2.Models.Artikal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<double>("Cena")
                        .HasColumnType("float");

                    b.Property<double>("CenaDostave")
                        .HasColumnType("float");

                    b.Property<string>("Fotografija")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ProdavacId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProdavacId");

                    b.ToTable("Artikli");
                });

            modelBuilder.Entity("ProjekatWeb2.Models.ElementPorudzbine", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("IdArtikal")
                        .HasColumnType("bigint");

                    b.Property<long>("IdPorudzbina")
                        .HasColumnType("bigint");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPorudzbina");

                    b.ToTable("ElementPorudzbine");
                });

            modelBuilder.Entity("ProjekatWeb2.Models.Korisnik", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CenaDostave")
                        .HasColumnType("float");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipKorisnika")
                        .HasColumnType("int");

                    b.Property<int>("VerifikacijaProdavca")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("ProjekatWeb2.Models.Porudzbina", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AdresaDostave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Cena")
                        .HasColumnType("float");

                    b.Property<string>("Komentar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("KorisnikId")
                        .HasColumnType("bigint");

                    b.Property<int>("StatusPorudzbine")
                        .HasColumnType("int");

                    b.Property<DateTime>("VremeDostave")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VremePorucivanja")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Porudzbine");
                });

            modelBuilder.Entity("ProjekatWeb2.Models.Artikal", b =>
                {
                    b.HasOne("ProjekatWeb2.Models.Korisnik", "Prodavac")
                        .WithMany("ArtikliProdavac")
                        .HasForeignKey("ProdavacId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prodavac");
                });

            modelBuilder.Entity("ProjekatWeb2.Models.ElementPorudzbine", b =>
                {
                    b.HasOne("ProjekatWeb2.Models.Porudzbina", "Porudzbina")
                        .WithMany("ElementiPorudzbine")
                        .HasForeignKey("IdPorudzbina")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Porudzbina");
                });

            modelBuilder.Entity("ProjekatWeb2.Models.Porudzbina", b =>
                {
                    b.HasOne("ProjekatWeb2.Models.Korisnik", "Korisnik")
                        .WithMany("Porudzbine")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("ProjekatWeb2.Models.Korisnik", b =>
                {
                    b.Navigation("ArtikliProdavac");

                    b.Navigation("Porudzbine");
                });

            modelBuilder.Entity("ProjekatWeb2.Models.Porudzbina", b =>
                {
                    b.Navigation("ElementiPorudzbine");
                });
#pragma warning restore 612, 618
        }
    }
}
