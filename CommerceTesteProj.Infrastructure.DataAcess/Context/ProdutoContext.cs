using CommerceTesteProj.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CommerceTesteProj.Infrastructure.DataAcess.Context
{
    public class ProdutoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\User\\Documents\\CommerceTestProj\\CommerceTesteProj.Infrastructure.DataAcess\\Database\\Produtos.db", b => b.MigrationsAssembly ("CommerceTesteProj.Presentation"));
        }
        protected override void OnModelCreating(ModelBuilder options){
            options.Entity<Produto>().HasKey(produto => produto.produto_id);
        }
    }
}