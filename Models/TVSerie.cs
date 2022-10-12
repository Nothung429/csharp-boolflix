using Microsoft.IdentityModel.Protocols.OpenIdConnect;

public class TVSerie : Media
{
    public int? Seasons { get; set; }

    //ONE-TO-MANY-EPISODE
    public List<Episode>? Episodes { get; set; }

    //ONE-TO-MANY-CHARACTERISTIC
    public List<Characteristic>? Characteristics { get; set; }

    //ONE-TO-MANY-GENRE
    public List<Genre>? Genres { get; set; }

    //ONE-TO-MANY-ACTOR
    public List<Actor>? Actors { get; set; }

    public TVSerie()
    {

    }
}