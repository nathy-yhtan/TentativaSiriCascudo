using Microsoft.AspNetCore.Mvc;
using TentativaSiriCascudo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;

//quem recebe as requisisoes e etreca ao serviço
namespace TentativaSiriCascudo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {

        //variavel de acesso ao banco
        private readonly IFornecedorRepository _repository;


        //injeção de dependencia
        public FornecedorController(IFornecedorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _repository.ListarTudo());

    }
}
