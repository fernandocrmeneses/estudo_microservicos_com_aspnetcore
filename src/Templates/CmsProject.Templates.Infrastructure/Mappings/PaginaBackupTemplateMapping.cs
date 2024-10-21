using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Infrastructure.Mappings
{
    public class PaginaBackupTemplateMapping
    {
        public void Configure(EntityTypeBuilder<Domain.BackupPagina> builder)
        {

            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Pagina)
                .WithMany(c => c.BackupPagina);

            builder.Property(c => c.Pagina.DataCriacao)
                    .IsRequired().HasColumnType("datetime")
                    .HasColumnName("DataCriacao");

            builder.Property(c => c.Pagina.DataAtualizacao)
                   .IsRequired().HasColumnType("datetime")
                   .HasColumnName("DataAtualizacao");

            builder.Property(c => c.Pagina.Header)
                .HasColumnType("varchar(255)")
                .HasColumnName("Header");

            builder.Property(c => c.Pagina.Menu)
                .HasColumnType("text")
                .HasColumnName("Menu");

            builder.Property(c => c.Pagina.Body)
            .HasColumnType("text")
            .HasColumnName("Body");

            builder.Property(c => c.Pagina.Footer)
          .HasColumnType("text")
          .HasColumnName("Footer");

            builder.Property(c => c.Pagina.Categoria)
        .HasColumnType("varchar(255)")
        .HasColumnName("Categoria");

            builder.Property(c => c.Pagina.Nome).IsRequired()
                .HasColumnType("varchar(255)")
                .HasColumnName("Nome");

            builder.Property(c => c.Pagina.ElementoFrontEnd).HasColumnType("text").HasColumnName("ElementoFrontEnd");

            builder.Property(c => c.Pagina.Imagens).IsRequired()
            .HasColumnType("text")
            .HasColumnName("Imagens");


            builder.ToTable("PaginaBackup");

        }
    }
}
