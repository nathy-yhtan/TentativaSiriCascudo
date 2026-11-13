using TentativaSiriCascudo.Models;
using Microsoft.EntityFrameworkCore;

namespace TentativaSiriCascudo.Data
{

    public class AppDbContext : DbContext
    {

        // construtor para receber as configurações do banco de dados
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        //informa ao EF p/ criar uma tabela baseada na classe:

        public DbSet<Fornecedor> Fornecedores { get; set; }

        public DbSet<Infonutri> Infonutris { get; set; }

        public DbSet<Itenspedido> Itenspedidos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<Produto> Produtos { get; set; }

    }

}