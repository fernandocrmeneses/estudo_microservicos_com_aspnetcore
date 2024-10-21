using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.ServicosPrestados.Infrastructure.Mappings
{
    public class ServicosMapping : IEntityTypeConfiguration<Catalogo.Domain.Servicos>
    {
        public void Configure(EntityTypeBuilder<Catalogo.Domain.Servicos> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.DataCriacao).HasColumnType("datetime").HasColumnName("DataCriacao");
            builder.Property(c => c.DataAtualizacao).HasColumnType("datetime").HasColumnName("DataAtualizacao");
            builder.Property(c => c.Nome).HasColumnType("varchar(50)").HasColumnName("Nome");
            builder.Property(c => c.QuantidadeSemanais).HasColumnType("int").HasColumnName("QuantidadeSemanais");
            builder.Property(c => c.ServicoDataHoraInicio).HasColumnType("datetime").HasColumnName("ServicoDataHoraInicio");
            builder.Property(c => c.ServicoDataHoraFim).HasColumnType("datetime").HasColumnName("ServicoDataHoraFim");
            builder.Property(c => c.ServicoDisponivel).HasColumnType("int").HasColumnName("ServicoDisponivel");
            builder.Property(c => c.RaioServicoPrestado).HasColumnType("int").HasColumnName("RaioServicoPrestado");
            builder.Property(c => c.IdUser).IsRequired().HasColumnType("varchar(40)").HasColumnName("IdUser");
            builder.Property(c => c.IdProduto).IsRequired().HasColumnType("varchar(40)").HasColumnName("IdProduto");
            builder.Property(c => c.IdCategoria).IsRequired().HasColumnType("varchar(40)").HasColumnName("IdCategoria");
            builder.Property(c => c.ValorServico).HasColumnType("decimal(15,2)").HasColumnName("ValorServico");
            builder.Property(c => c.Ativo).HasColumnType("bit").HasColumnName("Ativo");
            builder.ToTable("Servicos");
        }
    }
}

