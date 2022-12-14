using csharp_boolflix.Models;
using System.Security.Cryptography.X509Certificates;

public abstract class Media
{
    public int? Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public DateTime? ReleaseYaer { get; set; }
    public bool? IsNew { get; set; }
}