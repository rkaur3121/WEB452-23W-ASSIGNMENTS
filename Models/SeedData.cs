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
            using (var context = new MagnetsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MagnetsContext>>()))
            {
                // Look for any movies.
                if (context.Magnet.Any())
                {
                    return;   // DB has been seeded
                }

                context.Magnet.AddRange(
                    new Magnet
                    {
                    MagnetNames = "Neodymium magnet",
                     Material= "Neodymium,iron,boron",
                    Applications= "motors, generators, magnetic therapy, hard disk drives, headphones",
                    Strength= "1.4 teslas",
                    Rating= 5,
                     Price =100


                    },

                    new Magnet
                    {
                        MagnetNames = "Samarium cobalt magnet",
                        Material = "samarium and cobalt",
                        Applications = " aerospace, defense, electric motors, generators, sensors",
                        Strength = "35 MGOe",
                        Rating = 4,
                        Price = 90
                    },

                    new Magnet
                    {
                        MagnetNames = "Alnico magnet",
                        Material = "aluminum, nickel, cobalt, and iron",
                        Applications = "electric motors, generators, sensors, loudspeakers, guitar pickups ",
                        Strength = "50 megagauss-oersteds",
                        Rating = 5,
                        Price = 200
                    },

                    new Magnet
                    {
                        MagnetNames = "Ferrite magnet",
                        Material = "strontium or barium ferrite",
                        Applications = "motors, speakers, refrigerator magnets ",
                        Strength = " 0.5 teslas",
                        Rating = 3,
                        Price = 100
                    },
                    new Magnet
                    {
                        MagnetNames = "Electromagnet",
                        Material = "copper wire wrapped around a magnetic core",
                        Applications = "MRI machines, particle accelerators, cranes, maglev trains",
                        Strength = "depending on the amount of current flowing through the wire",
                        Rating = 5,
                        Price = 90
                    },
                  new Magnet
                  {
                      MagnetNames = "Permanent magnet",
                      Material = " neodymium, samarium cobalt, alnico, and ceramic",
                      Applications = "industrial and consumer applications ",
                      Strength = " depending on the material and the size",
                      Rating = 5,
                      Price = 100
                  },
                  new Magnet
                  {
                      MagnetNames = "Ceramic magnet",
                      Material = "strontium or barium ferrite",
                      Applications = "speakers, electric motors, magnetic separators, toys",
                      Strength = "0.5 teslas",
                      Rating = 4,
                      Price = 200
                  },
                  new Magnet
                  {
                      MagnetNames = "Flexible magnet",
                      Material = "strontium or barium ferrite",
                      Applications = "advertising, signage, toys, crafts ",
                      Strength = " 0.5 teslas",
                      Rating = 3,
                      Price = 150
                  },
                  new Magnet
                  {
                      MagnetNames = "Rare earth magnet",
                      Material = "neodymium, samarium cobalt, or a combination of rare earth metals",
                      Applications = "wind turbines, hard disk drives, speakers, electric motors ",
                      Strength = " 1.4 teslas",
                      Rating = 4,
                      Price = 200
                  },
                new Magnet
                {
                    MagnetNames = "Induction magnet",
                    Material = "iron or other magnetic materials used as a core",
                    Applications = " generators, motors, transformers ",
                    Strength = "depending on the amount of current flowing through the wire",
                    Rating = 5,
                    Price = 100
                }




                );
                context.SaveChanges();
            }
        }
    }
}
