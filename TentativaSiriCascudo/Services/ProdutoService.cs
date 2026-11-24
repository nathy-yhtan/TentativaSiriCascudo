using TentativaSiriCascudo.DTOs;
using TentativaSiriCascudo.Models;
using TentativaSiriCascudo.Repositories;

namespace TentativaSiriCascudo.Services
{
    public class ProdutoService : IProdutoService
    {

        private readonly IProdutoRepository _repository;


        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }


        public async Task<IEnumerable<Produto>> ListarTudo() =>
            await _repository.ListarTudo();


        public async Task Criar(ProdutoDTO produtoDTO)
        {

            //validação e mapeamento de entidade
            var produto = new Produto
            {
                Nome = produtoDTO.Nome,
                Preco = produtoDTO.Preco,
                InfonutriId = produtoDTO.InfonutriId,
                FornecedorId = produtoDTO.FornecedorId
            };


            await _repository.Adicionar(produto);

        }

    }
}
