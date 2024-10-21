using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Infrastructure.Mappings
{
    public class ElementoFrontEndMapping
    {
        public void Configure(EntityTypeBuilder<Domain.ElementoFrontEnd> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.DataCriacao).IsRequired().HasColumnType("datetime").HasColumnName("DataCriacao");

            builder.Property(c => c.DataAtualizacao).IsRequired().HasColumnType("datetime").HasColumnName("DataAtualizacao");

            builder.Property(c => c.IdPagina).IsRequired().HasColumnType("varchar(255)").HasColumnName("IdPagina");

            builder.Property(c => c.CaminhoArquivo).HasColumnType("varchar(255)").HasColumnName("CaminhoArquivo");

            builder.Property(c => c.Nome).IsRequired().HasColumnType("varchar(255)").HasColumnName("Nome");

            builder.Property(c => c.Status).IsRequired().HasColumnType("bit").HasColumnName("Status");

            builder.Property(c => c.EhArquivoFisico).HasColumnType("bit").HasColumnName("EhArquivoFisico");

            builder.Property(c => c.Workflow).IsRequired().HasColumnType("int").HasColumnName("Workflow");

            builder.HasOne(c => c.Pagina).WithMany(c => c.ElementoFrontEnd);
            

            builder.Property(c => c.Workflow).HasColumnType("varchar(255)").HasColumnName("Tipo");

            //builder.HasOne(c => c.ElementoFrontEnd).WithMany(c => c.BackupElementoFrontEnd);

            builder.ToTable("ElementoFrontEnd");

        }
    }
}
