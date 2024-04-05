using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Conta_digital_API.Models;


public class Conta
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(9, ErrorMessage ="Tamanho não pode exceder 8")]
    public  string Numero { get; set; }
    [MaxLength(4, ErrorMessage = "Tamanho não pode exceder 4")]
    public  string Agencia { get; set; }

    [DataType(DataType.Currency)]
    public  double Saldo { get; set; }
    public  string Tipo { get; set; }

    [Required]
    public Cliente Usuario { get; set; }


    public Conta() {
        GerarContaCorrente();
    }


    public void GerarContaCorrente()
    {
        int digitoAleatorio = new Random().Next(1, 10);
        int numeroAleatorio = new Random().Next(1000, 10000);

        int primeirosDigitos = 230 - digitoAleatorio;
        int ultimosDigitos = (numeroAleatorio - digitoAleatorio) / 2;
        var numeroComposto = $"{primeirosDigitos}" + $"{ultimosDigitos}" + "-" + $"{digitoAleatorio}";

        Numero = numeroComposto;
        Agencia = "0001";
        Saldo = 0;
        Tipo = "Corrente";
    }
}
