using TentativaSiriCascudo.DTOs;
using TentativaSiriCascudo.Models;
using TentativaSiriCascudo.Repositories;

//serviço aplica as regras de negocio, seguimento de fluxo e validações
namespace TentativaSiriCascudo.Services
{

    public class InfonutriService : IInfonutriService
    {

        //enviar para o repositorio pq ele q entra em contato com o B.D.
        private readonly IInfonutriRepository _repository;


        public InfonutriService(IInfonutriRepository repository)
        {
            _repository = repository;
        }


        public async Task<IEnumerable<Infonutri>> ListarTudo() =>
            await _repository.ListarTudo();


        public async Task Criar(InfonutriDTO infonutriDTO)
        {

            //validação e mapeamento de entidade
            var infonutri = new Infonutri
            {
                Nome = infonutriDTO.Nome
            };


            await _repository.Adicionar(infonutri);

        }

    }

}