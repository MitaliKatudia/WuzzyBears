using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WuzzyBears.Data;


namespace WuzzyBears.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WuzzyBearContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WuzzyBearContext>>()))
            {
                // Look for any movies.
                if (context.WuzzyBear.Any())
                {
                    return;   // DB has been seeded
                }

                context.WuzzyBear.AddRange(
                    new WuzzyBear
                    {
                        TeddySerialNumber = "abcd123",
                        TypeOfTeddy = "Classic Teddy Bear",
                        MaterialOfTeddy = "Soft Foam",
                        Manufactured = DateTime.Parse("2022-5-20"),
                        SizeOfTeddy = 50,
                        CostOfTeddy = 14.99M
                    },

                    new WuzzyBear
                    {
                        TeddySerialNumber = "w233mw443dd",
                        TypeOfTeddy = "Panda Stuffed Toy",
                        MaterialOfTeddy = "Cotton Foam",
                        Manufactured = DateTime.Parse("2022-3-14"),
                        SizeOfTeddy = 25,
                        CostOfTeddy = 7.99M
                    },

                    new WuzzyBear
                    {
                        TeddySerialNumber = "snfkfg24nss3e2",
                        TypeOfTeddy = "Cuddle Teddy",
                        MaterialOfTeddy = "Thermofoam Beeds",
                        Manufactured = DateTime.Parse("2022-6-02"),
                        SizeOfTeddy = 75,
                        CostOfTeddy = 12.99M
                    },

                    new WuzzyBear
                    {
                        TeddySerialNumber = "ssf34nkjn44f",
                        TypeOfTeddy = "Big-Eyed Teddy Bear",
                        MaterialOfTeddy = "Cotton Balls",
                        Manufactured = DateTime.Parse("2022-1-28"),
                        SizeOfTeddy = 30,
                        CostOfTeddy = 9.99M
                    },

                    new WuzzyBear
                    {
                        TeddySerialNumber = "agg5gf464gd3",
                        TypeOfTeddy = "Teddy Girl - With Bow",
                        MaterialOfTeddy = "Soft Foam",
                        Manufactured = DateTime.Parse("2022-2-17"),
                        SizeOfTeddy = 15,
                        CostOfTeddy = 6.99M
                    },

                    new WuzzyBear
                    {
                        TeddySerialNumber = "s34dw6678ft7t",
                        TypeOfTeddy = "Puppy Twins",
                        MaterialOfTeddy = "Soft Foam",
                        Manufactured = DateTime.Parse("2021-10-02"),
                        SizeOfTeddy = 20,
                        CostOfTeddy = 8.99M
                    },

                    new WuzzyBear
                    {
                        TeddySerialNumber = "ub12jsj23jdj",
                        TypeOfTeddy = "Stiff Griff",
                        MaterialOfTeddy = "Cotton Foam",
                        Manufactured = DateTime.Parse("2022-07-30"),
                        SizeOfTeddy = 35,
                        CostOfTeddy = 7.99M
                    },

                    new WuzzyBear
                    {
                        TeddySerialNumber = "ihd37suf23fu",
                        TypeOfTeddy = "Unicorn Icon Shaped Teddy Bear",
                        MaterialOfTeddy = "Cotton Foam",
                        Manufactured = DateTime.Parse("2021-12-22"),
                        SizeOfTeddy = 25,
                        CostOfTeddy = 6.49M
                    },

                    new WuzzyBear
                    {
                        TeddySerialNumber = "fvji38bdjbf3",
                        TypeOfTeddy = "Bunny Rabbit Teddy",
                        MaterialOfTeddy = "Thermofoam Beeds",
                        Manufactured = DateTime.Parse("2021-6-07"),
                        SizeOfTeddy = 50,
                        CostOfTeddy = 7.99M
                    },

                    new WuzzyBear
                    {
                        TeddySerialNumber = "adj334hudf73",
                        TypeOfTeddy = "Keychain Teddy Bear",
                        MaterialOfTeddy = "Soft Foam",
                        Manufactured = DateTime.Parse("2022-1-27"),
                        SizeOfTeddy = 9,
                        CostOfTeddy = 2.99M
                    },

                    new WuzzyBear
                    {
                        TeddySerialNumber = "d8fb8912bds",
                        TypeOfTeddy = "Furr Teddy Bear",
                        MaterialOfTeddy = "Cotton Foam",
                        Manufactured = DateTime.Parse("2022-5-27"),
                        SizeOfTeddy = 40,
                        CostOfTeddy = 10.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
