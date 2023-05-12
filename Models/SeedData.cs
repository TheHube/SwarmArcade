using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Arcade.Models;
using ArcadeClasses;

namespace Seeding.Models
{
    // This static class is responsible for seeding the Movie database with initial data
    public static class SeedData
    {
        // This method initializes the database with the seed data
        public static void Initialize(IServiceProvider serviceProvider)
        {

            // Create an instance of the ArcadeDbContext using the options
            using (var db = new ArcadeDbContext())
            {

                // Drop the database if it exists
                db.Database.EnsureDeleted();

                // Create a new database
                db.Database.EnsureCreated();

                db.games.AddRange(
                    new game
                    {
                        title = "Swarm"
                    },
                    new game
                    {
                        title = "Clumsy Bird"
                    },
                    new game
                    {
                        title = "2048"
                    }
                );
                db.SaveChanges();

                db.players.AddRange(
                    new player
                    {
                        username = "John P."
                    },
                    new player
                    {
                        username = "Adam k."
                    },
                    new player
                    {
                        username = "Sarah F."
                    },
                    new player
                    {
                        username = "Lisa M."
                    },
                    new player
                    {
                        username = "Robert G."
                    }
                );
                db.SaveChanges();

                for (int i = 0; i < 5; i++)
                {
                    foreach (var g in db.games)
                    {
                        int maxScore;
                        if (g.title == "Swarm" || g.title == "Clumsy Bird")
                        {
                            maxScore = 200;
                        }
                        else if (g.title == "2048")
                        {
                            maxScore = 2048;
                        }
                        else
                        {
                            maxScore = 100;
                        }

                        foreach (var p in db.players)
                        {
                            db.scores.Add(new score
                            {
                                title = g.title,
                                username = p.username,
                                playerScore = new Random().Next(0, maxScore),
                            });
                        }
                    }
                }
                db.SaveChanges();
            }
        }
    }
}


