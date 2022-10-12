public class Movie : Media
{
    public int? Duration { get; set; }

    //ONE-TO-MANY-CHARACTERISTIC
    public List<Characteristic>? Characteristics { get; set; }

    //ONE-TO-MANY-GENRE
    public List<Genre>? Genres { get; set; }

    //ONE-TO-MANY-ACTOR
    public List<Actor>? Actors { get; set; }

    public Movie()
    {

    }
}