using System.Collections;
using TentativaSiriCascudo.Models;

namespace TentativaSiriCascudo.Repositories
{
    public interface IItenspedidoRepository
    {

        Task<IEnumerable<Pedido>> ListarTudo();


        //regra pra criar novos registros
        Task Adicionar(Pedido pedido);

    }
}