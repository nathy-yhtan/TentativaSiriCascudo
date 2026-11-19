using System.Collections;
using TentativaSiriCascudo.Models;

namespace TentativaSiriCascudo.Repositories
{
    public interface IProdutoRepository
    {

        Task<IEnumerable<Pedido>> ListarTudo();


        //regra pra criar novos registros
        Task Adicionar(Pedido pedido);

    }
}