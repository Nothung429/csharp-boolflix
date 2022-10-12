using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class NetflixContext : DbContext
{
    public DbSet<Movie>? Movies { get; set; }
    public DbSet<TVSerie>? TvSeries { get; set; }
    public DbSet<Episode>? Episodes { get; set; }
    public DbSet<Actor>? Actors { get; set; }
    public DbSet<Characteristic>? Characteristics { get; set; }
    public DbSet<Genre>? Genres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-Netflix;Integrated Security=True;Pooling=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //MODEL GENRE SEEDER
        modelBuilder.Entity<Genre>().HasData
        (
            new Genre
            {
                Id = 1,
                Name = "Action"
            },
            new Genre
            {
                Id = 2,
                Name = "Adventure"
            },
            new Genre
            {
                Id = 3,
                Name = "Fantasy"
            },
            new Genre
            {
                Id = 4,
                Name = "Sci-Fi"
            },
            new Genre
            {
                Id = 5,
                Name = "Horror"
            },
            new Genre
            {
                Id = 6,
                Name = "Noir"
            },
            new Genre
            {
                Id = 7,
                Name = "Drama"
            },
            new Genre
            {
                Id = 8,
                Name = "Comedy"
            },
            new Genre
            {
                Id = 9,
                Name = "Love-Story"
            }
        );

        //MODEL CHARACTERISTICS SEEDER
        modelBuilder.Entity<Characteristic>().HasData
        (
            new Characteristic
            {
                Id = 1,
                Name = "Pegi 13"
            },
            new Characteristic
            {
                Id = 2,
                Name = "Pegi 16"
            },
            new Characteristic
            {
                Id = 3,
                Name = "Pegi 18"
            },
            new Characteristic
            {
                Id = 4,
                Name = "Violence"
            },
            new Characteristic
            {
                Id = 5,
                Name = "Sex"
            },
            new Characteristic
            {
                Id = 6,
                Name = "Drugs"
            },
            new Characteristic
            {
                Id = 7,
                Name = "Splatter"
            },
            new Characteristic
            {
                Id = 8,
                Name = "Racism"
            },
            new Characteristic
            {
                Id = 9,
                Name = "Children"
            }
        );

        //MODEL ACTOR SEEDER
        modelBuilder.Entity<Actor>().HasData
        (
            new Actor
            {
                Id = 1,
                Name = "Scarlett",
                Surname = "Johansson",
                Nationality = "American"
            },
            new Actor
            {
                Id = 2,
                Name = "Elizabeth",
                Surname = "Olsen",
                Nationality = "American"
            },
            new Actor
            {
                Id = 3,
                Name = "Cate",
                Surname = "Blanchett",
                Nationality = "Australian"
            }
        );

        //MODEL TV-SERIE SEEDER
        modelBuilder.Entity<TVSerie>().HasData
        (
            new TVSerie
            {
                Id = 1,
                Seasons = 3,
                Title = "Padre Maronno",
                Description = "Mamma pare che sono santo"
            },
            new TVSerie
            {
                Id = 2,
                Seasons = 15,
                Title = "Supernatural",
                Description = "Winchester with a winchester"
            },
            new TVSerie
            {
                Id = 3,
                Seasons = 1,
                Title = "Boris",
                Description = "Tenet u' succ e mellone"
            }
        );

        //MODEL MOVIE SEEDER
        modelBuilder.Entity<Movie>().HasData
        (
            new Movie
            {
                Id = 1,
                Duration = 122,
                Title = "LOTR 1",
                Description = "ER MEJO"
            },
            new Movie
            {
                Id = 2,
                Duration = 188,
                Title = "LOTR 2",
                Description = "ER PIU MEJO"
            },
            new Movie
            {
                Id = 3,
                Duration = 244,
                Title = "LOTR 3",
                Description = "ER MEJO DER MEJO"
            }
        );

        //MODEL EPISODES SEEDER
        modelBuilder.Entity<Episode>().HasData
        (
            new Episode
            {
                Id = 1,
                Duration = 53,
                SeasonNumber = 1,
            },
            new Episode
            {
                Id = 2,
                Duration = 45,
                SeasonNumber = 1,
            },
            new Episode
            {
                Id = 3,
                Duration = 49,
                SeasonNumber = 2,
            }
        );
    }
}