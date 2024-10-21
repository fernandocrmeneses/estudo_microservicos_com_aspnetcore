using CmsProject.Clientes.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Clientes.Infraestrutura.Mappings
{
    public class ClientesMapping: IEntityTypeConfiguration<Clientes.Domain.Clientes>
    {
        public void Configure(EntityTypeBuilder<Clientes.Domain.Clientes> builder)
        {

        }

    }
}
