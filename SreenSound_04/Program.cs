using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;
using SreenSound_04.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        LinqFilter.FiltrarMusicasEmCSharp(musicas);
        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");


        //var musicasPreferidasAgata = new MusicasPreferidas("Agata");
        //musicasPreferidasAgata.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasAgata.AdicionarMusicasFavoritas(musicas[9]);
        //musicasPreferidasAgata.AdicionarMusicasFavoritas(musicas[10]);
        //musicasPreferidasAgata.AdicionarMusicasFavoritas(musicas[7]);
        //musicasPreferidasAgata.AdicionarMusicasFavoritas(musicas[1469]);

        //musicasPreferidasAgata.ExibirMusicasFavoritas();
        //musicasPreferidasAgata.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}