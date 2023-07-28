using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace deneme3.Migrations
{
    public partial class sonv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_kurs_ogrencis_Ogrenci_Id",
                table: "kurs");

            migrationBuilder.DropForeignKey(
                name: "FK_odemelers_bankas_Banka_Id",
                table: "odemelers");

            migrationBuilder.DropForeignKey(
                name: "FK_odemelers_velis_VelisVeli_Id",
                table: "odemelers");

            migrationBuilder.DropIndex(
                name: "IX_odemelers_VelisVeli_Id",
                table: "odemelers");

            migrationBuilder.DropIndex(
                name: "IX_kurs_Ogrenci_Id",
                table: "kurs");

            migrationBuilder.DropColumn(
                name: "VelisVeli_Id",
                table: "odemelers");

            migrationBuilder.DropColumn(
                name: "BitisZamani",
                table: "kurs");

            migrationBuilder.DropColumn(
                name: "Ogrenci_Id",
                table: "kurs");

            migrationBuilder.RenameColumn(
                name: "Banka_Id",
                table: "odemelers",
                newName: "banka_Id");

            migrationBuilder.RenameIndex(
                name: "IX_odemelers_Banka_Id",
                table: "odemelers",
                newName: "IX_odemelers_banka_Id");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "OdemeTurleris",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IndırımOranlarıID",
                table: "OdemeTurleris",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "banka_Id",
                table: "odemelers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "KurId",
                table: "odemelers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "bakiye",
                table: "odemelers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "borçTutarı",
                table: "odemelers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "kalanOdemeMiktari",
                table: "odemelers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "taksit_sayısı",
                table: "odemelers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "KurBitiş",
                table: "kurs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OgrenciNo",
                table: "kurs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "kurucreti",
                table: "kurs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "süre",
                table: "kurs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "borcs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Veli_Id = table.Column<int>(nullable: false),
                    KurId = table.Column<int>(nullable: false),
                    OgrenciNo = table.Column<int>(nullable: false),
                    OgrenciNo1 = table.Column<int>(nullable: true),
                    guncelborc = table.Column<double>(nullable: false),
                    borctarihi = table.Column<DateTime>(nullable: false),
                    toplamborc = table.Column<double>(nullable: false),
                    faturaDurumu = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_borcs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_borcs_kurs_KurId",
                        column: x => x.KurId,
                        principalTable: "kurs",
                        principalColumn: "KayıtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_borcs_ogrencis_OgrenciNo1",
                        column: x => x.OgrenciNo1,
                        principalTable: "ogrencis",
                        principalColumn: "OgrenciNo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_borcs_velis_Veli_Id",
                        column: x => x.Veli_Id,
                        principalTable: "velis",
                        principalColumn: "Veli_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "devamsızlıks",
                columns: table => new
                {
                    Kayıt_Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Kur_no = table.Column<int>(nullable: false),
                    devamsizlık = table.Column<bool>(nullable: false),
                    OgrenciNo = table.Column<int>(nullable: false),
                    OgrenciNo1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_devamsızlıks", x => x.Kayıt_Id);
                    table.ForeignKey(
                        name: "FK_devamsızlıks_ogrencis_OgrenciNo1",
                        column: x => x.OgrenciNo1,
                        principalTable: "ogrencis",
                        principalColumn: "OgrenciNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ındırımOranlarıs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    indirimismi = table.Column<string>(nullable: true),
                    indirimoranları = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ındırımOranlarıs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KurOgrencis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ogrenci_Id = table.Column<int>(nullable: false),
                    Kur_Id = table.Column<int>(nullable: false),
                    kurucreti = table.Column<int>(nullable: false),
                    başarıdurumu = table.Column<bool>(nullable: false),
                    mezuniyet_durumu = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KurOgrencis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KurOgrencis_kurs_Kur_Id",
                        column: x => x.Kur_Id,
                        principalTable: "kurs",
                        principalColumn: "KayıtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KurOgrencis_ogrencis_Ogrenci_Id",
                        column: x => x.Ogrenci_Id,
                        principalTable: "ogrencis",
                        principalColumn: "OgrenciNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OdemeTurleris_IndırımOranlarıID",
                table: "OdemeTurleris",
                column: "IndırımOranlarıID");

            migrationBuilder.CreateIndex(
                name: "IX_odemelers_Veli_Id",
                table: "odemelers",
                column: "Veli_Id");

            migrationBuilder.CreateIndex(
                name: "IX_kurs_OgrenciNo",
                table: "kurs",
                column: "OgrenciNo");

            migrationBuilder.CreateIndex(
                name: "IX_borcs_KurId",
                table: "borcs",
                column: "KurId");

            migrationBuilder.CreateIndex(
                name: "IX_borcs_OgrenciNo1",
                table: "borcs",
                column: "OgrenciNo1");

            migrationBuilder.CreateIndex(
                name: "IX_borcs_Veli_Id",
                table: "borcs",
                column: "Veli_Id");

            migrationBuilder.CreateIndex(
                name: "IX_devamsızlıks_OgrenciNo1",
                table: "devamsızlıks",
                column: "OgrenciNo1");

            migrationBuilder.CreateIndex(
                name: "IX_KurOgrencis_Kur_Id",
                table: "KurOgrencis",
                column: "Kur_Id");

            migrationBuilder.CreateIndex(
                name: "IX_KurOgrencis_Ogrenci_Id",
                table: "KurOgrencis",
                column: "Ogrenci_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_kurs_ogrencis_OgrenciNo",
                table: "kurs",
                column: "OgrenciNo",
                principalTable: "ogrencis",
                principalColumn: "OgrenciNo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_odemelers_velis_Veli_Id",
                table: "odemelers",
                column: "Veli_Id",
                principalTable: "velis",
                principalColumn: "Veli_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_odemelers_bankas_banka_Id",
                table: "odemelers",
                column: "banka_Id",
                principalTable: "bankas",
                principalColumn: "banka_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OdemeTurleris_ındırımOranlarıs_IndırımOranlarıID",
                table: "OdemeTurleris",
                column: "IndırımOranlarıID",
                principalTable: "ındırımOranlarıs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_kurs_ogrencis_OgrenciNo",
                table: "kurs");

            migrationBuilder.DropForeignKey(
                name: "FK_odemelers_velis_Veli_Id",
                table: "odemelers");

            migrationBuilder.DropForeignKey(
                name: "FK_odemelers_bankas_banka_Id",
                table: "odemelers");

            migrationBuilder.DropForeignKey(
                name: "FK_OdemeTurleris_ındırımOranlarıs_IndırımOranlarıID",
                table: "OdemeTurleris");

            migrationBuilder.DropTable(
                name: "borcs");

            migrationBuilder.DropTable(
                name: "devamsızlıks");

            migrationBuilder.DropTable(
                name: "ındırımOranlarıs");

            migrationBuilder.DropTable(
                name: "KurOgrencis");

            migrationBuilder.DropIndex(
                name: "IX_OdemeTurleris_IndırımOranlarıID",
                table: "OdemeTurleris");

            migrationBuilder.DropIndex(
                name: "IX_odemelers_Veli_Id",
                table: "odemelers");

            migrationBuilder.DropIndex(
                name: "IX_kurs_OgrenciNo",
                table: "kurs");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "OdemeTurleris");

            migrationBuilder.DropColumn(
                name: "IndırımOranlarıID",
                table: "OdemeTurleris");

            migrationBuilder.DropColumn(
                name: "KurId",
                table: "odemelers");

            migrationBuilder.DropColumn(
                name: "bakiye",
                table: "odemelers");

            migrationBuilder.DropColumn(
                name: "borçTutarı",
                table: "odemelers");

            migrationBuilder.DropColumn(
                name: "kalanOdemeMiktari",
                table: "odemelers");

            migrationBuilder.DropColumn(
                name: "taksit_sayısı",
                table: "odemelers");

            migrationBuilder.DropColumn(
                name: "KurBitiş",
                table: "kurs");

            migrationBuilder.DropColumn(
                name: "OgrenciNo",
                table: "kurs");

            migrationBuilder.DropColumn(
                name: "kurucreti",
                table: "kurs");

            migrationBuilder.DropColumn(
                name: "süre",
                table: "kurs");

            migrationBuilder.RenameColumn(
                name: "banka_Id",
                table: "odemelers",
                newName: "Banka_Id");

            migrationBuilder.RenameIndex(
                name: "IX_odemelers_banka_Id",
                table: "odemelers",
                newName: "IX_odemelers_Banka_Id");

            migrationBuilder.AlterColumn<int>(
                name: "Banka_Id",
                table: "odemelers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VelisVeli_Id",
                table: "odemelers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BitisZamani",
                table: "kurs",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Ogrenci_Id",
                table: "kurs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_odemelers_VelisVeli_Id",
                table: "odemelers",
                column: "VelisVeli_Id");

            migrationBuilder.CreateIndex(
                name: "IX_kurs_Ogrenci_Id",
                table: "kurs",
                column: "Ogrenci_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_kurs_ogrencis_Ogrenci_Id",
                table: "kurs",
                column: "Ogrenci_Id",
                principalTable: "ogrencis",
                principalColumn: "OgrenciNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_odemelers_bankas_Banka_Id",
                table: "odemelers",
                column: "Banka_Id",
                principalTable: "bankas",
                principalColumn: "banka_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_odemelers_velis_VelisVeli_Id",
                table: "odemelers",
                column: "VelisVeli_Id",
                principalTable: "velis",
                principalColumn: "Veli_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
