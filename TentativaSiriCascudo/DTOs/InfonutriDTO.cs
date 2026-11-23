using System.ComponentModel.DataAnnotations;

namespace TentativaSiriCascudo.DTOs
{
    //passo os atributos q quero q o usuario envie ou receba
    public class InfonutriDTO
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Mínimo de 2 caractéres e máximo de 100")]
        public string Nome { get; set; } = string.Empty;
    }
}
