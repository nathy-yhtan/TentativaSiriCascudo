using System.Collections;
using TentativaSiriCascudo.Models;

namespace TentativaSiriCascudo.Repositories
{
    public interface IProdutoRepository
    {

        Task<IEnumerable<Produto>> ListarTudo();


        //regra pra criar novos registros
        Task Adicionar(Produto produto);

    }
}