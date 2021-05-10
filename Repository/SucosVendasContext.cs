using Microsoft.EntityFrameworkCore;
using Sucos_Vendas.Domain;
using Sucos_Vendas.Repository.Mapping;

namespace Sucos_Vendas.Repository
{
    public class SucosVendasContext : DbContext
    {
        public SucosVendasContext(DbContextOptions<SucosVendasContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMapping());
            //modelBuilder.ApplyConfiguration(new NotaFiscalMapping());
            //modelBuilder.ApplyConfiguration(new ProdutoMapping());
            //modelBuilder.ApplyConfiguration(new ItemNotasFiscaisMapping());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<NotaFiscal> NotasFiscais { get; set; }
        public DbSet<ItensNotasFiscais> ItensNotasFiscais { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }

    }
}
