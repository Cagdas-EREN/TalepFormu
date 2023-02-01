using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BilgilerId",
                table: "Numaralars",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BilgilerId",
                table: "MeslekKodlaris",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BilgilerId",
                table: "Mahalles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BilgilerId",
                table: "Ils",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BilgilerId",
                table: "Ilces",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BilgilerId",
                table: "Caddes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BilgilerId",
                table: "AbonelikTurus",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BilgilerId",
                table: "Numaralars");

            migrationBuilder.DropColumn(
                name: "BilgilerId",
                table: "MeslekKodlaris");

            migrationBuilder.DropColumn(
                name: "BilgilerId",
                table: "Mahalles");

            migrationBuilder.DropColumn(
                name: "BilgilerId",
                table: "Ils");

            migrationBuilder.DropColumn(
                name: "BilgilerId",
                table: "Ilces");

            migrationBuilder.DropColumn(
                name: "BilgilerId",
                table: "Caddes");

            migrationBuilder.DropColumn(
                name: "BilgilerId",
                table: "AbonelikTurus");
        }
    }
}
