using System.Collections;
using TentativaSiriCascudo.Models;

namespace TentativaSiriCascudo.Repositories
{
    public interface IFornecedorRepository
    {

        Task<IEnumerable<Fornecedor>> ListarTudo();


        //regra pra criar novos registros
        Task Adicionar(Fornecedor fornecedor);

    }
}