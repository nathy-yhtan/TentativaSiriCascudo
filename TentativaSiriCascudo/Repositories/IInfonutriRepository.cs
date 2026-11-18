using System.Collections;
using TentativaSiriCascudo.Models;

namespace TentativaSiriCascudo.Repositories
{

    //criando pois não quero usar B.D. falso (controller)
    //"o q o sistema vai fazer"
    public interface IInfonutriRepository
    {

        //Task é operação assincrona (roda em segundo plano, não trava na espera da resposta do B.D.)
        //IEnumerable é lista de leitura que devolverá objetos do tipo Infonutri
        //retorte todas as Infonutri do B.D.
        Task<IEnumerable<Infonutri>> ListarTudo();


        //regra pra criar novos registros
        Task Adicionar(Infonutri infonutri);

    }

}