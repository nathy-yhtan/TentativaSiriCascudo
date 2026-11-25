using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TentativaSiriCascudo.DTOs;
using TentativaSiriCascudo.Repositories;
using TentativaSiriCascudo.Services;

namespace TentativaSiriCascudo.Controllers
{

    //📝estar entre [] indica q o nome é o nome do controller, nesse caso 'pedidos'

    //📝ControllerBase é uma classe nativa do.NET

    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {

        //variavel de acesso ao banco
        private readonly IPedidoService _service;


        //injeção de dependencia
        public PedidosController(IPedidoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _service.ListarTudo());


        [HttpPost]
        public async Task<IActionResult> Post(PedidoDTO pedidoDTO)
        {
            try
            {
                await _service.Criar(pedidoDTO);
                return Ok("Pedido adicionado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                //erro 400: servidor não entendeu ou recusou processar a sua solicitação devido a um problema no envio dos dados pelo navegador, aplicativo ou rede
            }
        }

    }

}