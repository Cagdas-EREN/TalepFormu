// <auto-generated />
using System;
using DataAccess.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(BasvuruContext))]
    [Migration("20230301103831_mig_remove_identity")]
    partial class migremoveidentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Entities.Concrete.AbonelikTuru", b =>
                {
                    b.Property<int>("AboneTurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AboneTurId"));

                    b.Property<string>("AboneTuru")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AboneTurId");

                    b.ToTable("AbonelikTurus");
                });

            modelBuilder.Entity("Entities.Concrete.Cadde", b =>
                {
                    b.Property<int>("CaddeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CaddeId"));

                    b.Property<string>("CaddeAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MahalleId")
                        .HasColumnType("integer");

                    b.HasKey("CaddeId");

                    b.ToTable("Caddes");
                });

            modelBuilder.Entity("Entities.Concrete.Il", b =>
                {
                    b.Property<int>("IlId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IlId"));

                    b.Property<string>("aciklama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("plaka_kodu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IlId");

                    b.ToTable("Ils");
                });

            modelBuilder.Entity("Entities.Concrete.Ilce", b =>
                {
                    b.Property<int>("IlceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IlceId"));

                    b.Property<int>("IlId")
                        .HasColumnType("integer");

                    b.Property<string>("IlceAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IlceId");

                    b.ToTable("Ilces");
                });

            modelBuilder.Entity("Entities.Concrete.KisiselBilgiler", b =>
                {
                    b.Property<int>("BilgilerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BilgilerId"));

                    b.Property<int>("AboneTurId")
                        .HasColumnType("integer");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AnneAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("BabaAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CaddeId")
                        .HasColumnType("integer");

                    b.Property<string>("DisKapiNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirmaAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GüvenlikKelimesi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IcKapiNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("IlId")
                        .HasColumnType("integer");

                    b.Property<int>("IlceId")
                        .HasColumnType("integer");

                    b.Property<string>("KimlikSeriNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MahalleId")
                        .HasColumnType("integer");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MeslekId")
                        .HasColumnType("integer");

                    b.Property<int>("NumaraId")
                        .HasColumnType("integer");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TCNO")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VergiDairesi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VergiNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("BilgilerId");

                    b.ToTable("KisiselBilgilers");
                });

            modelBuilder.Entity("Entities.Concrete.Mahalle", b =>
                {
                    b.Property<int>("MahalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MahalleId"));

                    b.Property<int>("IlceId")
                        .HasColumnType("integer");

                    b.Property<string>("MahalleAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("MahalleId");

                    b.ToTable("Mahalles");
                });

            modelBuilder.Entity("Entities.Concrete.MeslekKodlari", b =>
                {
                    b.Property<int>("MeslekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MeslekId"));

                    b.Property<string>("MeslekAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MeslekKodu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("MeslekId");

                    b.ToTable("MeslekKodlaris");
                });

            modelBuilder.Entity("Entities.Concrete.Numaralar", b =>
                {
                    b.Property<int>("NumaraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("NumaraId"));

                    b.Property<string>("NumaraNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ozelnumara")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("tahsisedildi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("NumaraId");

                    b.ToTable("Numaralars");
                });
#pragma warning restore 612, 618
        }
    }
}
