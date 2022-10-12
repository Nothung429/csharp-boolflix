public class Movie : Media
{
    public int? Duration { get; set; }

    //ONE-TO-MANY-MEDIA
    public int? MediaLinkId { get; set; }
    public MediaLink? MediaLink { get; set; }

    public Movie()
    {

    }
}