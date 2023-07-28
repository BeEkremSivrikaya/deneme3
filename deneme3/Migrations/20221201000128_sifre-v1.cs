using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme3.Migrations
{
    public partial class sifrev1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CozulmusOgrenciAdi",
                table: "ogrencis",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CozulmusOgrenciAdi",
                table: "ogrencis");
        }
    }
}
