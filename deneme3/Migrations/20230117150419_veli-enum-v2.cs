using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme3.Migrations
{
    public partial class velienumv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "VelininTipi",
                table: "velis",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VelininTipi",
                table: "velis");

        }
    }
}
