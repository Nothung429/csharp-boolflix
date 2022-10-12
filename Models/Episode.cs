public class Episode
{
    public int? Id { get; set; }
    public int? Duration { get; set; }
    public int? SeasonNumber { get; set; }

    //ONE-TO-MANY-TVSERIE
    public int? TVSerieId { get; set; }
    public TVSerie? TVSerie { get; set; }

    public Episode()
    {

    }
}