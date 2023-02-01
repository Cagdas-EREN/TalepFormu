using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbonelikTurus",
                columns: table => new
                {
                    AboneTurId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AboneTuru = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbonelikTurus", x => x.AboneTurId);
                });

            migrationBuilder.CreateTable(
                name: "Caddes",
                columns: table => new
                {
                    CaddeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MahalleId = table.Column<int>(type: "integer", nullable: false),
                    CaddeAdi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caddes", x => x.CaddeId);
                });

            migrationBuilder.CreateTable(
                name: "Ilces",
                columns: table => new
                {
                    IlceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IlceAdi = table.Column<string>(type: "text", nullable: false),
                    IlId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilces", x => x.IlceId);
                });

            migrationBuilder.CreateTable(
                name: "Ils",
                columns: table => new
                {
                    IlId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    plakakodu = table.Column<string>(name: "plaka_kodu", type: "text", nullable: false),
                    aciklama = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ils", x => x.IlId);
                });

            migrationBuilder.CreateTable(
                name: "KisiselBilgilers",
                columns: table => new
                {
                    BilgilerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ad = table.Column<string>(type: "text", nullable: false),
                    Soyad = table.Column<string>(type: "text", nullable: false),
                    BabaAdi = table.Column<string>(type: "text", nullable: false),
                    AnneAdi = table.Column<string>(type: "text", nullable: false),
                    TCNO = table.Column<string>(type: "text", nullable: false),
                    KimlikSeriNo = table.Column<string>(type: "text", nullable: false),
                    Telefon = table.Column<string>(type: "text", nullable: false),
                    Mail = table.Column<string>(type: "text", nullable: false),
                    GüvenlikKelimesi = table.Column<string>(type: "text", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FirmaAdi = table.Column<string>(type: "text", nullable: false),
                    VergiDairesi = table.Column<string>(type: "text", nullable: false),
                    VergiNo = table.Column<string>(type: "text", nullable: false),
                    IcKapiNo = table.Column<string>(type: "text", nullable: false),
                    DisKapiNo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KisiselBilgilers", x => x.BilgilerId);
                });

            migrationBuilder.CreateTable(
                name: "Mahalles",
                columns: table => new
                {
                    MahalleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IlceId = table.Column<int>(type: "integer", nullable: false),
                    MahalleAdi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mahalles", x => x.MahalleId);
                });

            migrationBuilder.CreateTable(
                name: "MeslekKodlaris",
                columns: table => new
                {
                    MeslekId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MeslekKodu = table.Column<string>(type: "text", nullable: false),
                    MeslekAdi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeslekKodlaris", x => x.MeslekId);
                });

            migrationBuilder.CreateTable(
                name: "Numaralars",
                columns: table => new
                {
                    NumaraId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumaraNo = table.Column<string>(type: "text", nullable: false),
                    ozelnumara = table.Column<string>(type: "text", nullable: false),
                    tahsisedildi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Numaralars", x => x.NumaraId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbonelikTurus");

            migrationBuilder.DropTable(
                name: "Caddes");

            migrationBuilder.DropTable(
                name: "Ilces");

            migrationBuilder.DropTable(
                name: "Ils");

            migrationBuilder.DropTable(
                name: "KisiselBilgilers");

            migrationBuilder.DropTable(
                name: "Mahalles");

            migrationBuilder.DropTable(
                name: "MeslekKodlaris");

            migrationBuilder.DropTable(
                name: "Numaralars");
        }
    }
}
