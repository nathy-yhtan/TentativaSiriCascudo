using TentativaSiriCascudo.DTOs;
using TentativaSiriCascudo.Models;
using TentativaSiriCascudo.Repositories;

namespace TentativaSiriCascudo.Services
{
    public class ItenspedidoService : IItenspedidoService
    {

        private readonly IItenspedidoRepository _repository;


        public ItenspedidoService(IItenspedidoRepository repository)
        {
            _repository = repository;
        }


        public async Task<IEnumerable<Itenspedido>> ListarTudo() =>
            await _repository.ListarTudo();


        public async Task Criar(ItenspedidoDTO itenspedidoDTO)
        {

            //validação e mapeamento de entidade
            var itenspedido = new Itenspedido
            {
                Qtd = itenspedidoDTO.Qtd,
                ProdutoId = itenspedidoDTO.ProdutoId,
                PedidoId = itenspedidoDTO.PedidoId
            };


            await _repository.Adicionar(itenspedido);

        }


    }
}
