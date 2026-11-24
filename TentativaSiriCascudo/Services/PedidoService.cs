using TentativaSiriCascudo.DTOs;
using TentativaSiriCascudo.Models;
using TentativaSiriCascudo.Repositories;

namespace TentativaSiriCascudo.Services
{
    public class PedidoService : IPedidoService
    {

        private readonly IPedidoRepository _repository;


        public PedidoService(IPedidoRepository repository)
        {
            _repository = repository;
        }


        public async Task<IEnumerable<Pedido>> ListarTudo() =>
            await _repository.ListarTudo();


        public async Task Criar(PedidoDTO pedidoDTO)
        {

            //validação e mapeamento de entidade
            var pedido = new Pedido
            {
                DataHora = pedidoDTO.DataHora,
                NMesa = pedidoDTO.NMesa
            };


            await _repository.Adicionar(pedido);

        }

    }
}
