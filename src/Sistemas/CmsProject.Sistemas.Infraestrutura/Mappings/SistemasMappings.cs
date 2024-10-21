using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using CmsProject.Sistemas;

namespace CmsProject.Sistemas.Infraestrutura.Mappings
{
    public class SistemasMappings : IEntityTypeConfiguration<Domain.Sistemas>
    {
        public void Configure(EntityTypeBuilder<Domain.Sistemas> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(255)")
                .HasColumnName("nome");
            builder.Property(c => c.Status)
                .IsRequired()
                .HasColumnName("tinyint");

            builder.ToTable("Sistemas");
        }
    }
}
