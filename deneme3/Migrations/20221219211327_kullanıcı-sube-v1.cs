using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme3.Migrations
{
    public partial class kullanıcısubev1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Personel_Sube_Adı",
                table: "Admins",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Personel_Sube_Adı",
                table: "Admins");
        }
    }
}
