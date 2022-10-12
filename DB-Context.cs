using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class NetflixContext : DbContext
{
    public DbSet<Movie>? Movies { get; set; }
    public DbSet<TVSerie>? TvSeries { get; set; }
    public DbSet<Episode>? Episodes { get; set; }
    public DbSet<MediaLink>? MediaLinks { get; set; }
    public DbSet<Actor>? Actors { get; set; }
    public DbSet<Characteristic>? Characteristics { get; set; }
    public DbSet<Genre>? Genres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-Netflix;Integrated Security=True;Pooling=False");
    }
}