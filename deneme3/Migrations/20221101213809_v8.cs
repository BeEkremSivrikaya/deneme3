using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme3.Migrations
{
    public partial class v8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TckimlikNo",
                table: "ogrencis",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TckimlikNo",
                table: "ogrencis",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
