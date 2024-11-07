using Microsoft.EntityFrameworkCore;
using GerenciadorDeProdutos.Models;

namespace GerenciadorDeProdutos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
