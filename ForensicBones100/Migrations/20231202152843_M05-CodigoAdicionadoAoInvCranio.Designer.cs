﻿// <auto-generated />
using System;
using ForensicBones100.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ForensicBones100.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231202152843_M05-CodigoAdicionadoAoInvCranio")]
    partial class M05CodigoAdicionadoAoInvCranio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ForensicBones100.Models.InventarioCranio", b =>
                {
                    b.Property<int>("InventarioCranioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventarioCranioId"));

                    b.Property<int>("CartilagemTireoide")
                        .HasColumnType("int");

                    b.Property<string>("CartilagemTireoideDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("ConchaNasalInferiorDireita")
                        .HasColumnType("int");

                    b.Property<string>("ConchaNasalInferiorDireitaDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("ConchaNasalInferiorEsquerda")
                        .HasColumnType("int");

                    b.Property<string>("ConchaNasalInferiorEsquerdaDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("Esfenoide")
                        .HasColumnType("int");

                    b.Property<string>("EsfenoideDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("Etmoide")
                        .HasColumnType("int");

                    b.Property<string>("EtmoideDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("FotosCranio")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("Frontal")
                        .HasColumnType("int");

                    b.Property<string>("FrontalDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("Hioide")
                        .HasColumnType("int");

                    b.Property<string>("HioideDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("InventarioEsqueletoId")
                        .HasColumnType("int");

                    b.Property<int>("LacrimalDireito")
                        .HasColumnType("int");

                    b.Property<string>("LacrimalDireitoDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("LacrimalEsquerdo")
                        .HasColumnType("int");

                    b.Property<string>("LacrimalEsquerdoDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("Mandibula")
                        .HasColumnType("int");

                    b.Property<string>("MandibulaDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("Maxilar")
                        .HasColumnType("int");

                    b.Property<string>("MaxilarDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("NasalDireito")
                        .HasColumnType("int");

                    b.Property<string>("NasalDireitoDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("NasalEsquerdo")
                        .HasColumnType("int");

                    b.Property<string>("NasalEsquerdoDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Observacoes")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("Ocipital")
                        .HasColumnType("int");

                    b.Property<string>("OcipitalDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("ParietalDireito")
                        .HasColumnType("int");

                    b.Property<string>("ParietalDireitoDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("ParietalEsquerdo")
                        .HasColumnType("int");

                    b.Property<string>("ParietalEsquerdoDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("RelatorioId")
                        .HasColumnType("int");

                    b.Property<int>("TemporalDireito")
                        .HasColumnType("int");

                    b.Property<string>("TemporalDireitoDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("TemporalEsquerdo")
                        .HasColumnType("int");

                    b.Property<string>("TemporalEsquerdoDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("Vomer")
                        .HasColumnType("int");

                    b.Property<string>("VomerDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("ZigomaticoDireito")
                        .HasColumnType("int");

                    b.Property<string>("ZigomaticoDireitoDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("ZigomaticoEsquerdo")
                        .HasColumnType("int");

                    b.Property<string>("ZigomaticoEsquerdoDesc")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("InventarioCranioId");

                    b.HasIndex("InventarioEsqueletoId");

                    b.HasIndex("RelatorioId");

                    b.ToTable("InventarioCranio");
                });

            modelBuilder.Entity("ForensicBones100.Models.InventarioEsqueleto", b =>
                {
                    b.Property<int>("InventarioEsqueletoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventarioEsqueletoId"));

                    b.Property<string>("FotoEsqueleto")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("ObservacoesEsq")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("RelatorioId")
                        .HasColumnType("int");

                    b.HasKey("InventarioEsqueletoId");

                    b.HasIndex("RelatorioId");

                    b.ToTable("InventariosEsqueleto");
                });

            modelBuilder.Entity("ForensicBones100.Models.MarcadoresCranio", b =>
                {
                    b.Property<int>("MarcadoresCranioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarcadoresCranioId"));

                    b.Property<string>("AreaGlabela")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("CalculoEstimativaSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("CristaNucal")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("EminenciaMentoniana")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("InventarioCranioId")
                        .HasColumnType("int");

                    b.Property<string>("Observacoes")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("ProcessoMastoide")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int?>("RelatorioId")
                        .HasColumnType("int");

                    b.Property<string>("SupraOrbital")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("MarcadoresCranioId");

                    b.HasIndex("InventarioCranioId");

                    b.HasIndex("RelatorioId");

                    b.ToTable("MarcadoresCranio");
                });

            modelBuilder.Entity("ForensicBones100.Models.Relatorio", b =>
                {
                    b.Property<int>("RelatorioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RelatorioId"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observacoes")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("RelatorioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Relatorios");
                });

            modelBuilder.Entity("ForensicBones100.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Cargo")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ForensicBones100.Models.InventarioCranio", b =>
                {
                    b.HasOne("ForensicBones100.Models.InventarioEsqueleto", "InventarioEsqueleto")
                        .WithMany("InventarioCranio")
                        .HasForeignKey("InventarioEsqueletoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForensicBones100.Models.Relatorio", "Relatorio")
                        .WithMany("InventarioCranio")
                        .HasForeignKey("RelatorioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InventarioEsqueleto");

                    b.Navigation("Relatorio");
                });

            modelBuilder.Entity("ForensicBones100.Models.InventarioEsqueleto", b =>
                {
                    b.HasOne("ForensicBones100.Models.Relatorio", "Relatorio")
                        .WithMany("InventariosEsqueleto")
                        .HasForeignKey("RelatorioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Relatorio");
                });

            modelBuilder.Entity("ForensicBones100.Models.MarcadoresCranio", b =>
                {
                    b.HasOne("ForensicBones100.Models.InventarioCranio", "InventarioCranio")
                        .WithMany("MarcadoresCranio")
                        .HasForeignKey("InventarioCranioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForensicBones100.Models.Relatorio", "Relatorio")
                        .WithMany("MarcadoresCranio")
                        .HasForeignKey("RelatorioId");

                    b.Navigation("InventarioCranio");

                    b.Navigation("Relatorio");
                });

            modelBuilder.Entity("ForensicBones100.Models.Relatorio", b =>
                {
                    b.HasOne("ForensicBones100.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ForensicBones100.Models.InventarioCranio", b =>
                {
                    b.Navigation("MarcadoresCranio");
                });

            modelBuilder.Entity("ForensicBones100.Models.InventarioEsqueleto", b =>
                {
                    b.Navigation("InventarioCranio");
                });

            modelBuilder.Entity("ForensicBones100.Models.Relatorio", b =>
                {
                    b.Navigation("InventarioCranio");

                    b.Navigation("InventariosEsqueleto");

                    b.Navigation("MarcadoresCranio");
                });
#pragma warning restore 612, 618
        }
    }
}
