namespace ScreenSound.Nyteon.Movies;

public class Movie
{
    public Movie(string title, string actor, float duration)
    {
        Title = title;
        Actor = actor;
        Duration = duration;
    }

    public string Title { get; }
    public string Actor { get; }
    public float Duration { get; }
}
