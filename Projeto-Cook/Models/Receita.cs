using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Cook.Models
{
    [Table("Receita")]
    public class Receita
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string Nome { get; set; }
    }
}
