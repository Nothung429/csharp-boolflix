public class Actor
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Nationality { get; set; }

    //ONE-TO-MANY-TVSERIE
    public List<TVSerie>? TVSeries { get; set; }

    //ONE-TO-MANY-MOVIE
    public List<Movie>? Movies { get; set; }

    public Actor()
    {

    }
}