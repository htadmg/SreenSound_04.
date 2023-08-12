using ScreenSound_04.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SreenSound_04.Modelos
{
    internal class MusicasPreferidas
    {
        public string? Nome {get; set }
        public List<Musica> ListaDeMusicasFavoritas { get;}
        public MusicasPreferidas(string nome) 
        {
            Nome = nome;
            ListaDeMusicasFavoritas = new List<Musica>();
        }
        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }
        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
            foreach(var musica in  ListaDeMusicasFavoritas)
            {
                Console.WriteLine($"{musica.Nome} de {musica.Artista}");
            }
        }
    }
}
