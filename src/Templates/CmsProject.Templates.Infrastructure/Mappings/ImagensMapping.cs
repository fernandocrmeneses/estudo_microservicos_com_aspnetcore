using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Infrastructure.Mappings
{
    public class ImagensMapping
    {
        public void Configure(EntityTypeBuilder<Domain.Imagens> builder)
        {
            builder.HasKey(c => c.Id);
            
            builder.Property(c => c.DataCriacao)
                    .IsRequired().HasColumnType("datetime")
                    .HasColumnName("DataCriacao");

            builder.Property(c => c.DataAtualizacao)
                   .IsRequired().HasColumnType("datetime")
                   .HasColumnName("DataAtualizacao");

            builder.Property(c => c.Nome).IsRequired().HasColumnType("varchar(255)").HasColumnName("Nome");

            builder.Property(c => c.CaminhoImagem).HasColumnType("varchar(255)").HasColumnName("CaminhoImagem");

            builder.Property(c => c.Status).IsRequired().HasColumnType("int").HasColumnName("Status");

            builder.Property(c => c.Conteudo).HasColumnType("Longblob").HasColumnName("Conteudo");

            builder.HasOne(c => c.Pagina).WithMany(c => c.Imagens);
            
            builder.Property(c => c.EhArquivoFisico).IsRequired().HasColumnType("bit").HasColumnName("EhArquivoFisico");
        }
    }
}
