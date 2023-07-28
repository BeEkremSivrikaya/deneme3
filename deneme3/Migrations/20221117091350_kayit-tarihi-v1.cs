using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme3.Migrations
{
    public partial class kayittarihiv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "KayitTarihi",
                table: "ogrencis",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KayitTarihi",
                table: "ogrencis");
        }
    }
}
