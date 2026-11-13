//biblioteca
using System.ComponentModel.DataAnnotations;
using System.Timers;

namespace TentativaSiriCascudo.Models
{

    public class Pedido
    {

        //so pelo nome Id já sabe q é P.K.
        public int Id { get; set; }


        //ex: 25/11/2026 às 14:30:00
        //DateTime dataEspecifica = new DateTime(2026, 11, 25, 14, 30, 0);
        [Required]
        public DateTime DataHora { get; set; }


        [Required]
        public int NMesa { get; set; }

    }

}