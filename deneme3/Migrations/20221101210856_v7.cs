using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme3.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OgrenciSoyad",
                table: "ogrencis",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "OgrenciAdi",
                table: "ogrencis",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ogrencis",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CepNo",
                table: "ogrencis",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OgrenciSoyad",
                table: "ogrencis",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "OgrenciAdi",
                table: "ogrencis",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ogrencis",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CepNo",
                table: "ogrencis",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 11);
        }
    }
}
