using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme3.Migrations
{
    public partial class Bireysel_Kurumsal_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Birey_Adi",
                table: "fatura",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Birey_Soyadi",
                table: "fatura",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Birey_Tc",
                table: "fatura",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fatura_Tipi",
                table: "fatura",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Firma_Adi",
                table: "fatura",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birey_Adi",
                table: "fatura");

            migrationBuilder.DropColumn(
                name: "Birey_Soyadi",
                table: "fatura");

            migrationBuilder.DropColumn(
                name: "Birey_Tc",
                table: "fatura");

            migrationBuilder.DropColumn(
                name: "Fatura_Tipi",
                table: "fatura");

            migrationBuilder.DropColumn(
                name: "Firma_Adi",
                table: "fatura");
        }
    }
}
