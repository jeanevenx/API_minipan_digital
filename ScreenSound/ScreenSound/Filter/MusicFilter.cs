using ScreenSound.Modelos;

namespace ScreenSound.Filter;

internal class MusicFilter
{


    public static void FiltrarPorGeneros(List<Music> musicas)
    {
        var generos = musicas.Select(generos => generos.Genero).Distinct().ToList();


        Console.WriteLine($"Total de generos: {generos.Count}");
        foreach (var genero in generos)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistas(List<Music> musicas)
    {
        var artistas = musicas.Select(artistas => artistas.Artista).Distinct().ToList();
        foreach (var artista in artistas)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void OrdenarArtistas(List<Music> musicas)
    {
        var ArtistasOrdenadas = musicas
            .OrderBy(musicas => musicas.Artista)
            .Select(m => m.Artista)
            .Distinct().ToList();

        foreach (var item in ArtistasOrdenadas)
        {
            Console.WriteLine($"- {item}");
        }
    }

    public static void FiltrarArtistasPorGenero(List<Music> musicas, string genero)
    {
        var artistasPorGeneros = musicas
            .Where(artista => artista.Genero.Contains(genero))
            .Select(artista => artista.Artista)
            .Distinct().ToList();

        foreach (var artista in artistasPorGeneros)
        {
            if (!(genero.Equals("") || genero.Equals(" ")))
                Console.WriteLine($"- {artista}");
        }
    }


    public static void MusicasEmCSharp(List<Music> musicas)
    {
        var musicasDeDoSustenido = musicas
            .Where(musica => musica.Tonalidade.Equals("C#"))
            .Select(musicas => musicas.Nome)
            .Distinct().ToList();

        Console.WriteLine("Musicas em C#:\n");

        foreach (var musica in musicasDeDoSustenido)
        {
            Console.WriteLine($"- Musica: {musica}");
        }
    }


}
