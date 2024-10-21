using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Catalogo.Infrastructure.Mappings
{
    public class CategoriaMapping : IEntityTypeConfiguration<Domain.Categoria>
    {
        public void Configure(EntityTypeBuilder<Domain.Categoria> builder)
        {

            builder.HasKey(c => c.Id);

            builder.Property(c => c.DataCriacao).HasColumnType("datetime").HasColumnName("DataCriacao");
            builder.Property(c => c.DataAtualizacao).HasColumnType("datetime").HasColumnName("DataAtualizacao");

            builder.Property(c => c.Nome)
                .HasColumnType("varchar(50)")
                .HasColumnName("Nome");

            // 1 : N => Categorias : Produtos
            builder.HasMany(c => c.Produtos)
                .WithOne(p => p.Categoria)
                .HasForeignKey(p => p.IdCategoria);

            // 1 : N => Categorias : Servicos
            builder.HasMany(c => c.Servicos)
                .WithOne(s => s.Categoria)
                .HasForeignKey(s => s.IdCategoria);

            builder.ToTable("Categoria");
        }
    }
}
