using ScreenSound.Filtros;
using ScreenSound.Modelos;
using System.Linq;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Music>>(resposta)!;

        Console.WriteLine(musicas.Count);
        //int count = 0;

        MusicFilter.FiltrarArtistasPorGenero(musicas, "rock");

    } 
    catch(Exception e) {
        Console.WriteLine(e);
    }
}