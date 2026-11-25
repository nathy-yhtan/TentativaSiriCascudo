using Microsoft.AspNetCore.Mvc;
using TentativaSiriCascudo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using TentativaSiriCascudo.Services;
using TentativaSiriCascudo.DTOs;

//quem recebe as requisisoes e etreca ao serviço
namespace TentativaSiriCascudo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {

        private readonly IFornecedorService _service;


        public FornecedorController(IFornecedorService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _service.ListarTudo());


        [HttpPost]
        public async Task<IActionResult> Post(FornecedorDTO fornecedorDTO)
        {
            try
            {
                await _service.Criar(fornecedorDTO);
                return Ok("Fornecedor cadastrado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                //erro 400: servidor não entendeu ou recusou processar a sua solicitação devido a um problema no envio dos dados pelo navegador, aplicativo ou rede
            }
        }

    }
}