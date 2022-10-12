public class Characteristic
{
    public int? Id { get; set; }
    public string? Name { get; set; }

    //ONE-TO-MANY-MEDIA
    public int MediaLinkId { get; set; }
    public MediaLink MediaLink { get; set; }

    public Characteristic()
    {

    }
}