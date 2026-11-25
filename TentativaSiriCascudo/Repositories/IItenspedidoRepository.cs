using System.Collections;
using TentativaSiriCascudo.Models;

namespace TentativaSiriCascudo.Repositories
{
    public interface IItenspedidoRepository
    {

        Task<IEnumerable<Itenspedido>> ListarTudo();


        //regra pra criar novos registros
        Task Adicionar(Itenspedido itenspedido);

    }
}