using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RainbowPlant.Data;
using System;
using System.Linq;

namespace RainbowPlant.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RainbowPlantContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RainbowPlantContext>>()))
        {
            // Look for any Plants.
            if (context.Plant.Any())
            {
                return;   // DB has been seeded
            }
            context.Plant.AddRange(
                new Plant
                {
                    PlantName = "Amur maple",
                    PlantDescription = "Full sun to part shade. Smaller species with hight 15 to 18 feet. Drought-tolerant.",
                    DateDelivered = DateTime.Parse("2022-9-25"),
                    Quantity = 20,
                    UnitPrice = 2.39M
                },
                new Plant
                {
                    PlantName = "Amur pine",
                    PlantDescription = "Full sun. Hight 40 to 50 feet. Prone to drought.",
                    DateDelivered = DateTime.Parse("2022-10-1"),
                    Quantity = 20,
                    UnitPrice = 4.32M
                },
                new Plant
                {
                    PlantName = "Dawn Redwood",
                    PlantDescription = "Full sun. Hight 40 to 100+ feet. Has needles and cones like many evergreens.",
                    DateDelivered = DateTime.Parse("2022-5-10"),
                    Quantity = 30,
                    UnitPrice = 5.8M
                },
                new Plant
                {
                    PlantName = "European mountain ash",
                    PlantDescription = "Full sun. 20 to 40 feet. Native to Asia.",
                    DateDelivered = DateTime.Parse("2022-10-5"),
                    Quantity = 35,
                    UnitPrice = 2.34M
                },
                new Plant
                {
                    PlantName = "Ginkgo Biloba",
                    PlantDescription = "Full sun to part shade. Hight 50 to 75+ feet. It produces messy fruits with a foul smell.",
                    DateDelivered = DateTime.Parse("2022-10-10"),
                    Quantity = 25,
                    UnitPrice = 8.56M
                },
                new Plant
                {
                    PlantName = "Paperbark cherry",
                    PlantDescription = "Full sun. Hight 20 to 30 feet. Has a distiguish shiny trunk.",
                    DateDelivered = DateTime.Parse("2022-10-10"),
                    Quantity = 24,
                    UnitPrice = 9.32M
                }
            );
            context.SaveChanges();
        }
    }
}