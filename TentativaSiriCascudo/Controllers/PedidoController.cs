using Microsoft.AspNetCore.Mvc;
using TentativaSiriCascudo.Repositories;
using Microsoft.AspNetCore.Http;

namespace TentativaSiriCascudo.Controllers
{

    //📝estar entre [] indica q o nome é o nome do controller, nesse caso 'pedidos'

    //📝ControllerBase é uma classe nativa do.NET

    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {

        //variavel de acesso ao banco
        private readonly IPedidoRepository _repository;


        //injeção de dependencia
        public PedidosController(IPedidoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _repository.ListarTudo());

    }

}