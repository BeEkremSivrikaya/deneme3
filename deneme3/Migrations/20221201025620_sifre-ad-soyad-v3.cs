using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme3.Migrations
{
    public partial class sifreadsoyadv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SifrelenmisOgrenciAdi",
                table: "ogrencis");

            migrationBuilder.AddColumn<string>(
                name: "CozulmusOgrenciSoyad",
                table: "ogrencis",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CozulmusOgrenciSoyad",
                table: "ogrencis");

            migrationBuilder.AddColumn<string>(
                name: "SifrelenmisOgrenciAdi",
                table: "ogrencis",
                type: "text",
                nullable: true);
        }
    }
}
