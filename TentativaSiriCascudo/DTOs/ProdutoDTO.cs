using System.ComponentModel.DataAnnotations;

namespace TentativaSiriCascudo.DTOs
{
    public class ProdutoDTO
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Mínimo de 2 caractéres e máximo de 100")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O preço é obrigatório")]
        public decimal Preco { get; set; }


        [Required(ErrorMessage = "Informe o ID da informação nutricional")]
        public int InfonutriId { get; set; }


        [Required(ErrorMessage = "Informe o ID do fornecedor")]
        public int FornecedorId { get; set; }
    }
}
