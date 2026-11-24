using TentativaSiriCascudo.DTOs;
using TentativaSiriCascudo.Models;

namespace TentativaSiriCascudo.Services
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> ListarTudo();

        Task Criar(ProdutoDTO produtoDTO);
    }
}