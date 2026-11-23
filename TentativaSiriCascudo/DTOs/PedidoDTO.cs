using System.ComponentModel.DataAnnotations;

namespace TentativaSiriCascudo.DTOs
{
    public class PedidoDTO
    {
        [Required(ErrorMessage = "Informe a data e a hora")]
        public DateTime DataHora { get; set; }


        [Required(ErrorMessage = "Informe o número da mesa")]
        public int NMesa { get; set; }
    }
}