using System.ComponentModel.DataAnnotations;

namespace TentativaSiriCascudo.DTOs
{
    public class FornecedorDTO
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Mínimo de 2 caractéres e máximo de 100")]
        public string Nome { get; set; } = string.Empty;


        [Required]
        [Range(0000000000, 9999999999, ErrorMessage = "O telefone deve ter 10 dígitos")]
        public long Telefone { get; set; }


        [Required(ErrorMessage = "O endereço é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Mínimo de 2 caractéres e máximo de 100")]
        public string Endereco { get; set; } = string.Empty;
    }
}
