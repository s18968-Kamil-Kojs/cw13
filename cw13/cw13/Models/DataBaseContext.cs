using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace cw13.Models {
    public class DataBaseContext : DbContext{
        public DbSet<Klient> Klient { get; set; }
        public DbSet<Pracownik> Pracownik { get; set; }
        public DbSet<WyrobCukierniczy> WyrobCukierniczy { get; set; }
        public DbSet<Zamowienie> Zamowienie { get; set; }
        public DbSet<Zamowienie_WyrobCukierniczy> Zamowienie_WyrobCukierniczy { get; set; }

        public DataBaseContext() {
        }

        public DataBaseContext(DbContextOptions options) : base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Klient>()
                        .HasKey(e => e.IdKlient);
            modelBuilder.Entity<Klient>()
                        .Property(e => e.Imie)
                        .HasMaxLength(50)
                        .IsRequired();
            modelBuilder.Entity<Klient>()
                        .Property(e => e.Nazwisko)
                        .HasMaxLength(60)
                        .IsRequired();
            var klientList = new List<Klient>();
            klientList.Add(new Models.Klient { IdKlient = 1, Imie = "Adam", Nazwisko = "Kowalski" });
            klientList.Add(new Models.Klient { IdKlient = 2, Imie = "Kasia", Nazwisko = "Nowaczewska" });
            klientList.Add(new Models.Klient { IdKlient = 3, Imie = "Ola", Nazwisko = "Pilewska" });
            klientList.Add(new Models.Klient { IdKlient = 4, Imie = "Ania", Nazwisko = "Orlowska" });
            klientList.Add(new Models.Klient { IdKlient = 5, Imie = "Krzysztof", Nazwisko = "Adamski" });
            modelBuilder.Entity<Klient>().HasData(klientList);



            modelBuilder.Entity<Pracownik>()
                        .HasKey(e => e.IdPracownik);
            modelBuilder.Entity<Pracownik>()
                        .Property(e => e.Imie)
                        .HasMaxLength(50)
                        .IsRequired();
            modelBuilder.Entity<Pracownik>()
                        .Property(e => e.Nazwisko)
                        .HasMaxLength(60)
                        .IsRequired();
            var pracownikList = new List<Pracownik>();
            pracownikList.Add(new Models.Pracownik { IdPracownik = 1, Imie = "Pracownik1", Nazwisko = "P1" });
            pracownikList.Add(new Models.Pracownik { IdPracownik = 2, Imie = "Pracownik2", Nazwisko = "P2" });
            pracownikList.Add(new Models.Pracownik { IdPracownik = 3, Imie = "Pracownik3", Nazwisko = "P3" });
            pracownikList.Add(new Models.Pracownik { IdPracownik = 4, Imie = "Pracownik4", Nazwisko = "P4" });
            pracownikList.Add(new Models.Pracownik { IdPracownik = 5, Imie = "Pracownik5", Nazwisko = "P5" });
            modelBuilder.Entity<Pracownik>().HasData(pracownikList);



            modelBuilder.Entity<Zamowienie>()
                        .HasKey(e => e.IdZamowienia);
            modelBuilder.Entity<Zamowienie>()
                        .Property(e => e.DataPrzyjecia)
                        .IsRequired();
            modelBuilder.Entity<Zamowienie>()
                        .Property(e => e.Uwagi)
                        .HasMaxLength(300);
            var zamowienieList = new List<Zamowienie>();
            zamowienieList.Add(new Models.Zamowienie { IdZamowienia = 1, DataPrzyjecia = System.DateTime.Now, DataRealizacji = System.DateTime.Now, Uwagi = "brak", IdKlient = 1, IdPracownik = 1 });
            zamowienieList.Add(new Models.Zamowienie { IdZamowienia = 2, DataPrzyjecia = System.DateTime.Now, DataRealizacji = System.DateTime.Now, Uwagi = "Brak domofonu", IdKlient = 2, IdPracownik = 1 });
            zamowienieList.Add(new Models.Zamowienie { IdZamowienia = 3, DataPrzyjecia = System.DateTime.Now, DataRealizacji = System.DateTime.Now, Uwagi = "Parter", IdKlient = 3, IdPracownik = 2 });
            zamowienieList.Add(new Models.Zamowienie { IdZamowienia = 4, DataPrzyjecia = System.DateTime.Now, DataRealizacji = System.DateTime.Now, Uwagi = "Wejscie od Zlotej", IdKlient = 4, IdPracownik = 2 });
            zamowienieList.Add(new Models.Zamowienie { IdZamowienia = 5, DataPrzyjecia = System.DateTime.Now, DataRealizacji = System.DateTime.Now, Uwagi = "Wejscie od Kaliskiej", IdKlient = 5, IdPracownik = 3 });
            modelBuilder.Entity<Zamowienie>().HasData(zamowienieList);



            modelBuilder.Entity<WyrobCukierniczy>()
                        .HasKey(e => e.IdWyrobuCukierniczego);
            modelBuilder.Entity<WyrobCukierniczy>()
                        .Property(e => e.Nazwa)
                        .HasMaxLength(200)
                        .IsRequired();
            modelBuilder.Entity<WyrobCukierniczy>()
                        .Property(e => e.CenaZaSzt)
                        .IsRequired();
            modelBuilder.Entity<WyrobCukierniczy>()
                        .Property(e => e.Typ)
                        .HasMaxLength(40)
                        .IsRequired();
            var wyrobList = new List<WyrobCukierniczy>();
            wyrobList.Add(new Models.WyrobCukierniczy { IdWyrobuCukierniczego = 1, Nazwa = "Pierniczki", CenaZaSzt = 1.5F, Typ = "wypieki" });
            wyrobList.Add(new Models.WyrobCukierniczy { IdWyrobuCukierniczego = 2, Nazwa = "Ciasto", CenaZaSzt = 20F, Typ = "wypieki" });
            wyrobList.Add(new Models.WyrobCukierniczy { IdWyrobuCukierniczego = 3, Nazwa = "Paczek", CenaZaSzt = 3.5F, Typ = "wypieki" });
            wyrobList.Add(new Models.WyrobCukierniczy { IdWyrobuCukierniczego = 4, Nazwa = "Ciastko", CenaZaSzt = 2.5F, Typ = "wypieki" });
            wyrobList.Add(new Models.WyrobCukierniczy { IdWyrobuCukierniczego = 5, Nazwa = "Babeczka", CenaZaSzt = 4F, Typ = "wypieki" });
            modelBuilder.Entity<WyrobCukierniczy>().HasData(wyrobList);




            modelBuilder.Entity<Zamowienie_WyrobCukierniczy>()
                        .HasKey(e => e.IdWyrobuCukierniczego);
            modelBuilder.Entity<Zamowienie_WyrobCukierniczy>()
                        .Property(e => e.IdWyrobuCukierniczego)
                        .ValueGeneratedNever();
            modelBuilder.Entity<Zamowienie_WyrobCukierniczy>()
                        .HasKey(e => e.IdZamowienia);
            modelBuilder.Entity<Zamowienie_WyrobCukierniczy>()
                        .Property(e => e.IdZamowienia)
                        .ValueGeneratedNever();
            modelBuilder.Entity<Zamowienie_WyrobCukierniczy>()
                        .Property(e => e.Ilosc)
                        .IsRequired();
            modelBuilder.Entity<Zamowienie_WyrobCukierniczy>()
                        .Property(e => e.Uwagi)
                        .HasMaxLength(300);
            var zamowienie_wyrob_List = new List<Zamowienie_WyrobCukierniczy>();
            zamowienie_wyrob_List.Add(new Models.Zamowienie_WyrobCukierniczy { IdWyrobuCukierniczego = 1, IdZamowienia = 1, Ilosc = 20, Uwagi = "brak" });
            zamowienie_wyrob_List.Add(new Models.Zamowienie_WyrobCukierniczy { IdWyrobuCukierniczego = 2, IdZamowienia = 2, Ilosc = 2, Uwagi = "brak" });
            zamowienie_wyrob_List.Add(new Models.Zamowienie_WyrobCukierniczy { IdWyrobuCukierniczego = 3, IdZamowienia = 3, Ilosc = 4, Uwagi = "brak" });
            zamowienie_wyrob_List.Add(new Models.Zamowienie_WyrobCukierniczy { IdWyrobuCukierniczego = 4, IdZamowienia = 4, Ilosc = 5, Uwagi = "brak" });
            zamowienie_wyrob_List.Add(new Models.Zamowienie_WyrobCukierniczy { IdWyrobuCukierniczego = 5, IdZamowienia = 5, Ilosc = 6, Uwagi = "brak" });
            modelBuilder.Entity<Zamowienie_WyrobCukierniczy>().HasData(zamowienie_wyrob_List); 
        }
    }
}
