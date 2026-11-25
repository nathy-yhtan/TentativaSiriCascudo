using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TentativaSiriCascudo.DTOs;
using TentativaSiriCascudo.Repositories;
using TentativaSiriCascudo.Services;

namespace TentativaSiriCascudo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ItenspedidoController : ControllerBase
    {

        //variavel de acesso ao banco
        private readonly IItenspedidoService _service;


        //injecao de dependencia
        public ItenspedidoController(IItenspedidoService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _service.ListarTudo());


        [HttpPost]
        public async Task<IActionResult> Post(ItenspedidoDTO itenspedidoDTO)
        {
            try
            {
                await _service.Criar(itenspedidoDTO);
                return Ok("Itens do pedido adicionado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                //erro 400: servidor não entendeu ou recusou processar a sua solicitação devido a um problema no envio dos dados pelo navegador, aplicativo ou rede
            }
        }

    }
}
