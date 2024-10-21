using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Infrastructure.Mappings
{
    public class PaginaMapping
    {

        public void Configure(EntityTypeBuilder<Domain.Pagina> builder)
        {

            builder.HasKey(c => c.Id);
            

            builder.Property(c => c.DataCriacao)
                    .IsRequired().HasColumnType("datetime")
                    .HasColumnName("DataCriacao");

            builder.Property(c => c.DataAtualizacao)
                   .IsRequired().HasColumnType("datetime")
                   .HasColumnName("DataAtualizacao");

            builder.Property(c => c.Header)
                .HasColumnType("varchar(255)")
                .HasColumnName("Header");

            builder.Property(c => c.Menu)
                .HasColumnType("text")
                .HasColumnName("Menu");

            builder.Property(c => c.Body)
            .HasColumnType("text")
            .HasColumnName("Body");

            builder.Property(c => c.Footer)
          .HasColumnType("text")
          .HasColumnName("Footer");

            builder.Property(c => c.Categoria)
        .HasColumnType("varchar(255)")
        .HasColumnName("Categoria");

            builder.Property(c => c.Nome).IsRequired()
                .HasColumnType("varchar(255)")
                .HasColumnName("Nome");

            builder.Property(c => c.ElementoFrontEnd).HasColumnType("text").HasColumnName("ElementoFrontEnd");

            builder.HasOne(c => c.Templates).WithMany(c => c.Pagina);

            builder.Property(c => c.Imagens).IsRequired()
            .HasColumnType("text")
            .HasColumnName("Imagens");


            builder.ToTable("Paginas");

        }

    }
}
