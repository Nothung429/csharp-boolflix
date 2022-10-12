public class Actor
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Nationality { get; set; }

    //ONE-TO-MANY-MEDIA
    public int MediaLinkId { get; set; }
    public MediaLink MediaLink { get; set; }

    public Actor()
    {

    }
}