using TentativaSiriCascudo.DTOs;
using TentativaSiriCascudo.Models;

namespace TentativaSiriCascudo.Services
{
    public interface IFornecedorService
    {

        Task<IEnumerable<Fornecedor>> ListarTudo();

        Task Criar(FornecedorDTO fornecedorDTO);

    }
}
