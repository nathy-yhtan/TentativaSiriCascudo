using TentativaSiriCascudo.DTOs;
using TentativaSiriCascudo.Models;

namespace TentativaSiriCascudo.Services
{

    //serviço diz O QUE sera feito, e nao COMO
    public interface IInfonutriService
    {

        Task<IEnumerable<Infonutri>> ListarTudo();

        Task Criar(InfonutriDTO infonutriDTO);

    }

}