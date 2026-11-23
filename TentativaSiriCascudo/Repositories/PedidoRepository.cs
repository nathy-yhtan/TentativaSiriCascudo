using Microsoft.EntityFrameworkCore;
using TentativaSiriCascudo.Data;
using TentativaSiriCascudo.Models;


namespace TentativaSiriCascudo.Repositories
{
    public class PedidoRepository :IPedidoRepository
    {

        //conexão com o B.D., variável banco de dados
        private readonly AppDbContext _context;


        //construtor
        public PedidoRepository(AppDbContext context)
        {
            _context = context;
        }


        //retornar todos os Pedido
        public async Task<IEnumerable<Pedido>> ListarTudo()
        {
            return await _context.Pedidos
                .ToListAsync();
        }


        //salvar no B.D.
        public async Task Adicionar(Pedido pedido)
        {
            await _context.Pedidos.AddAsync(pedido);
            await _context.SaveChangesAsync();
        }

    }
}