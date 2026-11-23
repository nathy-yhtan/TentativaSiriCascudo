using System.ComponentModel.DataAnnotations;

namespace TentativaSiriCascudo.DTOs
{
    public class ItenspedidoDTO
    {
        [Required(ErrorMessage = "Informe a quantidade")]
        public int Qtd { get; set; }


        [Required(ErrorMessage = "Informe o ID do produto")]
        public int ProdutoId { get; set; }


        [Required(ErrorMessage = "Informe o ID do pedido")]
        public int PedidoId { get; set; }
    }
}
