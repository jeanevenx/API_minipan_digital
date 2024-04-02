using System.Text.Json;
using ScreenSound.Utils;

namespace ScreenSound.Arquivos;

public class GerarArquivo
{

    public static void GerarJson(Object obj)
    {


        JsonSerializerOptions options = new()
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(obj, options);


        string nome = Convert.ToString(Utility.GetObjectProprietyValue(obj, "Nome"))!
            .ToLower()
            .Replace(" ", "-");


       string nomeDoArquivo = $"playlist-de-{nome}.json";

        

        if(File.Exists(nomeDoArquivo))
        {

            String arquivoExistante = File.ReadAllText(nomeDoArquivo);

            if (arquivoExistante.CompareTo(json) == -1 || arquivoExistante.CompareTo(json) == 1)
            {
                File.Delete(nomeDoArquivo);
                File.AppendAllText(nomeDoArquivo, json);
                Console.WriteLine($"Arquivo atualizado !!!");
            }
            else
                Console.WriteLine("O arquivo já existe!");
            
        }
        else 
        {
            File.AppendAllText(nomeDoArquivo, json);
            Console.WriteLine(@"Arquivo json criado com sucesso!
            Caminho: "+ Path.GetFullPath(nomeDoArquivo));

        }


    }

}
