using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Conta_digital_API.Models;

public class Cliente
{
    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public Guid ClienteID {  get; set; } 
    [Required]
    [StringLength(30)]
    public string? Nome { get; set; }
    [Required]
    [StringLength(11, ErrorMessage ="Tamanho do cpf deve ser igual a 11")]
    public string? Cpf { get; set ;}
}
