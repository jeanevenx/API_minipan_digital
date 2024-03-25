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

        //musicas[0].ExibirDetalhesDaMusica();
        //MusicFilter.FiltrarArtistasPorGenero(musicas, "rock");
        //MusicFilter.FiltrarPorGeneros(musicas);

        MusicFilter.MusicasEmCSharp(musicas);
        

    } 
    catch(Exception e) {
        Console.WriteLine(e);
    }
}