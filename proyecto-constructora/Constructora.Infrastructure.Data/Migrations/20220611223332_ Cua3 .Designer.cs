﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proyecto_constructora_web.Model;

#nullable disable

namespace proyecto_constructora_web.Migrations
{
    [DbContext(typeof(ConstructoraDbcontex))]
    [Migration("20220611223332_ Cua3 ")]
    partial class Cua3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("proyecto_constructora_web.Model.Ciudad", b =>
                {
                    b.Property<int>("CiudadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CiudadId"), 1L, 1);

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CiudadId");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("ciudades");
                });

            modelBuilder.Entity("proyecto_constructora_web.Model.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cedula_Nit")
                        .HasColumnType("int");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatriculaProfesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroCelular")
                        .HasColumnType("int");

                    b.Property<string>("Profesion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoClienteId")
                        .HasColumnType("int");

                    b.HasKey("ClienteId");

                    b.HasIndex("TipoClienteId");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("proyecto_constructora_web.Model.CuentasporCobrar", b =>
                {
                    b.Property<int>("CuentasporCobrarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CuentasporCobrarId"), 1L, 1);

                    b.Property<int>("Abono")
                        .HasColumnType("int");

                    b.Property<int>("Contrato")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Saldo")
                        .HasColumnType("int");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("CuentasporCobrarId");

                    b.ToTable("cuentasporCobrar");
                });

            modelBuilder.Entity("proyecto_constructora_web.Model.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartamentoId"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartamentoId");

                    b.ToTable("departamentos");
                });

            modelBuilder.Entity("proyecto_constructora_web.Model.Proyecto", b =>
                {
                    b.Property<int>("ProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProyectoId"), 1L, 1);

                    b.Property<int>("CiudadId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NroContrato")
                        .HasColumnType("int");

                    b.Property<int>("TipoObraId")
                        .HasColumnType("int");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("ProyectoId");

                    b.HasIndex("CiudadId");

                    b.HasIndex("TipoObraId");

                    b.ToTable("proyectos");
                });

            modelBuilder.Entity("proyecto_constructora_web.Model.TipoDeCliente", b =>
                {
                    b.Property<int>("TipoClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoClienteId"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoClienteId");

                    b.ToTable("tipoClientes");
                });

            modelBuilder.Entity("proyecto_constructora_web.Model.TipodeObra", b =>
                {
                    b.Property<int>("TipodeObraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipodeObraId"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipodeObraId");

                    b.ToTable("tipoObra");
                });

            modelBuilder.Entity("proyecto_constructora_web.Model.Ciudad", b =>
                {
                    b.HasOne("proyecto_constructora_web.Model.Departamento", "Departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("proyecto_constructora_web.Model.Cliente", b =>
                {
                    b.HasOne("proyecto_constructora_web.Model.TipoDeCliente", "TipoCliente")
                        .WithMany()
                        .HasForeignKey("TipoClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoCliente");
                });

            modelBuilder.Entity("proyecto_constructora_web.Model.Proyecto", b =>
                {
                    b.HasOne("proyecto_constructora_web.Model.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proyecto_constructora_web.Model.TipodeObra", "TipoObra")
                        .WithMany()
                        .HasForeignKey("TipoObraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");

                    b.Navigation("TipoObra");
                });
#pragma warning restore 612, 618
        }
    }
}
