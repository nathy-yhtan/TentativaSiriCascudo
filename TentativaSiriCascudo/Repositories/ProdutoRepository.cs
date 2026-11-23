using Microsoft.EntityFrameworkCore;
using TentativaSiriCascudo.Data;
using TentativaSiriCascudo.Models;

namespace TentativaSiriCascudo.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {

        //conexão com o B.D., variável banco de dados
        private readonly AppDbContext _context;


        //construtor
        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }


        //retornar todos os Produto
        public async Task<IEnumerable<Produto>> ListarTudo()
        {
            return await _context.Produtos
                .ToListAsync();
        }


        //salvar no B.D.
        public async Task Adicionar(Produto produto)
        {
            object value = await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();
        }

        //VENDO SE CONSERTA
        Task<IEnumerable<Pedido>> IProdutoRepository.ListarTudo()
        {
            throw new NotImplementedException();
        }

        public Task Adicionar(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}
