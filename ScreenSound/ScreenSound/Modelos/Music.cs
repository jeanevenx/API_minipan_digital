

using System.Text.Json.Serialization;

namespace ScreenSound.Modelos;

internal class Music
{
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("duration_ms")]
    public double Duracao { get; set;}

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }


    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duracao em munitos: {Math.Round((Duracao/1000)/60, 2)}");
        Console.WriteLine($"Genero: {Genero} \n");
    }
}
