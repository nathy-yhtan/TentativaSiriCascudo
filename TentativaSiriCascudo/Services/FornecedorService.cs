using TentativaSiriCascudo.DTOs;
using TentativaSiriCascudo.Models;
using TentativaSiriCascudo.Repositories;

namespace TentativaSiriCascudo.Services
{
    public class FornecedorService : IFornecedorService
    {

        private readonly IFornecedorRepository _repository;


        public FornecedorService(IFornecedorRepository repository)
        {
            _repository = repository;
        }


        public async Task<IEnumerable<Fornecedor>> ListarTudo() =>
            await _repository.ListarTudo();


        public async Task Criar(FornecedorDTO fornecedorDTO)
        {

            //validação e mapeamento de entidade
            var fornecedor = new Fornecedor
            {
                Nome = fornecedorDTO.Nome,
                Telefone = fornecedorDTO.Telefone,
                Endereco = fornecedorDTO.Endereco
            };


            await _repository.Adicionar(fornecedor);

        }

    }
}