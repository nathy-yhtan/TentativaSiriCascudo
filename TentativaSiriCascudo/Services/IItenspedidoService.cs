using TentativaSiriCascudo.DTOs;
using TentativaSiriCascudo.Models;

namespace TentativaSiriCascudo.Services
{
    public interface IItenspedidoService
    {

        Task<IEnumerable<Itenspedido>> ListarTudo();

        Task Criar(ItenspedidoDTO itenspedidoDTO);

    }
}