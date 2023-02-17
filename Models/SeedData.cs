using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Magnets.Data;
using System;
using System.Linq;

namespace Magnets.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MagnetContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MagnetContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Magnets.AddRange(
                    new Magnet
                    {
                    MagnetNames ="",
                     Material="",
                    Applications="",
                    Strength="",
                    Rating=77,
                    Price=87
                 
              
                    },

                    new Magnet
                    {
                        MagnetNames = "",
                        Material = "",
                        Applications = "",
                        Strength = "",
                        Rating = 77,
                        Price = 87
                    },

                    new Magnet
                    {
                        MagnetNames = "",
                        Material = "",
                        Applications = "",
                        Strength = "",
                        Rating = 77,
                        Price = 87m
                    },

                    new Magnet
                    {
                        MagnetNames = "",
                        Material = "",
                        Applications = "",
                        Strength = "",
                        Rating = 77,
                        Price = 87
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
