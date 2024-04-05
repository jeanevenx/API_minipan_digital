using AutoMapper;
using Conta_digital_API.DTOs;
using Conta_digital_API.Models;

namespace Conta_digital_API.Profiles;
public class ClienteProfile: Profile

{
    public ClienteProfile()
    {
        CreateMap<CreateContaDTO, ClienteDTO>();
        CreateMap<ClienteDTO, Cliente>();
    }
}
