using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace deneme3.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bankas",
                columns: table => new
                {
                    banka_Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Banka_Adi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bankas", x => x.banka_Id);
                });

            migrationBuilder.CreateTable(
                name: "fatura",
                columns: table => new
                {
                    fatura_no = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Vergi_No = table.Column<string>(nullable: true),
                    Vergi_Dairesi_Adi = table.Column<string>(nullable: true),
                    Seri_No = table.Column<string>(nullable: true),
                    Sıra_No = table.Column<int>(nullable: false),
                    Sube_No = table.Column<int>(nullable: false),
                    Islem_Tutarı = table.Column<int>(nullable: false),
                    Kdv_Oranı = table.Column<int>(nullable: false),
                    Toplam_Tutar = table.Column<int>(nullable: false),
                    Islem_No = table.Column<int>(nullable: false),
                    Fatura_Tarihi = table.Column<DateTime>(nullable: false),
                    Onay_Kodu = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fatura", x => x.fatura_no);
                });

            migrationBuilder.CreateTable(
                name: "giderturleris",
                columns: table => new
                {
                    giderTuruKodu = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    gideradi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_giderturleris", x => x.giderTuruKodu);
                });

            migrationBuilder.CreateTable(
                name: "Ils",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ils = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OdemeTurleris",
                columns: table => new
                {
                    odemeTur_Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OdemeTurAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdemeTurleris", x => x.odemeTur_Id);
                });

            migrationBuilder.CreateTable(
                name: "sınavkodus",
                columns: table => new
                {
                    sinavkodu = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sınavAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sınavkodus", x => x.sinavkodu);
                });

            migrationBuilder.CreateTable(
                name: "yasGrubus",
                columns: table => new
                {
                    YasId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    YasGrupAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yasGrubus", x => x.YasId);
                });

            migrationBuilder.CreateTable(
                name: "Ilces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ilces = table.Column<string>(nullable: true),
                    Il_Id = table.Column<int>(nullable: false),
                    IlsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ilces_Ils_IlsId",
                        column: x => x.IlsId,
                        principalTable: "Ils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "subes",
                columns: table => new
                {
                    Sube_Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Sube_Adı = table.Column<string>(nullable: true),
                    Sube_Adres = table.Column<string>(nullable: true),
                    Il_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subes", x => x.Sube_Id);
                    table.ForeignKey(
                        name: "FK_subes_Ils_Il_Id",
                        column: x => x.Il_Id,
                        principalTable: "Ils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "giderler",
                columns: table => new
                {
                    gdr_No = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GiderTuruKodu = table.Column<int>(nullable: false),
                    Tutar = table.Column<int>(nullable: false),
                    gdr_Tarih = table.Column<DateTime>(nullable: false),
                    Sube_Id = table.Column<int>(nullable: false),
                    SubesSube_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_giderler", x => x.gdr_No);
                    table.ForeignKey(
                        name: "FK_giderler_giderturleris_GiderTuruKodu",
                        column: x => x.GiderTuruKodu,
                        principalTable: "giderturleris",
                        principalColumn: "giderTuruKodu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_giderler_subes_SubesSube_Id",
                        column: x => x.SubesSube_Id,
                        principalTable: "subes",
                        principalColumn: "Sube_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ogrencis",
                columns: table => new
                {
                    OgrenciNo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OgrenciAdi = table.Column<string>(nullable: true),
                    TckimlikNo = table.Column<string>(nullable: true),
                    fotograf = table.Column<byte[]>(nullable: true),
                    OgrenciSoyad = table.Column<string>(nullable: true),
                    Cinsiyet = table.Column<string>(nullable: true),
                    CepNo = table.Column<string>(nullable: true),
                    Durum = table.Column<bool>(nullable: false),
                    DogumTarihi = table.Column<DateTime>(nullable: false),
                    Sube_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ogrencis", x => x.OgrenciNo);
                    table.ForeignKey(
                        name: "FK_ogrencis_subes_Sube_Id",
                        column: x => x.Sube_Id,
                        principalTable: "subes",
                        principalColumn: "Sube_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "personels",
                columns: table => new
                {
                    PersonelId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonelAdi = table.Column<string>(nullable: false),
                    PersonelSoyadi = table.Column<string>(nullable: true),
                    fotograf = table.Column<byte[]>(nullable: true),
                    Sube_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personels", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_personels_subes_Sube_Id",
                        column: x => x.Sube_Id,
                        principalTable: "subes",
                        principalColumn: "Sube_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "kurs",
                columns: table => new
                {
                    KayıtId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KurId = table.Column<int>(nullable: false),
                    KurAdi = table.Column<string>(nullable: true),
                    Ogrenci_Id = table.Column<int>(nullable: false),
                    Durum = table.Column<bool>(nullable: false),
                    BaslangicZamani = table.Column<DateTime>(nullable: false),
                    BitisZamani = table.Column<DateTime>(nullable: false),
                    YasId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kurs", x => x.KayıtId);
                    table.ForeignKey(
                        name: "FK_kurs_ogrencis_Ogrenci_Id",
                        column: x => x.Ogrenci_Id,
                        principalTable: "ogrencis",
                        principalColumn: "OgrenciNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kurs_yasGrubus_YasId",
                        column: x => x.YasId,
                        principalTable: "yasGrubus",
                        principalColumn: "YasId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ogrenci_detays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Sinif = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<DateTime>(nullable: false),
                    Adres = table.Column<string>(nullable: true),
                    Ogrenci_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ogrenci_detays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ogrenci_detays_ogrencis_Ogrenci_Id",
                        column: x => x.Ogrenci_Id,
                        principalTable: "ogrencis",
                        principalColumn: "OgrenciNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "velis",
                columns: table => new
                {
                    Veli_Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TckimlikNo = table.Column<string>(nullable: true),
                    Veli_Ad = table.Column<string>(nullable: true),
                    Veli_Soyad = table.Column<string>(nullable: true),
                    Meslek = table.Column<string>(nullable: true),
                    Cepno = table.Column<string>(nullable: true),
                    Eposta = table.Column<string>(nullable: true),
                    Ogrenci_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_velis", x => x.Veli_Id);
                    table.ForeignKey(
                        name: "FK_velis_ogrencis_Ogrenci_Id",
                        column: x => x.Ogrenci_Id,
                        principalTable: "ogrencis",
                        principalColumn: "OgrenciNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sınavlars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ogrenci_No = table.Column<int>(nullable: false),
                    Kur_Id = table.Column<int>(nullable: false),
                    SınavKodu = table.Column<int>(nullable: false),
                    sınavKodusinavkodu = table.Column<int>(nullable: true),
                    BasariNotu = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sınavlars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sınavlars_kurs_Kur_Id",
                        column: x => x.Kur_Id,
                        principalTable: "kurs",
                        principalColumn: "KayıtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sınavlars_ogrencis_Ogrenci_No",
                        column: x => x.Ogrenci_No,
                        principalTable: "ogrencis",
                        principalColumn: "OgrenciNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sınavlars_sınavkodus_sınavKodusinavkodu",
                        column: x => x.sınavKodusinavkodu,
                        principalTable: "sınavkodus",
                        principalColumn: "sinavkodu",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "odemelers",
                columns: table => new
                {
                    odeme_no = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    odemeTur_Id = table.Column<int>(nullable: false),
                    Veli_Id = table.Column<int>(nullable: false),
                    VelisVeli_Id = table.Column<int>(nullable: true),
                    Banka_Id = table.Column<int>(nullable: false),
                    odeme_tarih = table.Column<DateTime>(nullable: false),
                    odeme_Tutar = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_odemelers", x => x.odeme_no);
                    table.ForeignKey(
                        name: "FK_odemelers_bankas_Banka_Id",
                        column: x => x.Banka_Id,
                        principalTable: "bankas",
                        principalColumn: "banka_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_odemelers_velis_VelisVeli_Id",
                        column: x => x.VelisVeli_Id,
                        principalTable: "velis",
                        principalColumn: "Veli_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_odemelers_OdemeTurleris_odemeTur_Id",
                        column: x => x.odemeTur_Id,
                        principalTable: "OdemeTurleris",
                        principalColumn: "odemeTur_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "faturaOdemelers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    odeme_no = table.Column<int>(nullable: false),
                    fatura_no = table.Column<int>(nullable: false),
                    Sube_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faturaOdemelers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_faturaOdemelers_subes_Sube_Id",
                        column: x => x.Sube_Id,
                        principalTable: "subes",
                        principalColumn: "Sube_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_faturaOdemelers_fatura_fatura_no",
                        column: x => x.fatura_no,
                        principalTable: "fatura",
                        principalColumn: "fatura_no",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_faturaOdemelers_odemelers_odeme_no",
                        column: x => x.odeme_no,
                        principalTable: "odemelers",
                        principalColumn: "odeme_no",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_faturaOdemelers_Sube_Id",
                table: "faturaOdemelers",
                column: "Sube_Id");

            migrationBuilder.CreateIndex(
                name: "IX_faturaOdemelers_fatura_no",
                table: "faturaOdemelers",
                column: "fatura_no");

            migrationBuilder.CreateIndex(
                name: "IX_faturaOdemelers_odeme_no",
                table: "faturaOdemelers",
                column: "odeme_no");

            migrationBuilder.CreateIndex(
                name: "IX_giderler_GiderTuruKodu",
                table: "giderler",
                column: "GiderTuruKodu");

            migrationBuilder.CreateIndex(
                name: "IX_giderler_SubesSube_Id",
                table: "giderler",
                column: "SubesSube_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ilces_IlsId",
                table: "Ilces",
                column: "IlsId");

            migrationBuilder.CreateIndex(
                name: "IX_kurs_Ogrenci_Id",
                table: "kurs",
                column: "Ogrenci_Id");

            migrationBuilder.CreateIndex(
                name: "IX_kurs_YasId",
                table: "kurs",
                column: "YasId");

            migrationBuilder.CreateIndex(
                name: "IX_odemelers_Banka_Id",
                table: "odemelers",
                column: "Banka_Id");

            migrationBuilder.CreateIndex(
                name: "IX_odemelers_VelisVeli_Id",
                table: "odemelers",
                column: "VelisVeli_Id");

            migrationBuilder.CreateIndex(
                name: "IX_odemelers_odemeTur_Id",
                table: "odemelers",
                column: "odemeTur_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ogrenci_detays_Ogrenci_Id",
                table: "ogrenci_detays",
                column: "Ogrenci_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ogrencis_Sube_Id",
                table: "ogrencis",
                column: "Sube_Id");

            migrationBuilder.CreateIndex(
                name: "IX_personels_Sube_Id",
                table: "personels",
                column: "Sube_Id");

            migrationBuilder.CreateIndex(
                name: "IX_sınavlars_Kur_Id",
                table: "sınavlars",
                column: "Kur_Id");

            migrationBuilder.CreateIndex(
                name: "IX_sınavlars_Ogrenci_No",
                table: "sınavlars",
                column: "Ogrenci_No");

            migrationBuilder.CreateIndex(
                name: "IX_sınavlars_sınavKodusinavkodu",
                table: "sınavlars",
                column: "sınavKodusinavkodu");

            migrationBuilder.CreateIndex(
                name: "IX_subes_Il_Id",
                table: "subes",
                column: "Il_Id");

            migrationBuilder.CreateIndex(
                name: "IX_velis_Ogrenci_Id",
                table: "velis",
                column: "Ogrenci_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "faturaOdemelers");

            migrationBuilder.DropTable(
                name: "giderler");

            migrationBuilder.DropTable(
                name: "Ilces");

            migrationBuilder.DropTable(
                name: "ogrenci_detays");

            migrationBuilder.DropTable(
                name: "personels");

            migrationBuilder.DropTable(
                name: "sınavlars");

            migrationBuilder.DropTable(
                name: "fatura");

            migrationBuilder.DropTable(
                name: "odemelers");

            migrationBuilder.DropTable(
                name: "giderturleris");

            migrationBuilder.DropTable(
                name: "kurs");

            migrationBuilder.DropTable(
                name: "sınavkodus");

            migrationBuilder.DropTable(
                name: "bankas");

            migrationBuilder.DropTable(
                name: "velis");

            migrationBuilder.DropTable(
                name: "OdemeTurleris");

            migrationBuilder.DropTable(
                name: "yasGrubus");

            migrationBuilder.DropTable(
                name: "ogrencis");

            migrationBuilder.DropTable(
                name: "subes");

            migrationBuilder.DropTable(
                name: "Ils");
        }
    }
}
