﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cw13.Models;

namespace cw13.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20200610120026_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cw13.Models.Klient", b =>
                {
                    b.Property<int>("IdKlient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdKlient");

                    b.ToTable("Klient");

                    b.HasData(
                        new
                        {
                            IdKlient = 1,
                            Imie = "Adam",
                            Nazwisko = "Kowalski"
                        },
                        new
                        {
                            IdKlient = 2,
                            Imie = "Kasia",
                            Nazwisko = "Nowaczewska"
                        },
                        new
                        {
                            IdKlient = 3,
                            Imie = "Ola",
                            Nazwisko = "Pilewska"
                        },
                        new
                        {
                            IdKlient = 4,
                            Imie = "Ania",
                            Nazwisko = "Orlowska"
                        },
                        new
                        {
                            IdKlient = 5,
                            Imie = "Krzysztof",
                            Nazwisko = "Adamski"
                        });
                });

            modelBuilder.Entity("cw13.Models.Pracownik", b =>
                {
                    b.Property<int>("IdPracownik")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdPracownik");

                    b.ToTable("Pracownik");

                    b.HasData(
                        new
                        {
                            IdPracownik = 1,
                            Imie = "Pracownik1",
                            Nazwisko = "P1"
                        },
                        new
                        {
                            IdPracownik = 2,
                            Imie = "Pracownik2",
                            Nazwisko = "P2"
                        },
                        new
                        {
                            IdPracownik = 3,
                            Imie = "Pracownik3",
                            Nazwisko = "P3"
                        },
                        new
                        {
                            IdPracownik = 4,
                            Imie = "Pracownik4",
                            Nazwisko = "P4"
                        },
                        new
                        {
                            IdPracownik = 5,
                            Imie = "Pracownik5",
                            Nazwisko = "P5"
                        });
                });

            modelBuilder.Entity("cw13.Models.WyrobCukierniczy", b =>
                {
                    b.Property<int>("IdWyrobuCukierniczego")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CenaZaSzt")
                        .HasColumnType("real");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("IdWyrobuCukierniczego");

                    b.ToTable("WyrobCukierniczy");

                    b.HasData(
                        new
                        {
                            IdWyrobuCukierniczego = 1,
                            CenaZaSzt = 1.5f,
                            Nazwa = "Pierniczki",
                            Typ = "wypieki"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 2,
                            CenaZaSzt = 20f,
                            Nazwa = "Ciasto",
                            Typ = "wypieki"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 3,
                            CenaZaSzt = 3.5f,
                            Nazwa = "Paczek",
                            Typ = "wypieki"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 4,
                            CenaZaSzt = 2.5f,
                            Nazwa = "Ciastko",
                            Typ = "wypieki"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 5,
                            CenaZaSzt = 4f,
                            Nazwa = "Babeczka",
                            Typ = "wypieki"
                        });
                });

            modelBuilder.Entity("cw13.Models.Zamowienie", b =>
                {
                    b.Property<int>("IdZamowienia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataPrzyjecia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRealizacji")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdKlient")
                        .HasColumnType("int");

                    b.Property<int>("IdPracownik")
                        .HasColumnType("int");

                    b.Property<string>("Uwagi")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("IdZamowienia");

                    b.ToTable("Zamowienie");

                    b.HasData(
                        new
                        {
                            IdZamowienia = 1,
                            DataPrzyjecia = new DateTime(2020, 6, 10, 14, 0, 26, 51, DateTimeKind.Local).AddTicks(7850),
                            DataRealizacji = new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(1690),
                            IdKlient = 1,
                            IdPracownik = 1,
                            Uwagi = "brak"
                        },
                        new
                        {
                            IdZamowienia = 2,
                            DataPrzyjecia = new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(3720),
                            DataRealizacji = new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(3750),
                            IdKlient = 2,
                            IdPracownik = 1,
                            Uwagi = "Brak domofonu"
                        },
                        new
                        {
                            IdZamowienia = 3,
                            DataPrzyjecia = new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(3800),
                            DataRealizacji = new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(3800),
                            IdKlient = 3,
                            IdPracownik = 2,
                            Uwagi = "Parter"
                        },
                        new
                        {
                            IdZamowienia = 4,
                            DataPrzyjecia = new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(3810),
                            DataRealizacji = new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(3810),
                            IdKlient = 4,
                            IdPracownik = 2,
                            Uwagi = "Wejscie od Zlotej"
                        },
                        new
                        {
                            IdZamowienia = 5,
                            DataPrzyjecia = new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(3810),
                            DataRealizacji = new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(3820),
                            IdKlient = 5,
                            IdPracownik = 3,
                            Uwagi = "Wejscie od Kaliskiej"
                        });
                });

            modelBuilder.Entity("cw13.Models.Zamowienie_WyrobCukierniczy", b =>
                {
                    b.Property<int>("IdZamowienia")
                        .HasColumnType("int");

                    b.Property<int>("IdWyrobuCukierniczego")
                        .HasColumnType("int");

                    b.Property<int>("Ilosc")
                        .HasColumnType("int");

                    b.Property<string>("Uwagi")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("IdZamowienia");

                    b.ToTable("Zamowienie_WyrobCukierniczy");

                    b.HasData(
                        new
                        {
                            IdZamowienia = 1,
                            IdWyrobuCukierniczego = 1,
                            Ilosc = 20,
                            Uwagi = "brak"
                        },
                        new
                        {
                            IdZamowienia = 2,
                            IdWyrobuCukierniczego = 2,
                            Ilosc = 2,
                            Uwagi = "brak"
                        },
                        new
                        {
                            IdZamowienia = 3,
                            IdWyrobuCukierniczego = 3,
                            Ilosc = 4,
                            Uwagi = "brak"
                        },
                        new
                        {
                            IdZamowienia = 4,
                            IdWyrobuCukierniczego = 4,
                            Ilosc = 5,
                            Uwagi = "brak"
                        },
                        new
                        {
                            IdZamowienia = 5,
                            IdWyrobuCukierniczego = 5,
                            Ilosc = 6,
                            Uwagi = "brak"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}