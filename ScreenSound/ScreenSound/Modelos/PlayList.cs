namespace ScreenSound.Modelos;

internal class Playlist(string nome)
{
    public string Nome { get; set; } = nome;
    public List<Music?> ListaDeMusicas { get; } = new List<Music>()!;

    public void AdicionarMusica(Music music)
    {
        ListaDeMusicas.Add(music);
    } 
    
    public void AdicionarMusica(List<Music> musicas, string artista)
    {
        foreach (Music music in musicas)
        {

            if (music.Artista.Equals(artista))
                ListaDeMusicas.Add(music);
        }

       
    }

    public void ExibirPlaylist()
    {

        int count = 1;
        Console.WriteLine($"Playlist: {Nome}");

        foreach (var music in ListaDeMusicas) {
            Console.WriteLine($"{count++} - {music}\n");
        }
    }

    public List<Music?> GetPlaylist()
    {
        return ListaDeMusicas;
    }
   


}
