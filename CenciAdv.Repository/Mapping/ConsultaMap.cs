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
    internal class ConsultaMap: IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.ToTable("Consulta");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Data)
                .IsRequired()
                .HasColumnType("DateTime");


            builder.HasOne(prop => prop.Advogado);

            builder.HasOne(prop => prop.Cliente);
        }
    }
}
