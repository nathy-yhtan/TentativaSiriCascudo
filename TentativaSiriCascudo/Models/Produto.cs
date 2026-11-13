//biblioteca
using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;
using System.Timers;

namespace TentativaSiriCascudo.Models
{

    public class Produto
    {

        //escrever "Id" já o identifica como PRIMARY KEY
        public int Id { get; set; }


        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }


        [Required]
        [MaxLength(100)]
        public decimal Preco { get; set; }


        //'?' significa que pode ser nula
        //o nome é 'EntidadeAtributo'
        public int InfonutriId { get; set; } //chave estrangeira
        public Infonutri? Infonutri { get; set; } //propriedade de navegação


        public int FornecedorId { get; set; } //chave estrangeira
        public Fornecedor? Fornecedor { get; set; } //propriedade de navegação

    }

}