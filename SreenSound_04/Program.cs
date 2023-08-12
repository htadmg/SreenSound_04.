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
        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        var musicasPreferidas = new MusicasPreferidas("Agata");
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[9]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[10]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[7]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[1469]);
        musicasPreferidas.ExibirMusicasFavoritas();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}