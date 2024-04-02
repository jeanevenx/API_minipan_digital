

using System.Text.Json.Serialization;

namespace ScreenSound.Modelos;

internal class Music
{

    string[] tonalidades = new string[]{ "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"};

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("duration_ms")]
    public double Duracao { get; set;}

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("key")]
    [JsonIgnore]
    public int Key { get; set; }
    public string Tonalidade => tonalidades[Key];
    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duração em munitos: {Math.Round((Duracao/1000)/60, 2)}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade} \n");
    }

}
