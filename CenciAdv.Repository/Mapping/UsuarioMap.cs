﻿using CenciAdv.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CenciAdv.Repository.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Advogado");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasConversion(prop => prop!.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Senha)
                .IsRequired()
                .HasColumnType("varchar(100)");
            
            builder.Property(prop => prop.Login)
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.DataCadastro)
                .HasDefaultValue(DateTime.Now);

            builder.Property(prop => prop.DataLogin);
                

            builder.Property(prop => prop.Ativo);
        }

    }
}
