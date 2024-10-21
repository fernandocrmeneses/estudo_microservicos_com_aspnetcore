using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Catalogo.Infrastructure.Mappings
{
    public class ProdutosMapping : IEntityTypeConfiguration<Domain.Produtos>
    {
        public void Configure(EntityTypeBuilder<Catalogo.Domain.Produtos> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.DataCriacao).HasColumnType("datetime").HasColumnName("DataCriacao");
            builder.Property(c => c.DataAtualizacao).HasColumnType("datetime").HasColumnName("DataAtualizacao");
            builder.Property(c => c.Nome).HasColumnType("varchar(50)").HasColumnName("Nome");
            builder.Property(c => c.Descricao).HasColumnType("varchar(255)").HasColumnName("Descricao");
            builder.Property(c => c.Ativo).HasColumnType("bit").HasColumnName("Ativo");
            builder.Property(c => c.IdCategoria).IsRequired().HasColumnType("bit").HasColumnName("IdCategoria");
            builder.Property(c => c.Valor).HasColumnType("decimal(15,2)").HasColumnName("Valor");
            builder.Property(c => c.Imagem).HasColumnType("varchar(255)").HasColumnName("Imagem");
            builder.Property(c => c.QuantidadeEstoque).IsRequired().HasColumnType("int").HasColumnName("QuantidadeEstoque");
            builder.Property(c => c.Altura).HasColumnType("decimal").HasColumnName("Altura");
            builder.Property(c => c.Largura).HasColumnType("decimal").HasColumnName("Largura");
            builder.Property(c => c.Profundidade).HasColumnType("decimal").HasColumnName("Profundidade");
            builder.ToTable("Produtos");
        }
    }
}
