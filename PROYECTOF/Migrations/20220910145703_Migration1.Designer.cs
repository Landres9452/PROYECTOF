// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROYECTOF.Data;

#nullable disable

namespace PROYECTOF.Migrations
{
    [DbContext(typeof(PROYECTOFDBContext))]
    [Migration("20220910145703_Migration1")]
    partial class Migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PROYECTOF.Models.Administrador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("identificacion")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("PROYECTOF.Models.Vendedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdministradorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("identificacion")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdministradorId");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("PROYECTOF.Models.Vendedor", b =>
                {
                    b.HasOne("PROYECTOF.Models.Administrador", "Administrador")
                        .WithMany("Vendedores")
                        .HasForeignKey("AdministradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administrador");
                });

            modelBuilder.Entity("PROYECTOF.Models.Administrador", b =>
                {
                    b.Navigation("Vendedores");
                });
#pragma warning restore 612, 618
        }
    }
}
