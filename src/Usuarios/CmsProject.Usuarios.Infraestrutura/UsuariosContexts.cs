using CmsProject.Core.Data;
using CmsProject.Core.Messages;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsProject.Usuarios.Infraestrutura
{
    public class UsuariosContexts : IdentityDbContext, IUnitOfWork
    {
        public UsuariosContexts(DbContextOptions<UsuariosContexts> options) : base(options) { }

        public DbSet<Domain.Usuarios> Usuarios { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
            //    e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
            //    property.Relational().ColumnType = "varchar(100)";


            modelBuilder.Ignore<Event>();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UsuariosContexts).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> Commit()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            //await base.SaveChangesAsync();
            base.SaveChanges();

            return Convert.ToBoolean(await base.SaveChangesAsync());
        }

    }
}
