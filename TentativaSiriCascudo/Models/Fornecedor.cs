//biblioteca
using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;
using System.Timers;

namespace TentativaSiriCascudo.Models
{

    public class Fornecedor
    {

        //so pelo nome Id já sabe q é P.K.
        public int Id { get; set; }


        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }


        [Required]
        [MaxLength(10)]
        public int Telefone { get; set; }


        [Required]
        [MaxLength(100)]
        public string Endereco { get; set; }

    }

}