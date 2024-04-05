using System.ComponentModel.DataAnnotations;

namespace Conta_digital_API.DTOs;

public class CreateContaDTO
{
    [Required]
    public ClienteDTO Cliente { get; set; }
}
