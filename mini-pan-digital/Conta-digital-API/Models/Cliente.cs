using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Conta_digital_API.Models;

public class Cliente
{
    [Key]
    [Required]
    public int Id {  get; set; }
    [ForeignKey("Conta")]
    public int ContaId { get; set; }
    [Required]
    [StringLength(30)]
    public string? Nome { get; set; }
    [Required]
    [StringLength(15, ErrorMessage ="Tamanho do cpf deve ser igual a 15")]
    public string? Cpf { get; set ;}

}
