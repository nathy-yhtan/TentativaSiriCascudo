using Microsoft.AspNetCore.Mvc;
using TentativaSiriCascudo.Repositories;
using Microsoft.AspNetCore.Http;

namespace TentativaSiriCascudo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class InfonutriController : ControllerBase
    {
    
        //variavel de acesso ao banco
        private readonly IInfonutriRepository _repository;


        //injecao de dependencia
        public InfonutriController(IInfonutriRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _repository.ListarTudo());

    }

}