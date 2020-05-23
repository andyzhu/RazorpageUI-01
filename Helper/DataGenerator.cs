using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPageUI.DataContext;
using RazorPageUI.Models;
using System.Linq;


namespace RazorPageUI.Helper
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BoardGamesDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<BoardGamesDbContext>>()))
                {
                    if (context.BoardGames.Any())
                    {
                        return;
                    }

                    context.BoardGames.AddRange(
                        new BoardGame 
                        {
                            ID = 1,
                            Title = "Candy Land",
                            PublishingCompany = "Hasbro",
                            MinPlayers = 2,
                            MaxPlayers = 4

                        },
                        new BoardGame
                        {
                            ID = 2,
                            Title = "Sorry!",
                            PublishingCompany = "Hasbro",
                            MinPlayers = 2,
                            MaxPlayers = 4
                        },
                        new BoardGame
                        {
                            ID = 3,
                            Title = "Ticket to Ride",
                            PublishingCompany = "Days of Wonder",
                            MinPlayers = 2,
                            MaxPlayers = 5
                        },
                        new BoardGame
                        {
                            ID = 4,
                            Title = "The Settlers of Catan (Expanded)",
                            PublishingCompany = "Catan Studio",
                            MinPlayers = 2,
                            MaxPlayers = 6
                        },
                        new BoardGame
                        {
                            ID = 5,
                            Title = "Carcasonne",
                            PublishingCompany = "Z-Man Games",
                            MinPlayers = 2,
                            MaxPlayers = 5
                        },
                        new BoardGame
                        {
                            ID = 6,
                            Title = "Sequence",
                            PublishingCompany = "Jax Games",
                            MinPlayers = 2,
                            MaxPlayers = 6
                        }
                    );

                context.SaveChanges();
                }
        }
    }
}