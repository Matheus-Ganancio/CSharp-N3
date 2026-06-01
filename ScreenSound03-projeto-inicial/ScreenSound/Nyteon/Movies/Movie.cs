namespace ScreenSound.Nyteon.Movies;

public class Movie
{
    public Movie(string title, float duration)
    {
        Title = title;
        Duration = duration;
    }

    public string Title { get; }
    public List<Artista> Elenco { get; } = new List<Artista>();
    public float Duration { get; }

    public void AdicionarArtista(Artista artista)
    {
        if (!Elenco.Contains(artista))
        {
            Elenco.Add(artista);
            artista.AdicionarFilme(this); // Mantém a mão dupla
        }
    }
}
