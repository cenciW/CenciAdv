using CenciAdv.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenciAdv.Repository.Mapping
{
    public class ClassificacaoTransacaoMap : IEntityTypeConfiguration<ClassificacaoTransacao>
    {
        public void Configure(EntityTypeBuilder<ClassificacaoTransacao> builder)
        {
            builder.ToTable("ClassificacaoTransacao");

            builder.HasKey(prop => prop.Id);


            builder.Property(prop => prop.CodAgrupamento)
                .IsRequired()
                .HasColumnType("varchar(45)");
            
            builder.HasIndex(prop => prop.CodAgrupamento)
                .IsUnique();

            builder.Property(prop => prop.NomeAgrupamento)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Tipo)
                .IsRequired()
                .HasColumnType("tinyint");

        }

    }
}
