using System.ComponentModel.DataAnnotations;

namespace Conta_digital_API.DTOs
{
    public class ClienteDTO
    {
        [Required]
        [StringLength(30)]
        public string? Nome { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Tamanho do cpf deve ser igual a 11")]
        public string? Cpf { get; set; }
    }
}
