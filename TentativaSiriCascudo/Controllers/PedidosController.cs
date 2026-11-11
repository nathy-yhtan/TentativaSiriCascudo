using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TentativaSiriCascudo.Controllers
{

    //📝estar entre [] indica q o nome é o nome do controller, nesse caso 'pedidos'

    //📝ControllerBase é uma classe nativa do.NET

    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetPedidos()
        {

            var PedidosFalsos = new List<string>
            {
                "pedido do patrick",
                "pedido do bob esponja",
                "pedido do lula molusco"
            };


            return Ok(PedidosFalsos);

        }
 
    }

}