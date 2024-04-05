using AutoMapper;
using Conta_digital_API.Data;
using Conta_digital_API.DTOs;
using Conta_digital_API.Models;
using Conta_digital_API.Services;
using Conta_digital_API.Services.Impl;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Conta_digital_API.Controllers;

[ApiController]
[Route("api/v1/[Controller]")]
public class ContaController : ControllerBase
{
    private  MinipanContext _context;
    private  IMapper _mapper;


    public ContaController(MinipanContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }



    [HttpPost]
    public IActionResult AbrirConta([FromBody] CreateContaDTO contaDTO)
    {
        var cliente = new Cliente
        {
            Nome = contaDTO.Cliente.Nome,
            Cpf = contaDTO.Cliente.Cpf
        };

        


        var conta = new Conta
        {
            Usuario = cliente
        };

        conta.GerarContaCorrente();

        if (conta != null)
        {
            _context.Contas.Add(conta);
            _context.SaveChanges();
        }
        else
        {
            return BadRequest("CPF é nulo");
        }


       return CreatedAtAction(nameof(RecuperarContaPorId), new { conta.Id }, conta);

    }

    [HttpGet]
    public ActionResult<IEnumerable<Conta>> RecuperarContas([FromQuery] int offset = 0, [FromQuery] int limit = 20)
    {

        var listaDecontas = _context.Contas
            .Skip(offset)
            .Take(limit)
            .Include(conta => conta.Usuario)
            .ToList();

        if(listaDecontas != null) return Ok(listaDecontas);
        return NotFound();
        

        
    }

    [HttpGet("{Id}")]
    public IActionResult RecuperarContaPorId(int id)
    {
        var conta = _context.Contas.Include(conta => conta.Usuario).FirstOrDefault(conta => conta.Id == id);

        if(conta == null) return NotFound();
        return Ok(conta);
    }

}
