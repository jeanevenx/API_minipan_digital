using ScreenSound.Arquivos;
using ScreenSound.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Music>>(resposta)!;

        musicas[0].ExibirDetalhesDaMusica();
        //MusicFilter.FiltrarArtistasPorGenero(musicas, "rock");
        //MusicFilter.FiltrarPorGeneros(musicas);

        //MusicFilter.MusicasEmCSharp(musicas);

        Playlist topSeven = new("Os top seven");
        Playlist osMelhores = new("Os mais tocados");

        Playlist playlistSean = new ("Sean Paul");

        playlistSean.AdicionarMusica(musicas, "Sean Paul");


        topSeven.AdicionarMusica(musicas[1]);
        topSeven.AdicionarMusica(musicas[2]);
        topSeven.AdicionarMusica(musicas[3]);
        topSeven.AdicionarMusica(musicas[4]);
        topSeven.AdicionarMusica(musicas[5]);
        topSeven.AdicionarMusica(musicas[9]);
        topSeven.AdicionarMusica(musicas[15]);

        osMelhores.AdicionarMusica(musicas[0]);
        osMelhores.AdicionarMusica(musicas[10]);
        osMelhores.AdicionarMusica(musicas[123]);
        osMelhores.AdicionarMusica(musicas[9]);
        osMelhores.AdicionarMusica(musicas[78]);
        osMelhores.AdicionarMusica(musicas[70]);
        osMelhores.AdicionarMusica(musicas[90]);
        osMelhores.AdicionarMusica(musicas[20]);
        osMelhores.AdicionarMusica(musicas[40]);
        osMelhores.AdicionarMusica(musicas[20]);
        osMelhores.AdicionarMusica(musicas[177]);

        Console.WriteLine();


  
        GerarArquivo.GerarJson(osMelhores);



    } 
    catch(Exception e) {
        Console.WriteLine(e);
    }
}