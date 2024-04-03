using System.ComponentModel.DataAnnotations;

namespace Conta_digital_API.Models;

public class Conta
{
    
    public int Id { get; set; }
    [Required]
    public  Cliente Usuario { get; set; }
    [MaxLength(8, ErrorMessage ="Tamanho não pode exceder 8")]
    public  string Numero { get; private set; }
    [MaxLength(4, ErrorMessage = "Tamanho não pode exceder 4")]
    public  string Agencia { get; private set; }

    [DataType(DataType.Currency)]
    public  double Saldo { get; private set; }
    public  string Tipo { get; private set; }
   

    public Conta() {
        GerarContaCorrente();
    }


    public void GerarContaCorrente()
    {
        int digitoAleatorio = new Random().Next(1, 10);
        int numeroAleatorio = new Random().Next(1000, 10000);

        int primeirosDigitos = 2370 - digitoAleatorio;
        int ultimosDigitos = (numeroAleatorio - digitoAleatorio) / 2;

        Numero = "122454-9";
        Agencia = "0001";
        Saldo = 0;
        Tipo = "Corrente";
    }
}
