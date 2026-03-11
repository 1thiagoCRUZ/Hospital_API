using Microsoft.EntityFrameworkCore;
using SistemaGerenciamentoAlmoxarifado.Hospital.Business.Entities;

namespace SistemaGerenciamentoAlmoxarifado.Hospital.Data.Contexts
{
    public class DataContext: DbContext
    {
        public DbSet<Item> Items { get; set; }

        public DataContext(DbContextOptions<DataContext> options): base (options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable("items").HasKey(item => item.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
