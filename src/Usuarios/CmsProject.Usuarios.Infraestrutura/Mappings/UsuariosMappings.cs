//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace CmsProject.Usuarios.Infraestrutura.Mappings
//{
//    public class UsuariosMappings: IEntityTypeConfiguration<Domain.Usuarios>
//    {
//        public void Configure(EntityTypeBuilder<Domain.Usuarios> builder)
//        {
//            //builder.HasKey(c => c.Id);
//            builder.Property(c => c.DataCriacao)
//                .IsRequired().HasColumnType("datetime")
//                .HasColumnName("dataCriacao");

//            builder.Property(c => c.DataCancelamento)
//                .HasColumnType("datetime")
//                .HasColumnName("dataCancelamento");

//            builder.Property(c => c.DataRetorno)
//                .HasColumnType("datetime")
//                .HasColumnName("dataRetorno");

//            builder.Property(c => c.Nome).IsRequired().HasColumnType("varchar(255)").HasColumnName("nome");
//            builder.Property(c => c.SobreNome)
//                .IsRequired()
//                .HasColumnType("varchar(255)").HasColumnName("sobrenome");

//            builder.Property(c => c.CPF_CNPJ)
//                .IsRequired()
//                .HasColumnType("varchar(50)")
//                .HasColumnName("cpf_cnpj");


//            builder.Property(c => c.Ativo)
//                .HasColumnType("tinyint")
//                .HasColumnName("ativo");

//            builder.Property(c => c.Status)
//                .HasColumnType("varchar(50)").HasColumnName("status");

//            builder.Property(c => c.TipoUsuario)
//                .IsRequired()
//                .HasColumnType("int")
//                .HasColumnName("tipoUsuario");

//            builder.Property(c => c.IdSistema)
//                .IsRequired()
//                .HasColumnType("char(36)")
//                .HasColumnName("idSistema");

//            builder.ToTable("Usuarios");
            
//        }
//    }
//}
