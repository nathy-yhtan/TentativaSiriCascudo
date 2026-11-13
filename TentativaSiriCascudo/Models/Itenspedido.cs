//biblioteca
using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;
using System.Timers;

namespace TentativaSiriCascudo.Models
{

    public class Itenspedido
    {

        //escrever "Id" já o identifica como PRIMARY KEY
        public int Id { get; set; }


        [Required]
        public int Qtd { get; set; }


        //'?' significa que pode ser nula
        //o nome é 'EntidadeAtributo'
        public int ProdutoId { get; set; } //chave estrangeira
        public Produto? Produto { get; set; } //propriedade de navegação


        public int PedidoId { get; set; } //chave estrangeira
        public Pedido? Pedido { get; set; } //propriedade de navegação

    }

}