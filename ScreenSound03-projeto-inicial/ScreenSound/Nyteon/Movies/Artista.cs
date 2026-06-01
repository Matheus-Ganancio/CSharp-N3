namespace ScreenSound.Nyteon.Movies;

public class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Movie> FilmesAtuados { get; set; } = new List<Movie>();

    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void AdicionarFilme(Movie filme)
    {
        if (!FilmesAtuados.Contains(filme))
        {
            FilmesAtuados.Add(filme);
            filme.AdicionarArtista(this); // Mantém a mão dupla
        }
    }
}
