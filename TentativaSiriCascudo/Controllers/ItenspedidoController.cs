using Microsoft.AspNetCore.Mvc;
using TentativaSiriCascudo.Repositories;
using Microsoft.AspNetCore.Http;

namespace TentativaSiriCascudo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ItenspedidoController : ControllerBase
    {

        //variavel de acesso ao banco
        private readonly IItenspedidoRepository _repository;


        //injecao de dependencia
        public ItenspedidoController(IItenspedidoRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _repository.ListarTudo());

    }
}
