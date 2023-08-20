using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

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
        LinqFilter.FiltrarMusicasPorTonalidade(musicas);

        //var musicasFavoritasDirceu = new MusicasPreferidas("Dirceu");
        //musicasFavoritasDirceu.AdicionarMusicasFavoritas(musicas[537]);
        //musicasFavoritasDirceu.AdicionarMusicasFavoritas(musicas[238]);
        //musicasFavoritasDirceu.AdicionarMusicasFavoritas(musicas[761]);
        //musicasFavoritasDirceu.AdicionarMusicasFavoritas(musicas[970]);
        //musicasFavoritasDirceu.AdicionarMusicasFavoritas(musicas[489]);

        //musicasFavoritasDirceu.ExibirMusicasFavoritas();

        //musicasFavoritasDirceu.GerarArquivoJson();





    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
