using CmsProject.Core.Data;
using CmsProject.Core.Messages;
using CmsProject.Templates.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsProject.Templates.Infrastructure
{
    public class TemplateContext : DbContext, IUnitOfWork
    {

        public TemplateContext(DbContextOptions<TemplateContext> options) : base(options) { }
        
        public DbSet<Pagina> Paginas { get; set; }
        public DbSet<Domain.Templates> Templates { get; set; }
        public DbSet<ElementoFrontEnd> ElementoFrontEnd { get; set; }
        public DbSet<Imagens> Imagens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Event>();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TemplateContext).Assembly);
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
            //base.SaveChanges();

            return Convert.ToBoolean(await base.SaveChangesAsync());
        }
    }
}
