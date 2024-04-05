using Conta_digital_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Conta_digital_API.Data;

public class MinipanContext: DbContext
{
    public MinipanContext(DbContextOptions<MinipanContext> options) : base(options)
    {
        
    }

    public DbSet<Conta> Contas { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Transacao> Transacoes { get; set; }
}
