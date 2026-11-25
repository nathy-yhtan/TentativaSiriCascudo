using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TentativaSiriCascudo.DTOs;
using TentativaSiriCascudo.Repositories;
using TentativaSiriCascudo.Services;

namespace TentativaSiriCascudo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class InfonutriController : ControllerBase
    {

        //variavel de acesso ao banco
        private readonly IInfonutriService _service;


        //injecao de dependencia
        public InfonutriController(IInfonutriService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _service.ListarTudo());


        [HttpPost]
        public async Task<IActionResult> Post(InfonutriDTO infonutriDTO)
        {
            try
            {
                await _service.Criar(infonutriDTO);
                return Ok("Informação nutricional adicionada");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                //erro 400: servidor não entendeu ou recusou processar a sua solicitação devido a um problema no envio dos dados pelo navegador, aplicativo ou rede
            }
        }

    }

}