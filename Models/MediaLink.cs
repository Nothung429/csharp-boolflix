public class MediaLink
{
    public int? Id { get; set; }
    public string? Year { get; set; }
    public bool? IsNew { get; set; }

    //ONE-TO-MANY-TVSERIE
    public List<TVSerie>? TVSeries { get; set; }

    //ONE-TO-MANY-MOVIE
    public List<Movie>? Movies { get; set; }

    //ONE-TO-MANY-CHARACTERISTIC
    public List<Characteristic>? Characteristics { get; set; }

    //ONE-TO-MANY-GENRE
    public List<Genre>? Genres { get; set; }

    //ONE-TO-MANY-ACTOR
    public List<Actor>? Actors { get; set; }
}