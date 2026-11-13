//biblioteca
using System.ComponentModel.DataAnnotations;
using System.Timers;

namespace TentativaSiriCascudo.Models
{

    public class Infonutri
    {

        //so pelo nome Id já sabe q é P.K.
        public int Id { get; set; }


        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

    }

}