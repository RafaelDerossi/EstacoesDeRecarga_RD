using EstacaoDeRecarga.Dominio.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstacaoDeRecarga.Infra.Dados.Mapeamentos
{
    public class MapEstacaoRecarga : IEntityTypeConfiguration<EstacaoRecarga>
    {
        public void Configure(EntityTypeBuilder<EstacaoRecarga> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Nome)
                .HasColumnType("varchar(300)")
                .HasMaxLength(300)
                .IsRequired();

            builder.Property(c => c.Tipo)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Latitude)
               .HasColumnType("decimal(14,7)")               
               .IsRequired();

            builder.Property(c => c.Longitude)
               .HasColumnType("decimal(14,7)")
               .IsRequired();
        }
    }
}
