using Conta_digital_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Conta_digital_API.Controllers;

[ApiController]
[Route("api/v1/[Controller]")]
public class ContaController : ControllerBase
{

    public static List<Conta> contas = new List<Conta>();
    public static int id = 0;

    [HttpPost]
    public IActionResult AbrirConta([FromBody] Conta conta)
    {

        Conta novaConta = new()
        {
            Id = id++,
            Usuario = conta.Usuario,
        };

        novaConta.Usuario.ClienteID = Guid.NewGuid();



        contas.Add(novaConta);

        return CreatedAtAction(nameof(RecuperarContaPorId), new {novaConta.Id }, novaConta);

    }

    [HttpGet]
    public IActionResult RecuperarContas([FromQuery] int offset = 0, [FromQuery] int limit = 20)
    {

        var listaDecontas = contas.Skip(offset).Take(limit);

        if(listaDecontas != null) return Ok(listaDecontas);
        return NotFound();
        

        
    }

    [HttpGet("{Id}")]
    public IActionResult RecuperarContaPorId(int id)
    {
        var conta = contas.FirstOrDefault(conta => conta.Id == id);

        if(conta == null) return NotFound();
        return Ok(conta);
    }

}
