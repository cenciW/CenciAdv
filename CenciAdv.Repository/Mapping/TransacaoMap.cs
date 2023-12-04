using CenciAdv.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenciAdv.Repository.Mapping
{
    public class TransacaoMap : IEntityTypeConfiguration<Transacao>
    {
        public void Configure(EntityTypeBuilder<Transacao> builder)
        {
            builder.ToTable("Transacao");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Valor)
                .IsRequired()
                .HasColumnName("Valor")
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.DataTransacao)
                .IsRequired()
                .HasColumnType("DateTime");

            builder.Property(prop => prop.DescricaoTransacao)
                .IsRequired()
                .HasColumnName("DescricaoTransacao")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.TipoTransacao)
                .IsRequired()
                .HasColumnType("tinyint");


            builder.HasOne(prop => prop.Advogado);
            builder.HasOne(prop => prop.ClassificacaoTransacao);
        }
    }
}
