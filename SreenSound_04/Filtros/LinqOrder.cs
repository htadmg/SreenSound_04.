using SreenSound_04.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SreenSound_04.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artitasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artistas ordenados");
        foreach (var artista in artitasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
    
}
