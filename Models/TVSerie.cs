using Microsoft.IdentityModel.Protocols.OpenIdConnect;

public class TVSerie : Media
{
    public int? Seasons { get; set; }

    //ONE-TO-MANY-EPISODE
    public List<Episode>? Episodes { get; set; }

    //ONE-TO-MANY-MEDIA
    public int? MediaLinkId { get; set; }
    public MediaLink? MediaLink { get; set; }

    public TVSerie()
    {

    }
}