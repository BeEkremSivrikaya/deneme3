﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using deneme3.Models;

namespace deneme3.Migrations
{
    [DbContext(typeof(Context1))]
    [Migration("20221219211327_kullanıcı-sube-v1")]
    partial class kullanıcısubev1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("EntityLayer.Tables.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Kullanici")
                        .HasColumnType("text");

                    b.Property<string>("Personel_Sube_Adı")
                        .HasColumnType("text");

                    b.Property<string>("Rol")
                        .HasColumnType("text");

                    b.Property<int>("Sifre")
                        .HasColumnType("integer");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("EntityLayer.Tables.Banka", b =>
                {
                    b.Property<int>("banka_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Banka_Adi")
                        .HasColumnType("text");

                    b.HasKey("banka_Id");

                    b.ToTable("bankas");
                });

            modelBuilder.Entity("EntityLayer.Tables.Fatura", b =>
                {
                    b.Property<int>("fatura_no")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Birey_Adi")
                        .HasColumnType("text");

                    b.Property<string>("Birey_Soyadi")
                        .HasColumnType("text");

                    b.Property<string>("Birey_Tc")
                        .HasColumnType("text");

                    b.Property<DateTime>("Fatura_Tarihi")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Fatura_Tipi")
                        .HasColumnType("text");

                    b.Property<string>("Firma_Adi")
                        .HasColumnType("text");

                    b.Property<int>("Islem_No")
                        .HasColumnType("integer");

                    b.Property<int>("Islem_Tutarı")
                        .HasColumnType("integer");

                    b.Property<int>("Kdv_Oranı")
                        .HasColumnType("integer");

                    b.Property<int>("Onay_Kodu")
                        .HasColumnType("integer");

                    b.Property<string>("Seri_No")
                        .HasColumnType("text");

                    b.Property<int>("Sube_No")
                        .HasColumnType("integer");

                    b.Property<int>("Sıra_No")
                        .HasColumnType("integer");

                    b.Property<int>("Toplam_Tutar")
                        .HasColumnType("integer");

                    b.Property<string>("Vergi_Dairesi_Adi")
                        .HasColumnType("text");

                    b.Property<string>("Vergi_No")
                        .HasColumnType("text");

                    b.HasKey("fatura_no");

                    b.ToTable("fatura");
                });

            modelBuilder.Entity("EntityLayer.Tables.FaturaOdemeler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("Sube_Id")
                        .HasColumnType("integer");

                    b.Property<int>("fatura_no")
                        .HasColumnType("integer");

                    b.Property<int>("odeme_no")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Sube_Id");

                    b.HasIndex("fatura_no");

                    b.HasIndex("odeme_no");

                    b.ToTable("faturaOdemelers");
                });

            modelBuilder.Entity("EntityLayer.Tables.GiderTurleri", b =>
                {
                    b.Property<int>("giderTuruKodu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("gideradi")
                        .HasColumnType("text");

                    b.HasKey("giderTuruKodu");

                    b.ToTable("giderturleris");
                });

            modelBuilder.Entity("EntityLayer.Tables.Giderler", b =>
                {
                    b.Property<int>("gdr_No")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("GiderTuruKodu")
                        .HasColumnType("integer");

                    b.Property<int>("Sube_Id")
                        .HasColumnType("integer");

                    b.Property<int?>("SubesSube_Id")
                        .HasColumnType("integer");

                    b.Property<int>("Tutar")
                        .HasColumnType("integer");

                    b.Property<DateTime>("gdr_Tarih")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("gdr_No");

                    b.HasIndex("GiderTuruKodu");

                    b.HasIndex("SubesSube_Id");

                    b.ToTable("giderler");
                });

            modelBuilder.Entity("EntityLayer.Tables.Il", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Ils")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Ils");
                });

            modelBuilder.Entity("EntityLayer.Tables.Ilce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Il_Id")
                        .HasColumnType("integer");

                    b.Property<string>("Ilces")
                        .HasColumnType("text");

                    b.Property<int?>("IlsId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IlsId");

                    b.ToTable("Ilces");
                });

            modelBuilder.Entity("EntityLayer.Tables.Kur", b =>
                {
                    b.Property<int>("KayıtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("BaslangicZamani")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("BitisZamani")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Durum")
                        .HasColumnType("boolean");

                    b.Property<string>("KurAdi")
                        .HasColumnType("text");

                    b.Property<int>("KurId")
                        .HasColumnType("integer");

                    b.Property<int>("Ogrenci_Id")
                        .HasColumnType("integer");

                    b.Property<int>("YasId")
                        .HasColumnType("integer");

                    b.HasKey("KayıtId");

                    b.HasIndex("Ogrenci_Id");

                    b.HasIndex("YasId");

                    b.ToTable("kurs");
                });

            modelBuilder.Entity("EntityLayer.Tables.OdemeTurleri", b =>
                {
                    b.Property<int>("odemeTur_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("OdemeTurAdi")
                        .HasColumnType("text");

                    b.HasKey("odemeTur_Id");

                    b.ToTable("OdemeTurleris");
                });

            modelBuilder.Entity("EntityLayer.Tables.Odemeler", b =>
                {
                    b.Property<int>("odeme_no")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Banka_Id")
                        .HasColumnType("integer");

                    b.Property<int>("Veli_Id")
                        .HasColumnType("integer");

                    b.Property<int?>("VelisVeli_Id")
                        .HasColumnType("integer");

                    b.Property<int>("odemeTur_Id")
                        .HasColumnType("integer");

                    b.Property<int>("odeme_Tutar")
                        .HasColumnType("integer");

                    b.Property<DateTime>("odeme_tarih")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("odeme_no");

                    b.HasIndex("Banka_Id");

                    b.HasIndex("VelisVeli_Id");

                    b.HasIndex("odemeTur_Id");

                    b.ToTable("odemelers");
                });

            modelBuilder.Entity("EntityLayer.Tables.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CepNo")
                        .HasColumnType("text");

                    b.Property<string>("Cinsiyet")
                        .HasColumnType("text");

                    b.Property<string>("CozulmusOgrenciAdi")
                        .HasColumnType("text");

                    b.Property<string>("CozulmusOgrenciSoyad")
                        .HasColumnType("text");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Durum")
                        .HasColumnType("boolean");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("OgrenciAdi")
                        .HasColumnType("text");

                    b.Property<string>("OgrenciSoyad")
                        .HasColumnType("text");

                    b.Property<int>("StudentGender")
                        .HasColumnType("integer");

                    b.Property<int?>("Sube_Id")
                        .HasColumnType("integer");

                    b.Property<string>("TckimlikNo")
                        .HasColumnType("text");

                    b.Property<int>("Yas")
                        .HasColumnType("integer");

                    b.Property<byte[]>("fotograf")
                        .HasColumnType("bytea");

                    b.HasKey("OgrenciNo");

                    b.HasIndex("Sube_Id");

                    b.ToTable("ogrencis");
                });

            modelBuilder.Entity("EntityLayer.Tables.Ogrenci_detay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("text");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int>("Ogrenci_Id")
                        .HasColumnType("integer");

                    b.Property<string>("Sinif")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Ogrenci_Id");

                    b.ToTable("ogrenci_detays");
                });

            modelBuilder.Entity("EntityLayer.Tables.Personel", b =>
                {
                    b.Property<int>("PersonelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("PersonelAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PersonelSoyadi")
                        .HasColumnType("text");

                    b.Property<int>("Sube_Id")
                        .HasColumnType("integer");

                    b.Property<byte[]>("fotograf")
                        .HasColumnType("bytea");

                    b.HasKey("PersonelId");

                    b.HasIndex("Sube_Id");

                    b.ToTable("personels");
                });

            modelBuilder.Entity("EntityLayer.Tables.Sube", b =>
                {
                    b.Property<int>("Sube_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Il_Id")
                        .HasColumnType("integer");

                    b.Property<string>("Sube_Adres")
                        .HasColumnType("text");

                    b.Property<string>("Sube_Adı")
                        .HasColumnType("text");

                    b.HasKey("Sube_Id");

                    b.HasIndex("Il_Id");

                    b.ToTable("subes");
                });

            modelBuilder.Entity("EntityLayer.Tables.SınavTurleri", b =>
                {
                    b.Property<int>("sinavkodu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("sınavAdi")
                        .HasColumnType("text");

                    b.HasKey("sinavkodu");

                    b.ToTable("sınavkodus");
                });

            modelBuilder.Entity("EntityLayer.Tables.Sınavlar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BasariNotu")
                        .HasColumnType("integer");

                    b.Property<int>("Kur_Id")
                        .HasColumnType("integer");

                    b.Property<int>("Ogrenci_No")
                        .HasColumnType("integer");

                    b.Property<int>("SınavKodu")
                        .HasColumnType("integer");

                    b.Property<int?>("sınavKodusinavkodu")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Kur_Id");

                    b.HasIndex("Ogrenci_No");

                    b.HasIndex("sınavKodusinavkodu");

                    b.ToTable("sınavlars");
                });

            modelBuilder.Entity("EntityLayer.Tables.Veli", b =>
                {
                    b.Property<int>("Veli_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Cepno")
                        .HasColumnType("text");

                    b.Property<string>("Eposta")
                        .HasColumnType("text");

                    b.Property<string>("Meslek")
                        .HasColumnType("text");

                    b.Property<int>("Ogrenci_Id")
                        .HasColumnType("integer");

                    b.Property<string>("TckimlikNo")
                        .HasColumnType("text");

                    b.Property<string>("Veli_Ad")
                        .HasColumnType("text");

                    b.Property<string>("Veli_Soyad")
                        .HasColumnType("text");

                    b.Property<string>("Veli_Tipi")
                        .HasColumnType("text");

                    b.HasKey("Veli_Id");

                    b.HasIndex("Ogrenci_Id");

                    b.ToTable("velis");
                });

            modelBuilder.Entity("EntityLayer.Tables.YasGrubu", b =>
                {
                    b.Property<int>("YasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("YasGrupAdi")
                        .HasColumnType("text");

                    b.HasKey("YasId");

                    b.ToTable("yasGrubus");
                });

            modelBuilder.Entity("EntityLayer.Tables.FaturaOdemeler", b =>
                {
                    b.HasOne("EntityLayer.Tables.Sube", null)
                        .WithMany("FaturaOdemelers")
                        .HasForeignKey("Sube_Id");

                    b.HasOne("EntityLayer.Tables.Fatura", "Fatura")
                        .WithMany("Faturalar_No")
                        .HasForeignKey("fatura_no")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Tables.Odemeler", "Odemeler")
                        .WithMany("Odemeler_No")
                        .HasForeignKey("odeme_no")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Tables.Giderler", b =>
                {
                    b.HasOne("EntityLayer.Tables.GiderTurleri", "GiderTurleri")
                        .WithMany("Giderlers")
                        .HasForeignKey("GiderTuruKodu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Tables.Sube", "Subes")
                        .WithMany("Giderlers")
                        .HasForeignKey("SubesSube_Id");
                });

            modelBuilder.Entity("EntityLayer.Tables.Ilce", b =>
                {
                    b.HasOne("EntityLayer.Tables.Il", "Ils")
                        .WithMany("Ilces")
                        .HasForeignKey("IlsId");
                });

            modelBuilder.Entity("EntityLayer.Tables.Kur", b =>
                {
                    b.HasOne("EntityLayer.Tables.Ogrenci", "Ogrenci")
                        .WithMany("Kurs")
                        .HasForeignKey("Ogrenci_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Tables.YasGrubu", "Yas")
                        .WithMany("Kurs")
                        .HasForeignKey("YasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Tables.Odemeler", b =>
                {
                    b.HasOne("EntityLayer.Tables.Banka", "Banka")
                        .WithMany("Odemelers")
                        .HasForeignKey("Banka_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Tables.Veli", "Velis")
                        .WithMany("Odemelers")
                        .HasForeignKey("VelisVeli_Id");

                    b.HasOne("EntityLayer.Tables.OdemeTurleri", "OdemeTurleri")
                        .WithMany("Odemelers")
                        .HasForeignKey("odemeTur_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Tables.Ogrenci", b =>
                {
                    b.HasOne("EntityLayer.Tables.Sube", null)
                        .WithMany("Ogrencis")
                        .HasForeignKey("Sube_Id");
                });

            modelBuilder.Entity("EntityLayer.Tables.Ogrenci_detay", b =>
                {
                    b.HasOne("EntityLayer.Tables.Ogrenci", "Ogrenci")
                        .WithMany("Ogrenci_detay")
                        .HasForeignKey("Ogrenci_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Tables.Personel", b =>
                {
                    b.HasOne("EntityLayer.Tables.Sube", "Sube")
                        .WithMany("Personels")
                        .HasForeignKey("Sube_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Tables.Sube", b =>
                {
                    b.HasOne("EntityLayer.Tables.Il", "Il")
                        .WithMany("subes")
                        .HasForeignKey("Il_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Tables.Sınavlar", b =>
                {
                    b.HasOne("EntityLayer.Tables.Kur", "Kur")
                        .WithMany()
                        .HasForeignKey("Kur_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Tables.Ogrenci", "Ogrenci")
                        .WithMany("Sınavlars")
                        .HasForeignKey("Ogrenci_No")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Tables.SınavTurleri", "sınavKodu")
                        .WithMany("Sınavlars")
                        .HasForeignKey("sınavKodusinavkodu");
                });

            modelBuilder.Entity("EntityLayer.Tables.Veli", b =>
                {
                    b.HasOne("EntityLayer.Tables.Ogrenci", "Ogrenci")
                        .WithMany("Veli")
                        .HasForeignKey("Ogrenci_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
