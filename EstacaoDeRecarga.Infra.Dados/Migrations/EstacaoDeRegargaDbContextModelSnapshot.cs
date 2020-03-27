﻿// <auto-generated />
using System;
using EstacaoDeRecarga.Infra.Dados.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EstacaoDeRecarga.Infra.Dados.Migrations
{
    [DbContext(typeof(EstacaoDeRegargaDbContext))]
    partial class EstacaoDeRegargaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EstacaoDeRecarga.Dominio.Modelos.EstacaoRecarga", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(14,7)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(14,7)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("EstacaoRecarga");
                });
#pragma warning restore 612, 618
        }
    }
}
