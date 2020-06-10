using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cw13.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klient",
                columns: table => new
                {
                    IdKlient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(maxLength: 50, nullable: false),
                    Nazwisko = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klient", x => x.IdKlient);
                });

            migrationBuilder.CreateTable(
                name: "Pracownik",
                columns: table => new
                {
                    IdPracownik = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(maxLength: 50, nullable: false),
                    Nazwisko = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracownik", x => x.IdPracownik);
                });

            migrationBuilder.CreateTable(
                name: "WyrobCukierniczy",
                columns: table => new
                {
                    IdWyrobuCukierniczego = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(maxLength: 200, nullable: false),
                    CenaZaSzt = table.Column<float>(nullable: false),
                    Typ = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WyrobCukierniczy", x => x.IdWyrobuCukierniczego);
                });

            migrationBuilder.CreateTable(
                name: "Zamowienie",
                columns: table => new
                {
                    IdZamowienia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPrzyjecia = table.Column<DateTime>(nullable: false),
                    DataRealizacji = table.Column<DateTime>(nullable: false),
                    Uwagi = table.Column<string>(maxLength: 300, nullable: true),
                    IdKlient = table.Column<int>(nullable: false),
                    IdPracownik = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamowienie", x => x.IdZamowienia);
                });

            migrationBuilder.CreateTable(
                name: "Zamowienie_WyrobCukierniczy",
                columns: table => new
                {
                    IdZamowienia = table.Column<int>(nullable: false),
                    IdWyrobuCukierniczego = table.Column<int>(nullable: false),
                    Ilosc = table.Column<int>(nullable: false),
                    Uwagi = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamowienie_WyrobCukierniczy", x => x.IdZamowienia);
                });

            migrationBuilder.InsertData(
                table: "Klient",
                columns: new[] { "IdKlient", "Imie", "Nazwisko" },
                values: new object[,]
                {
                    { 1, "Adam", "Kowalski" },
                    { 2, "Kasia", "Nowaczewska" },
                    { 3, "Ola", "Pilewska" },
                    { 4, "Ania", "Orlowska" },
                    { 5, "Krzysztof", "Adamski" }
                });

            migrationBuilder.InsertData(
                table: "Pracownik",
                columns: new[] { "IdPracownik", "Imie", "Nazwisko" },
                values: new object[,]
                {
                    { 1, "Pracownik1", "P1" },
                    { 2, "Pracownik2", "P2" },
                    { 3, "Pracownik3", "P3" },
                    { 4, "Pracownik4", "P4" },
                    { 5, "Pracownik5", "P5" }
                });

            migrationBuilder.InsertData(
                table: "WyrobCukierniczy",
                columns: new[] { "IdWyrobuCukierniczego", "CenaZaSzt", "Nazwa", "Typ" },
                values: new object[,]
                {
                    { 5, 4f, "Babeczka", "wypieki" },
                    { 4, 2.5f, "Ciastko", "wypieki" },
                    { 3, 3.5f, "Paczek", "wypieki" },
                    { 2, 20f, "Ciasto", "wypieki" },
                    { 1, 1.5f, "Pierniczki", "wypieki" }
                });

            migrationBuilder.InsertData(
                table: "Zamowienie",
                columns: new[] { "IdZamowienia", "DataPrzyjecia", "DataRealizacji", "IdKlient", "IdPracownik", "Uwagi" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 10, 14, 0, 26, 51, DateTimeKind.Local).AddTicks(7850), new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(1690), 1, 1, "brak" },
                    { 2, new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(3720), new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(3750), 2, 1, "Brak domofonu" },
                    { 3, new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(3800), new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(3800), 3, 2, "Parter" },
                    { 4, new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(3810), new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(3810), 4, 2, "Wejscie od Zlotej" },
                    { 5, new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(3810), new DateTime(2020, 6, 10, 14, 0, 26, 55, DateTimeKind.Local).AddTicks(3820), 5, 3, "Wejscie od Kaliskiej" }
                });

            migrationBuilder.InsertData(
                table: "Zamowienie_WyrobCukierniczy",
                columns: new[] { "IdZamowienia", "IdWyrobuCukierniczego", "Ilosc", "Uwagi" },
                values: new object[,]
                {
                    { 1, 1, 20, "brak" },
                    { 2, 2, 2, "brak" },
                    { 3, 3, 4, "brak" },
                    { 4, 4, 5, "brak" },
                    { 5, 5, 6, "brak" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Klient");

            migrationBuilder.DropTable(
                name: "Pracownik");

            migrationBuilder.DropTable(
                name: "WyrobCukierniczy");

            migrationBuilder.DropTable(
                name: "Zamowienie");

            migrationBuilder.DropTable(
                name: "Zamowienie_WyrobCukierniczy");
        }
    }
}
