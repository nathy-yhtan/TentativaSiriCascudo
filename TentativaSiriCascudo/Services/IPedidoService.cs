using TentativaSiriCascudo.DTOs;
using TentativaSiriCascudo.Models;

namespace TentativaSiriCascudo.Services
{
    public interface IPedidoService
    {

        Task<IEnumerable<Pedido>> ListarTudo();

        Task Criar(PedidoDTO pedidoDTO);

    }
}
