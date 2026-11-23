using Microsoft.EntityFrameworkCore;
using TentativaSiriCascudo.Data;
using TentativaSiriCascudo.Models;

namespace TentativaSiriCascudo.Repositories
{
    public class ItenspedidoRepository : IItenspedidoRepository
    {

        //conexão com o B.D., variável banco de dados
        private readonly AppDbContext _context;


        //construtor
        public ItenspedidoRepository(AppDbContext context)
        {
            _context = context;
        }


        //retornar todos os Pedido
        public async Task<IEnumerable<Itenspedido>> ListarTudo()
        {
            return await _context.Itenspedidos
                .ToListAsync();
        }


        //salvar no B.D.
        public async Task Adicionar(Itenspedido itenspedido)
        {
            await _context.Itenspedidos.AddAsync(itenspedido);
            await _context.SaveChangesAsync();
        }


        //VENDO SE CONCERTA
        Task<IEnumerable<Pedido>> IItenspedidoRepository.ListarTudo()
        {
            throw new NotImplementedException();
        }

        public Task Adicionar(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}