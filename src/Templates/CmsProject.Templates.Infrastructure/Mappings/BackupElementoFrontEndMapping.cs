using CmsProject.Templates.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Infrastructure.Mappings
{
    public class BackupElementoFrontEndMapping
    {
        public void Configure(EntityTypeBuilder<Domain.BackupElementoFrontEnd> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.DataCriacao).IsRequired().HasColumnType("datetime").HasColumnName("DataCriacao");

            builder.Property(c => c.DataAtualizacao).IsRequired().HasColumnType("datetime").HasColumnName("DataAtualizacao");

            builder.Property(c => c.ElementoFrontEnd.IdPagina).IsRequired().HasColumnType("varchar(255)").HasColumnName("IdPagina");

            builder.Property(c => c.ElementoFrontEnd.CaminhoArquivo).HasColumnType("varchar(255)").HasColumnName("CaminhoArquivo");

            builder.Property(c => c.ElementoFrontEnd.Nome).IsRequired().HasColumnType("varchar(255)").HasColumnName("Nome");

            builder.Property(c => c.ElementoFrontEnd.Status).IsRequired().HasColumnType("bit").HasColumnName("Status");

            builder.Property(c => c.ElementoFrontEnd.EhArquivoFisico).HasColumnType("bit").HasColumnName("EhArquivoFisico");

            builder.Property(c => c.ElementoFrontEnd.Workflow).IsRequired().HasColumnType("int").HasColumnName("Workflow");

            builder.Property(c => c.ElementoFrontEnd.Tipo).HasColumnType("varchar(255)").HasColumnName("Tipo");

            builder.HasOne(c => c.ElementoFrontEnd).WithMany(c => c.BackupElementoFrontEnd);

            builder.ToTable("BackupElementoFrontEnd");

        }
    }
}
